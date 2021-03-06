/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "PipeParser.java".  Description:
/// "An implementation of Parser that supports traditionally encoded (i.e"
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2001.  All Rights Reserved.
/// 
/// Contributor(s): Kenneth Beaton.
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// 
/// </summary>
using System;
using HL7Exception = ca.uhn.hl7v2.HL7Exception;
using Group = ca.uhn.hl7v2.model.Group;
using Message = ca.uhn.hl7v2.model.Message;
using Primitive = ca.uhn.hl7v2.model.Primitive;
using Segment = ca.uhn.hl7v2.model.Segment;
using Structure = ca.uhn.hl7v2.model.Structure;
using Type = ca.uhn.hl7v2.model.Type;
using Varies = ca.uhn.hl7v2.model.Varies;
using Terser = ca.uhn.hl7v2.util.Terser;
using MessageIterator = ca.uhn.hl7v2.util.MessageIterator;
using FilterIterator = ca.uhn.hl7v2.util.FilterIterator;
using HapiLog = ca.uhn.log.HapiLog;
using HapiLogFactory = ca.uhn.log.HapiLogFactory;
namespace ca.uhn.hl7v2.parser
{
	
	/// <summary> An implementation of Parser that supports traditionally encoded (ie delimited with characters
	/// like |, ^, and ~) HL7 messages.  Unexpected segments and fields are parsed into generic elements
	/// that are added to the message.  
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	public class PipeParser:Parser
	{
		//UPGRADE_NOTE: Field 'EnclosingInstance' was added to class 'AnonymousClassPredicate' to access its enclosing instance. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1019'"
		private class AnonymousClassPredicate : FilterIterator.Predicate
		{
			public AnonymousClassPredicate(PipeParser enclosingInstance)
			{
				InitBlock(enclosingInstance);
			}
			private void  InitBlock(PipeParser enclosingInstance)
			{
				this.enclosingInstance = enclosingInstance;
			}
			private PipeParser enclosingInstance;
			public PipeParser Enclosing_Instance
			{
				get
				{
					return enclosingInstance;
				}
				
			}
			public virtual bool evaluate(System.Object obj)
			{
				if (typeof(Segment).IsAssignableFrom(obj.GetType()))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		//UPGRADE_NOTE: Field 'EnclosingInstance' was added to class 'AnonymousClassPredicate1' to access its enclosing instance. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1019'"
		private class AnonymousClassPredicate1 : FilterIterator.Predicate
		{
			public AnonymousClassPredicate1(System.String name, PipeParser enclosingInstance)
			{
				InitBlock(name, enclosingInstance);
			}
			private void  InitBlock(System.String name, PipeParser enclosingInstance)
			{
				this.name = name;
				this.enclosingInstance = enclosingInstance;
			}
			//UPGRADE_NOTE: Final variable name was copied into class AnonymousClassPredicate1. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1023'"
			private System.String name;
			private PipeParser enclosingInstance;
			public PipeParser Enclosing_Instance
			{
				get
				{
					return enclosingInstance;
				}
				
			}
			public virtual bool evaluate(System.Object obj)
			{
				Structure s = (Structure) obj;
				ca.uhn.hl7v2.parser.PipeParser.log.debug("PipeParser iterating message in direction " + name + " at " + s.getStructureName());
				if (System.Text.RegularExpressions.Regex.IsMatch(s.getStructureName(), name + "\\d*"))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		/// <returns> the preferred encoding of this Parser
		/// </returns>
		override public System.String DefaultEncoding
		{
			get
			{
				return "VB";
			}
			
		}
		
		//UPGRADE_NOTE: Final was removed from the declaration of 'log '. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1003'"
		//UPGRADE_NOTE: The initialization of  'log' was moved to static method 'ca.uhn.hl7v2.parser.PipeParser'. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1005'"
		private static readonly HapiLog log;
		
		public const System.String segDelim = "\r"; //see section 2.8 of spec
		
		/// <summary>Creates a new PipeParser </summary>
		public PipeParser()
		{
		}
		
		/// <summary> Returns a String representing the encoding of the given message, if
		/// the encoding is recognized.  For example if the given message appears
		/// to be encoded using HL7 2.x XML rules then "XML" would be returned.
		/// If the encoding is not recognized then null is returned.  That this
		/// method returns a specific encoding does not guarantee that the
		/// message is correctly encoded (e.g. well formed XML) - just that
		/// it is not encoded using any other encoding than the one returned.
		/// </summary>
		public override System.String getEncoding(System.String message)
		{
			System.String encoding = null;
			
			//quit if the string is too short
			if (message.Length < 4)
				return null;
			
			//see if it looks like this message is | encoded ...
			bool ok = true;
			
			//string should start with "MSH"
			if (!message.StartsWith("MSH"))
				return null;
			
			//4th character of each segment should be field delimiter
			char fourthChar = message[3];
			char[] fourthCharArray = fourthChar.ToString().ToCharArray();
			Tokenizer st = new Tokenizer(message, segDelim, false);
			while (st.HasMoreTokens)
			{
				System.String x = st.NextToken();
				if (x.Length > 0)
				{
					if (System.Char.IsWhiteSpace(x[0]))
						x = stripLeadingWhitespace(x);
					
					if (x.Length >= 4)
					{
						string[] parts = x.Split(fourthCharArray,1);
						if(parts.Length==0)
							return null;

						if(parts[0].Length==3 && x[3] !=fourthChar)
						{
							return null;
						}
						//CDC: If a segment is a non-standard segment and there are multiple, the segment name might by 4 char long
						if(parts[0].Length != x.Length && parts[0].Length==4 && x[4] !=fourthChar)
						{
							return null;
						}
					}
				}
			}
			
			//should be at least 11 field delimiters (because MSH-12 is required)
			int nextFieldDelimLoc = 0;
			for (int i = 0; i < 11; i++)
			{
				//UPGRADE_WARNING: Method 'java.lang.String.indexOf' was converted to 'System.String.IndexOf' which may throw an exception. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1101'"
				nextFieldDelimLoc = message.IndexOf((System.Char) fourthChar, nextFieldDelimLoc + 1);
				if (nextFieldDelimLoc < 0)
					return null;
			}
			
			if (ok)
				encoding = "VB";
			
			return encoding;
		}
		
		/// <summary> Returns true if and only if the given encoding is supported
		/// by this Parser.
		/// </summary>
		public override bool supportsEncoding(System.String encoding)
		{
			bool supports = false;
			if (encoding != null && encoding.Equals("VB"))
				supports = true;
			return supports;
		}
		
		/// <deprecated> this method should not be public 
		/// </deprecated>
		/// <param name="message">
		/// </param>
		/// <returns>
		/// </returns>
		/// <throws>  HL7Exception </throws>
		/// <throws>  EncodingNotSupportedException </throws>
		public virtual System.String getMessageStructure(System.String message)
		{
			return getStructure(message).messageStructure;
		}
		
		/// <returns>s the message structure from MSH-9-3
		/// </returns>
		private MessageStructure getStructure(System.String message)
		{
			EncodingCharacters ec = getEncodingChars(message);
			System.String messageStructure = null;
			bool explicityDefined = true;
			System.String wholeFieldNine;
			try
			{
				System.String[] fields = split(message.Substring(0, (System.Math.Max(message.IndexOf(segDelim), message.Length)) - (0)), System.Convert.ToString(ec.FieldSeparator));
				wholeFieldNine = fields[8];
				
				//message structure is component 3 but we'll accept a composite of 1 and 2 if there is no component 3 ...
				//      if component 1 is ACK, then the structure is ACK regardless of component 2
				System.String[] comps = split(wholeFieldNine, System.Convert.ToString(ec.ComponentSeparator));
				if (comps.Length >= 3)
				{
					messageStructure = comps[2];
				}
				else if (comps.Length > 0 && comps[0] != null && comps[0].Equals("ACK"))
				{
					messageStructure = "ACK";
				}
				else if (comps.Length == 2)
				{
					explicityDefined = false;
					messageStructure = comps[0] + "_" + comps[1];
				}
					/*else if (comps.length == 1 && comps[0] != null && comps[0].equals("ACK")) {
					messageStructure = "ACK"; //it's common for people to only populate component 1 in an ACK msg
					}*/
				else
				{
					System.Text.StringBuilder buf = new System.Text.StringBuilder("Can't determine message structure from MSH-9: ");
					buf.Append(wholeFieldNine);
					if (comps.Length < 3)
					{
						buf.Append(" HINT: there are only ");
						buf.Append(comps.Length);
						buf.Append(" of 3 components present");
					}
					throw new HL7Exception(buf.ToString(), HL7Exception.UNSUPPORTED_MESSAGE_TYPE);
				}
			}
			catch (System.IndexOutOfRangeException e)
			{
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				throw new HL7Exception("Can't find message structure (MSH-9-3): " + e.Message, HL7Exception.UNSUPPORTED_MESSAGE_TYPE);
			}
			
			return new MessageStructure(messageStructure, explicityDefined);
		}
		
		/// <summary> Returns object that contains the field separator and encoding characters
		/// for this message.
		/// </summary>
		private static EncodingCharacters getEncodingChars(System.String message)
		{
			return new EncodingCharacters(message[3], message.Substring(4, (8) - (4)));
		}
		
		/// <summary> Parses a message string and returns the corresponding Message
		/// object.  Unexpected segments added at the end of their group.  
		/// 
		/// </summary>
		/// <throws>  HL7Exception if the message is not correctly formatted. </throws>
		/// <throws>  EncodingNotSupportedException if the message encoded </throws>
		/// <summary>      is not supported by this parser.
		/// </summary>
		protected internal override Message doParse(System.String message, System.String version)
		{
			
			//try to instantiate a message object of the right class
			MessageStructure structure = getStructure(message);
			Message m = instantiateMessage(structure.messageStructure, version, structure.explicitlyDefined);
			
			//MessagePointer ptr = new MessagePointer(this, m, getEncodingChars(message));
			MessageIterator messageIter = new MessageIterator(m, "MSH", true);
			FilterIterator.Predicate segmentsOnly = new AnonymousClassPredicate(this);
			FilterIterator segmentIter = new FilterIterator(messageIter, segmentsOnly);
			
			System.String[] segments = split(message, segDelim);
			for (int i = 0; i < segments.Length; i++)
			{
				
				//get rid of any leading whitespace characters ...
				if (segments[i] != null && segments[i].Length > 0 && System.Char.IsWhiteSpace(segments[i][0]))
					segments[i] = stripLeadingWhitespace(segments[i]);
				
				//sometimes people put extra segment delimiters at end of msg ...
				if (segments[i] != null && segments[i].Length >= 3)
				{
					//UPGRADE_NOTE: Final was removed from the declaration of 'name '. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1003'"
					System.String name = segments[i].Substring(0, (3) - (0));
					log.debug("Parsing segment " + name);
					
					messageIter.Direction = name;
					FilterIterator.Predicate byDirection = new AnonymousClassPredicate1(name, this);
					FilterIterator dirIter = new FilterIterator(segmentIter, byDirection);
					//UPGRADE_TODO: Method 'java.util.Iterator.hasNext' was converted to 'System.Collections.IEnumerator.MoveNext' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilIteratorhasNext'"
					if (dirIter.MoveNext())
					{
						//UPGRADE_TODO: Method 'java.util.Iterator.next' was converted to 'System.Collections.IEnumerator.Current' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilIteratornext'"
						parse((Segment) dirIter.Current, segments[i], getEncodingChars(message));
					}
				}
			}
			return m;
		}
		
		/// <summary> Parses a segment string and populates the given Segment object.  Unexpected fields are
		/// added as Varies' at the end of the segment.  
		/// 
		/// </summary>
		/// <throws>  HL7Exception if the given string does not contain the </throws>
		/// <summary>      given segment or if the string is not encoded properly
		/// </summary>
		public virtual void  parse(Segment destination, System.String segment, EncodingCharacters encodingChars)
		{
			int fieldOffset = 0;
			if (isDelimDefSegment(destination.getStructureName()))
			{
				fieldOffset = 1;
				//set field 1 to fourth character of string
				Terser.Set(destination, 1, 0, 1, 1, System.Convert.ToString(encodingChars.FieldSeparator));
			}
			
			System.String[] fields = split(segment, System.Convert.ToString(encodingChars.FieldSeparator));
			//destination.setName(fields[0]);
			for (int i = 1; i < fields.Length; i++)
			{
				System.String[] reps = split(fields[i], System.Convert.ToString(encodingChars.RepetitionSeparator));
				if (log.DebugEnabled)
				{
					log.debug(reps.Length + "reps delimited by: " + encodingChars.RepetitionSeparator);
				}
				
				//MSH-2 will get split incorrectly so we have to fudge it ...
				bool isMSH2 = isDelimDefSegment(destination.getStructureName()) && i + fieldOffset == 2;
				if (isMSH2)
				{
					reps = new System.String[1];
					reps[0] = fields[i];
				}
				
				for (int j = 0; j < reps.Length; j++)
				{
					try
					{
						System.Text.StringBuilder statusMessage = new System.Text.StringBuilder("Parsing field ");
						statusMessage.Append(i + fieldOffset);
						statusMessage.Append(" repetition ");
						statusMessage.Append(j);
						log.debug(statusMessage.ToString());
						//parse(destination.getField(i + fieldOffset, j), reps[j], encodingChars, false);
						
						Type field = destination.getField(i + fieldOffset, j);
						if (isMSH2)
						{
							Terser.getPrimitive(field, 1, 1).Value = reps[j];
						}
						else
						{
							parse(field, reps[j], encodingChars);
						}
					}
					catch (HL7Exception e)
					{
						//set the field location and throw again ...
						e.FieldPosition = i;
						e.SegmentRepetition = MessageIterator.getIndex(destination.ParentGroup, destination).rep;
						e.SegmentName = destination.getStructureName();
						throw e;
					}
				}
			}
			
			//set data type of OBX-5
			if (destination.GetType().FullName.IndexOf("OBX") >= 0)
			{
				Varies.fixOBX5(destination, Factory);
			}
		}
		
		/// <returns> true if the segment is MSH, FHS, or BHS.  These need special treatment 
		/// because they define delimiters.
		/// </returns>
		/// <param name="theSegmentName">
		/// </param>
		private static bool isDelimDefSegment(System.String theSegmentName)
		{
			bool is_Renamed = false;
			if (theSegmentName.Equals("MSH") || theSegmentName.Equals("FHS") || theSegmentName.Equals("BHS"))
			{
				is_Renamed = true;
			}
			return is_Renamed;
		}
		
		/// <summary> Fills a field with values from an unparsed string representing the field.  </summary>
		/// <param name="destinationField">the field Type
		/// </param>
		/// <param name="data">the field string (including all components and subcomponents; not including field delimiters)
		/// </param>
		/// <param name="encodingCharacters">the encoding characters used in the message
		/// </param>
		private static void  parse(Type destinationField, System.String data, EncodingCharacters encodingCharacters)
		{
			System.String[] components = split(data, System.Convert.ToString(encodingCharacters.ComponentSeparator));
			for (int i = 0; i < components.Length; i++)
			{
				System.String[] subcomponents = split(components[i], System.Convert.ToString(encodingCharacters.SubcomponentSeparator));
				for (int j = 0; j < subcomponents.Length; j++)
				{
					System.String val = subcomponents[j];
					if (val != null)
					{
						val = Escape.unescape(val, encodingCharacters);
					}
					Terser.getPrimitive(destinationField, i + 1, j + 1).Value = val;
				}
			}
		}
		
		/// <summary>Returns the component or subcomponent separator from the given encoding characters. </summary>
		private static char getSeparator(bool subComponents, EncodingCharacters encodingChars)
		{
			char separator;
			if (subComponents)
			{
				separator = encodingChars.SubcomponentSeparator;
			}
			else
			{
				separator = encodingChars.ComponentSeparator;
			}
			return separator;
		}
		
		/// <summary> Splits the given composite string into an array of components using the given
		/// delimiter.
		/// </summary>
		public static System.String[] split(System.String composite, System.String delim)
		{
			System.Collections.ArrayList components = new System.Collections.ArrayList();
			
			//defend against evil nulls
			if (composite == null)
				composite = "";
			if (delim == null)
				delim = "";

			Tokenizer tok = new Tokenizer(composite, delim, false);
			bool previousTokenWasDelim = true;
			while (tok.HasMoreTokens)
			{
				System.String thisTok = tok.NextToken();
				if (thisTok.Equals(delim))
				{
					if (previousTokenWasDelim)
						components.Add(null);
					previousTokenWasDelim = true;
				}
				else
				{
					components.Add(thisTok);
					previousTokenWasDelim = false;
				}
			}
			
			System.String[] ret = new System.String[components.Count];
			for (int i = 0; i < components.Count; i++)
			{
				ret[i] = ((System.String) components[i]);
			}
			
			return ret;
		}
		
		/// <summary> Encodes the given Type, using the given encoding characters. 
		/// It is assumed that the Type represents a complete field rather than a component.
		/// </summary>
		public static System.String encode(Type source, EncodingCharacters encodingChars)
		{
			System.Text.StringBuilder field = new System.Text.StringBuilder();
			for (int i = 1; i <= Terser.numComponents(source); i++)
			{
				System.Text.StringBuilder comp = new System.Text.StringBuilder();
				for (int j = 1; j <= Terser.numSubComponents(source, i); j++)
				{
					Primitive p = Terser.getPrimitive(source, i, j);
					comp.Append(encodePrimitive(p, encodingChars));
					comp.Append(encodingChars.SubcomponentSeparator);
				}
				field.Append(stripExtraDelimiters(comp.ToString(), encodingChars.SubcomponentSeparator));
				field.Append(encodingChars.ComponentSeparator);
			}
			return stripExtraDelimiters(field.ToString(), encodingChars.ComponentSeparator);
			//return encode(source, encodingChars, false);
		}
		
		private static System.String encodePrimitive(Primitive p, EncodingCharacters encodingChars)
		{
			System.String val = ((Primitive) p).Value;
			if (val == null)
			{
				val = "";
			}
			else
			{
				val = Escape.escape(val, encodingChars);
			}
			return val;
		}
		
		/// <summary> Removes unecessary delimiters from the end of a field or segment.
		/// This seems to be more convenient than checking to see if they are needed
		/// while we are building the encoded string.
		/// </summary>
		private static System.String stripExtraDelimiters(System.String in_Renamed, char delim)
		{
			char[] chars = in_Renamed.ToCharArray();
			
			//search from back end for first occurance of non-delimiter ...
			int c = chars.Length - 1;
			bool found = false;
			while (c >= 0 && !found)
			{
				if (chars[c--] != delim)
					found = true;
			}
			
			System.String ret = "";
			if (found)
				ret = new System.String(chars, 0, c + 2);
			return ret;
		}
		
		/// <summary> Formats a Message object into an HL7 message string using the given
		/// encoding.
		/// </summary>
		/// <throws>  HL7Exception if the data fields in the message do not permit encoding </throws>
		/// <summary>      (e.g. required fields are null)
		/// </summary>
		/// <throws>  EncodingNotSupportedException if the requested encoding is not </throws>
		/// <summary>      supported by this parser.
		/// </summary>
		protected internal override System.String doEncode(Message source, System.String encoding)
		{
			if (!this.supportsEncoding(encoding))
				throw new EncodingNotSupportedException("This parser does not support the " + encoding + " encoding");
			
			return encode(source);
		}
		
		/// <summary> Formats a Message object into an HL7 message string using this parser's
		/// default encoding ("VB").
		/// </summary>
		/// <throws>  HL7Exception if the data fields in the message do not permit encoding </throws>
		/// <summary>      (e.g. required fields are null)
		/// </summary>
		protected internal override System.String doEncode(Message source)
		{
			//get encoding characters ...
			Segment msh = (Segment) source.get_Renamed("MSH");
			System.String fieldSepString = Terser.Get(msh, 1, 0, 1, 1);
			
			if (fieldSepString == null)
				throw new HL7Exception("Can't encode message: MSH-1 (field separator) is missing");
			
			char fieldSep = '|';
			if (fieldSepString != null && fieldSepString.Length > 0)
				fieldSep = fieldSepString[0];
			
			System.String encCharString = Terser.Get(msh, 2, 0, 1, 1);
			
			if (encCharString == null)
				throw new HL7Exception("Can't encode message: MSH-2 (encoding characters) is missing");
			
			if (encCharString.Length != 4)
				throw new HL7Exception("Encoding characters '" + encCharString + "' invalid -- must be 4 characters", HL7Exception.DATA_TYPE_ERROR);
			EncodingCharacters en = new EncodingCharacters(fieldSep, encCharString);
			
			//pass down to group encoding method which will operate recursively on children ...
			return encode((Group) source, en);
		}
		
		/// <summary> Returns given group serialized as a pipe-encoded string - this method is called
		/// by encode(Message source, String encoding).
		/// </summary>
		public static System.String encode(Group source, EncodingCharacters encodingChars)
		{
			System.Text.StringBuilder result = new System.Text.StringBuilder();
			
			System.String[] names = source.Names;
			for (int i = 0; i < names.Length; i++)
			{
				Structure[] reps = source.getAll(names[i]);
				for (int rep = 0; rep < reps.Length; rep++)
				{
					if (reps[rep] is Group)
					{
						result.Append(encode((Group) reps[rep], encodingChars));
					}
					else
					{
						System.String segString = encode((Segment) reps[rep], encodingChars);
						if (segString.Length >= 4)
						{
							result.Append(segString);
							result.Append('\r');
						}
					}
				}
			}
			return result.ToString();
		}
		
		public static System.String encode(Segment source, EncodingCharacters encodingChars)
		{
			System.Text.StringBuilder result = new System.Text.StringBuilder();
			result.Append(source.getStructureName());
			result.Append(encodingChars.FieldSeparator);
			
			//start at field 2 for MSH segment because field 1 is the field delimiter
			int startAt = 1;
			if (isDelimDefSegment(source.getStructureName()))
				startAt = 2;
			
			//loop through fields; for every field delimit any repetitions and add field delimiter after ...
			int numFields = source.numFields();
			for (int i = startAt; i <= numFields; i++)
			{
				try
				{
					Type[] reps = source.getField(i);
					for (int j = 0; j < reps.Length; j++)
					{
						System.String fieldText = encode(reps[j], encodingChars);
						//if this is MSH-2, then it shouldn't be escaped, so unescape it again
						if (isDelimDefSegment(source.getStructureName()) && i == 2)
							fieldText = Escape.unescape(fieldText, encodingChars);
						result.Append(fieldText);
						if (j < reps.Length - 1)
							result.Append(encodingChars.RepetitionSeparator);
					}
				}
				catch (HL7Exception e)
				{
					log.error("Error while encoding segment: ", e);
				}
				result.Append(encodingChars.FieldSeparator);
			}
			
			//strip trailing delimiters ...
			return stripExtraDelimiters(result.ToString(), encodingChars.FieldSeparator);
		}
		
		/// <summary> Removes leading whitespace from the given string.  This method was created to deal with frequent
		/// problems parsing messages that have been hand-written in windows.  The intuitive way to delimit
		/// segments is to hit <ENTER> at the end of each segment, but this creates both a carriage return
		/// and a line feed, so to the parser, the first character of the next segment is the line feed.
		/// </summary>
		public static System.String stripLeadingWhitespace(System.String in_Renamed)
		{
			System.Text.StringBuilder out_Renamed = new System.Text.StringBuilder();
			char[] chars = in_Renamed.ToCharArray();
			int c = 0;
			while (c < chars.Length)
			{
				if (!System.Char.IsWhiteSpace(chars[c]))
					break;
				c++;
			}
			for (int i = c; i < chars.Length; i++)
			{
				out_Renamed.Append(chars[i]);
			}
			return out_Renamed.ToString();
		}
		
		/// <summary> <p>Returns a minimal amount of data from a message string, including only the
		/// data needed to send a response to the remote system.  This includes the
		/// following fields:
		/// <ul><li>field separator</li>
		/// <li>encoding characters</li>
		/// <li>processing ID</li>
		/// <li>message control ID</li></ul>
		/// This method is intended for use when there is an error parsing a message,
		/// (so the Message object is unavailable) but an error message must be sent
		/// back to the remote system including some of the information in the inbound
		/// message.  This method parses only that required information, hopefully
		/// avoiding the condition that caused the original error.  The other
		/// fields in the returned MSH segment are empty.</p>
		/// </summary>
		public override Segment getCriticalResponseData(System.String message)
		{
			//try to get MSH segment
			int locStartMSH = message.IndexOf("MSH");
			if (locStartMSH < 0)
				throw new HL7Exception("Couldn't find MSH segment in message: " + message, HL7Exception.SEGMENT_SEQUENCE_ERROR);
			//UPGRADE_WARNING: Method 'java.lang.String.indexOf' was converted to 'System.String.IndexOf' which may throw an exception. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1101'"
			int locEndMSH = message.IndexOf('\r', locStartMSH + 1);
			if (locEndMSH < 0)
				locEndMSH = message.Length;
			System.String mshString = message.Substring(locStartMSH, (locEndMSH) - (locStartMSH));
			
			//find out what the field separator is
			char fieldSep = mshString[3];
			
			//get field array
			System.String[] fields = split(mshString, System.Convert.ToString(fieldSep));
			
			Segment msh = null;
			try
			{
				//parse required fields
				System.String encChars = fields[1];
				char compSep = encChars[0];
				System.String messControlID = fields[9];
				System.String[] procIDComps = split(fields[10], System.Convert.ToString(compSep));
				
				//fill MSH segment
				System.String version = "2.4"; //default
				try
				{
					version = this.getVersion(message);
				}
				catch (System.Exception)
				{
					/* use the default */
				}
				
				msh = Parser.makeControlMSH(version, Factory);
				Terser.Set(msh, 1, 0, 1, 1, System.Convert.ToString(fieldSep));
				Terser.Set(msh, 2, 0, 1, 1, encChars);
				Terser.Set(msh, 10, 0, 1, 1, messControlID);
				Terser.Set(msh, 11, 0, 1, 1, procIDComps[0]);
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Class.getName' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				throw new HL7Exception("Can't parse critical fields from MSH segment (" + e.GetType().FullName + ": " + e.Message + "): " + mshString, HL7Exception.REQUIRED_FIELD_MISSING);
			}
			
			return msh;
		}
		
		/// <summary> For response messages, returns the value of MSA-2 (the message ID of the message
		/// sent by the sending system).  This value may be needed prior to main message parsing,
		/// so that (particularly in a multi-threaded scenario) the message can be routed to
		/// the thread that sent the request.  We need this information first so that any
		/// parse exceptions are thrown to the correct thread.
		/// Returns null if MSA-2 can not be found (e.g. if the message is not a
		/// response message).
		/// </summary>
		public override System.String getAckID(System.String message)
		{
			System.String ackID = null;
			int startMSA = message.IndexOf("\rMSA");
			if (startMSA >= 0)
			{
				int startFieldOne = startMSA + 5;
				char fieldDelim = message[startFieldOne - 1];
				//UPGRADE_WARNING: Method 'java.lang.String.indexOf' was converted to 'System.String.IndexOf' which may throw an exception. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1101'"
				int start = message.IndexOf((System.Char) fieldDelim, startFieldOne) + 1;
				//UPGRADE_WARNING: Method 'java.lang.String.indexOf' was converted to 'System.String.IndexOf' which may throw an exception. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1101'"
				int end = message.IndexOf((System.Char) fieldDelim, start);
				//UPGRADE_WARNING: Method 'java.lang.String.indexOf' was converted to 'System.String.IndexOf' which may throw an exception. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1101'"
				int segEnd = message.IndexOf(System.Convert.ToString(segDelim), start);
				if (segEnd > start && segEnd < end)
					end = segEnd;
				
				//if there is no field delim after MSH-2, need to go to end of message, but not including end seg delim if it exists
				if (end < 0)
				{
					if (message[message.Length - 1] == '\r')
					{
						end = message.Length - 1;
					}
					else
					{
						end = message.Length;
					}
				}
				if (start > 0 && end > start)
				{
					ackID = message.Substring(start, (end) - (start));
				}
			}
			log.debug("ACK ID: " + ackID);
			return ackID;
		}
		
		/// <summary> Returns the version ID (MSH-12) from the given message, without fully parsing the message.
		/// The version is needed prior to parsing in order to determine the message class
		/// into which the text of the message should be parsed.
		/// </summary>
		/// <throws>  HL7Exception if the version field can not be found. </throws>
		public override System.String getVersion(System.String message)
		{
			int startMSH = message.IndexOf("MSH");
			//UPGRADE_WARNING: Method 'java.lang.String.indexOf' was converted to 'System.String.IndexOf' which may throw an exception. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1101'"
			int endMSH = message.IndexOf(PipeParser.segDelim, startMSH);
			if (endMSH < 0)
				endMSH = message.Length;
			System.String msh = message.Substring(startMSH, (endMSH) - (startMSH));
			System.String fieldSep = null;
			if (msh.Length > 3)
			{
				fieldSep = System.Convert.ToString(msh[3]);
			}
			else
			{
				throw new HL7Exception("Can't find field separator in MSH: " + msh, HL7Exception.UNSUPPORTED_VERSION_ID);
			}
			
			System.String[] fields = split(msh, fieldSep);
			
			System.String compSep = null;
			if (fields.Length >= 2 && fields[1].Length > 0)
			{
				compSep = System.Convert.ToString(fields[1][0]); //get component separator as 1st encoding char
			}
			else
			{
				throw new HL7Exception("Can't find encoding characters - MSH has only " + fields.Length + " fields", HL7Exception.REQUIRED_FIELD_MISSING);
			}
			
			System.String version = null;
			if (fields.Length >= 12)
			{
				version = split(fields[11], compSep)[0];
			}
			else
			{
				throw new HL7Exception("Can't find version ID - MSH has only " + fields.Length + " fields.", HL7Exception.REQUIRED_FIELD_MISSING);
			}
			return version;
		}
		
		/// <summary> A struct for holding a message class string and a boolean indicating whether it 
		/// was defined explicitly.  
		/// </summary>
		private class MessageStructure
		{
			public System.String messageStructure;
			public bool explicitlyDefined;
			
			public MessageStructure(System.String theMessageStructure, bool isExplicitlyDefined)
			{
				messageStructure = theMessageStructure;
				explicitlyDefined = isExplicitlyDefined;
			}
		}
		static PipeParser()
		{
			log = HapiLogFactory.getHapiLog(typeof(PipeParser));
		}
	}
}