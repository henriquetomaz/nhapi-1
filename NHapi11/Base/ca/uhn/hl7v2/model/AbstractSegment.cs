/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "AbstractSegment.java".  Description: 
/// "Provides common functionality needed by implementers of the Segment interface.
/// Implementing classes should define all the fields for the segment they represent 
/// in their constructor" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using HL7Exception = ca.uhn.hl7v2.HL7Exception;
using ModelClassFactory = ca.uhn.hl7v2.parser.ModelClassFactory;
using HapiLog = ca.uhn.log.HapiLog;
using HapiLogFactory = ca.uhn.log.HapiLogFactory;
namespace ca.uhn.hl7v2.model
{
	
	/// <summary> <p>Provides common functionality needed by implementers of the Segment interface.</p>
	/// <p>Implementing classes should define all the fields for the segment they represent 
	/// in their constructor.  The add() method is useful for this purpose.</p>
	/// <p>For example the constructor for an MSA segment might contain the following code:<br> 
	/// <code>this.add(new ID(), true, 2, null);<br>
	/// this.add(new ST(), true, 20, null);<br>...</code></p>
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	public abstract class AbstractSegment : Segment
	{
		/// <summary> Returns the Message to which this segment belongs.  </summary>
		virtual public Message Message
		{
			get
			{
				Structure s = this;
				while (!typeof(Message).IsAssignableFrom(s.GetType()))
				{
					s = s.ParentGroup;
				}
				return (Message) s;
			}
			
		}
		virtual public Group ParentGroup
		{
			get
			{
				return this.parent;
			}
			
		}
		
		//UPGRADE_NOTE: Final was removed from the declaration of 'log '. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1003'"
		//UPGRADE_NOTE: The initialization of  'log' was moved to static method 'ca.uhn.hl7v2.model.AbstractSegment'. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1005'"
		private static readonly HapiLog log;
		
		private System.Collections.ArrayList fields;
		private System.Collections.ArrayList types;
		private System.Collections.ArrayList required;
		private System.Collections.ArrayList length;
		private System.Collections.ArrayList args;
		private System.Collections.ArrayList maxReps;
		private System.Collections.ArrayList fieldDescriptions;
		private Group parent;
		//private Message message;
		//private String name;
		
		/// <summary> Calls the abstract init() method to create the fields in this segment.
		/// 
		/// </summary>
		/// <param name="parent">parent group
		/// </param>
		/// <param name="factory">all implementors need a model class factory to find datatype classes, so we 
		/// include it as an arg here to emphasize that fact ... AbstractSegment doesn't actually 
		/// use it though
		/// </param>
		public AbstractSegment(Group parent, ModelClassFactory factory)
		{
			this.parent = parent;
			this.fields = new System.Collections.ArrayList();
			this.types = new System.Collections.ArrayList();
			this.required = new System.Collections.ArrayList();
			this.length = new System.Collections.ArrayList();
			this.args = new System.Collections.ArrayList();
			this.maxReps = new System.Collections.ArrayList();
			this.fieldDescriptions = new System.Collections.ArrayList();
		}
		
		/// <summary> Returns an array of Field objects at the specified location in the segment.  In the case of
		/// non-repeating fields the array will be of length one.  Fields are numbered from 1.
		/// </summary>
		public virtual Type[] getField(int number)
		{
			
			ensureEnoughFields(number);
			
			if (number < 1 || number > fields.Count)
			{
				throw new HL7Exception("Can't retrieve field " + number + " from segment " + this.GetType().FullName + " - there are only " + fields.Count + " fields.", HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			
			return (Type[]) fields[number - 1]; //note: fields are numbered from 1 from the user's perspective
		}

		/// <summary> Return the field description.  Fields are numbered from 1.
		/// </summary>
		public virtual string getFieldDescription(int number)
		{
			ensureEnoughFields(number);
			if(number<1 || number >fields.Count)
			{
				throw new HL7Exception("Can't retrieve field " + number + " from segment " + this.GetType().FullName + " - there are only " + fields.Count + " fields.", HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			return (string)fieldDescriptions[number-1];
		}
		
		/// <summary> Returns a specific repetition of field at the specified index.  If there exist 
		/// fewer repetitions than are required, the number of repetitions can be increased 
		/// by specifying the lowest repetition that does not yet exist.  For example 
		/// if there are two repetitions but three are needed, the third can be created
		/// and accessed using the following code: <br>
		/// <code>Type t = getField(x, 3);</code>
		/// </summary>
		/// <param name="number">the field number 
		/// </param>
		/// <param name="rep">the repetition number (starting at 0)
		/// </param>
		/// <throws>  HL7Exception if field index is out of range, if the specified  </throws>
		/// <summary>    repetition is greater than the maximum allowed, or if the specified 
		/// repetition is more than 1 greater than the existing # of repetitions.  
		/// </summary>
		public virtual Type getField(int number, int rep)
		{
			Type[] arr = this.getField(number);
			
			//check if out of range ... 
			if (rep > arr.Length)
				throw new HL7Exception("Can't get repetition " + rep + " from field " + number + " - there are currently only " + arr.Length + " reps.", HL7Exception.APPLICATION_INTERNAL_ERROR);
			
			/*if (this.getMaxCardinality(number) > 0 && rep >= this.getMaxCardinality(number))
			throw new HL7Exception(
			"Can't get repetition "
			+ rep
			+ " from field "
			+ number
			+ " - only "
			+ this.getMaxCardinality(number)
			+ " reps allowed.",
			HL7Exception.APPLICATION_INTERNAL_ERROR);*/
			
			//add a rep if necessary ... 
			if (rep == arr.Length)
			{
				Type[] newArr = new Type[arr.Length + 1];
				Array.Copy(arr, 0, newArr, 0, arr.Length);
				newArr[rep] = createNewType(number);
				arr = newArr;
				
				//replace old field array with new one - note: "fields" is #d from 0
				this.fields.RemoveAt(number - 1);
				this.fields.Insert(number - 1, arr);
			}
			
			return arr[rep];
		}
		
		/// <summary> Creates a new instance of the Type at the given field number in this segment.  </summary>
		private Type createNewType(int field)
		{
			int number = field - 1;
			System.Type c = (System.Type) this.types[number];
			
			Type newType = null;
			try
			{
				System.Object[] args = getArgs(number);
				System.Type[] argClasses = new System.Type[args.Length];
				for (int i = 0; i < args.Length; i++)
				{
					if (args[i] is Message)
					{
						argClasses[i] = typeof(Message);
					}
					else
					{
						argClasses[i] = args[i].GetType();
					}
				}
				newType = (Type) c.GetConstructor(argClasses).Invoke(args);
			}
			catch (System.UnauthorizedAccessException iae)
			{
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Class.getName' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				throw new HL7Exception("Can't access class " + c.FullName + " (" + iae.GetType().FullName + "): " + iae.Message, HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			catch (System.Reflection.TargetInvocationException ite)
			{
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Class.getName' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				throw new HL7Exception("Can't instantiate class " + c.FullName + " (" + ite.GetType().FullName + "): " + ite.Message, HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			catch (System.MethodAccessException nme)
			{
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Class.getName' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				throw new HL7Exception("Can't instantiate class " + c.FullName + " (" + nme.GetType().FullName + "): " + nme.Message, HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
				//UPGRADE_NOTE: Exception 'java.lang.InstantiationException' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
			catch (System.Exception ie)
			{
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Class.getName' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				throw new HL7Exception("Can't instantiate class " + c.FullName + " (" + ie.GetType().FullName + "): " + ie.Message, HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			return newType;
		}
		
		//defaults to {this.getMessage}
		private System.Object[] getArgs(int fieldNum)
		{
			System.Object[] result = null;
			
			System.Object o = this.args[fieldNum];
			if (o != null && o is System.Object[])
			{
				result = (System.Object[]) o;
			}
			else
			{
				result = new System.Object[]{Message};
			}
			
			return result;
		}
		
		/// <summary> Returns true if the given field is required in this segment - fields are 
		/// numbered from 1. 
		/// </summary>
		/// <throws>  HL7Exception if field index is out of range.   </throws>
		public virtual bool isRequired(int number)
		{
			if (number < 1 || number > required.Count)
			{
				throw new HL7Exception("Can't retrieve optionality of field " + number + " from segment " + this.GetType().FullName + " - there are only " + fields.Count + " fields.", HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			
			bool ret = false;
			try
			{
				ret = ((System.Boolean) required[number - 1]);
			}
			catch (System.Exception e)
			{
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				throw new HL7Exception("Can't retrieve optionality of field " + number + ": " + e.Message, HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			
			return ret;
		}
		
		/// <summary> Returns the maximum length of the field at the given index, in characters -   
		/// fields are numbered from 1.  
		/// </summary>
		/// <throws>  HL7Exception if field index is out of range.   </throws>
		public virtual int getLength(int number)
		{
			if (number < 1 || number > length.Count)
			{
				throw new HL7Exception("Can't retrieve max length of field " + number + " from segment " + this.GetType().FullName + " - there are only " + fields.Count + " fields.", HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			
			int ret = 0;
			try
			{
				ret = ((System.Int32) length[number - 1]); //fields #d from 1 to user 
			}
			catch (System.Exception e)
			{
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				throw new HL7Exception("Can't retrieve max length of field " + number + ": " + e.Message, HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			
			return ret;
		}
		
		/// <summary> Returns the number of repetitions of this field that are allowed.  </summary>
		/// <throws>  HL7Exception if field index is out of range. </throws>
		public virtual int getMaxCardinality(int number)
		{
			if (number < 1 || number > length.Count)
			{
				throw new HL7Exception("Can't retrieve cardinality of field " + number + " from segment " + this.GetType().FullName + " - there are only " + fields.Count + " fields.", HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			
			int reps = 0;
			try
			{
				reps = ((System.Int32) maxReps[number - 1]); //fields #d from 1 to user
			}
			catch (System.Exception e)
			{
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				throw new HL7Exception("Can't retrieve max repetitions of field " + number + ": " + e.Message, HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			
			return reps;
		}
		
		/// <summary> Adds a field to the segment.  The field is initially empty (zero repetitions).   
		/// The field number is sequential depending on previous add() calls.  Implementing 
		/// classes should use the add() method in their constructor in order to define fields 
		/// in their segment.  
		/// </summary>
		/// <param name="c">the class of the data for this field - this should inherit from Type
		/// </param>
		/// <param name="required">whether a value for this field is required in order for the segment 
		/// to be valid
		/// </param>
		/// <param name="maxReps">the maximum number of repetitions - 0 implies that there is no limit
		/// </param>
		/// <param name="length">the maximum length of each repetition of the field (in characters) 
		/// </param>
		/// <param name="constructorArgs">an array of objects that will be used as constructor arguments 
		/// if new instances of this class are created (use null for zero-arg constructor)
		/// </param>
		/// <throws>  HL7Exception if the given class does not inherit from Type or if it can  </throws>
		/// <summary>    not be instantiated.
		/// </summary>
		protected internal virtual void  add(System.Type c, bool required, int maxReps, int length, System.Object[] constructorArgs)
		{
			if (!typeof(Type).IsAssignableFrom(c))
			{
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Class.getName' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				throw new HL7Exception("Class " + c.FullName + " does not inherit from " + "ca.on.uhn.datatype.Type", HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			
			Type[] arr = new Type[0];
			this.types.Add(c);
			this.fields.Add(arr);
			this.required.Add(required);
			this.length.Add((System.Int32) length);
			this.args.Add(constructorArgs);
			this.maxReps.Add((System.Int32) maxReps);
			this.fieldDescriptions.Add(null);
		}

		/// <summary> Adds a field to the segment.  The field is initially empty (zero repetitions).   
		/// The field number is sequential depending on previous add() calls.  Implementing 
		/// classes should use the add() method in their constructor in order to define fields 
		/// in their segment.  
		/// </summary>
		/// <param name="c">the class of the data for this field - this should inherit from Type
		/// </param>
		/// <param name="required">whether a value for this field is required in order for the segment 
		/// to be valid
		/// </param>
		/// <param name="maxReps">the maximum number of repetitions - 0 implies that there is no limit
		/// </param>
		/// <param name="length">the maximum length of each repetition of the field (in characters) 
		/// </param>
		/// <param name="constructorArgs">an array of objects that will be used as constructor arguments 
		/// if new instances of this class are created (use null for zero-arg constructor)
		/// </param>
		/// <throws>  HL7Exception if the given class does not inherit from Type or if it can  </throws>
		/// <summary>    not be instantiated.
		/// </summary>
		protected internal virtual void  add(System.Type c, bool required, int maxReps, int length, System.Object[] constructorArgs, string fieldDescription)
		{
			if (!typeof(Type).IsAssignableFrom(c))
			{
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Class.getName' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				throw new HL7Exception("Class " + c.FullName + " does not inherit from " + "ca.on.uhn.datatype.Type", HL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			
			Type[] arr = new Type[0];
			this.types.Add(c);
			this.fields.Add(arr);
			this.required.Add(required);
			this.length.Add((System.Int32) length);
			this.args.Add(constructorArgs);
			this.maxReps.Add((System.Int32) maxReps);
			this.fieldDescriptions.Add(fieldDescription);

		}
		
		/// <summary> Called from getField(...) methods.  If a field has been requested that 
		/// doesn't exist (eg getField(15) when only 10 fields in segment) adds Varies
		/// fields to the end of the segment up to the required number.  
		/// </summary>
		private void  ensureEnoughFields(int fieldRequested)
		{
			int fieldsToAdd = fieldRequested - this.numFields();
			if (fieldsToAdd < 0)
				fieldsToAdd = 0;
			
			try
			{
				for (int i = 0; i < fieldsToAdd; i++)
				{
					this.add(typeof(Varies), false, 0, 65536, null); //using 65536 following example of OBX-5
				}
			}
			catch (HL7Exception e)
			{
				log.error("Can't create additional generic fields to handle request for field " + fieldRequested, e);
			}
		}
		
		[STAThread]
		public static void  Main(System.String[] args)
		{
			/*
			try {
			Message mess = new TestMessage();
			MSH msh = new MSH(mess);
			
			//get empty array 
			Type[] ts = msh.getField(1);
			System.out.println("Got Type array of length " + ts.length);
			
			//get first field
			Type t = msh.getField(1, 0);
			System.out.println("Got a Type of class " + t.getClass().getName());
			
			//get array now
			Type[] ts2 = msh.getField(1);
			System.out.println("Got Type array of length " + ts2.length);
			
			//set a value
			ST str = (ST)t;
			str.setValue("hello");
			
			//get first field
			Type t2 = msh.getField(1, 0);
			System.out.println("Got a Type of class " + t.getClass().getName());
			System.out.println("It's value is " + ((ST)t2).getValue());
			
			msh.getFieldSeparator().setValue("thing");
			System.out.println("Field Sep: " + msh.getFieldSeparator().getValue());
			
			msh.getConformanceStatementID(0).setValue("ID 1");
			msh.getConformanceStatementID(1).setValue("ID 2");
			System.out.println("Conf ID #2: " + msh.getConformanceStatementID(1).getValue());
			
			ID[] cid = msh.getConformanceStatementID();
			System.out.println("CID: " + cid);
			for (int i = 0; i < cid.length; i++) {
			System.out.println("Conf ID element: " + i + ": " + cid[i].getValue());
			}
			msh.getConformanceStatementID(3).setValue("this should fail");
			
			
			} catch (HL7Exception e) {
			e.printStackTrace();
			}*/
		}
		
		/// <summary> Returns the number of fields defined by this segment (repeating 
		/// fields are not counted multiple times).  
		/// </summary>
		public virtual int numFields()
		{
			return this.fields.Count;
		}
		
		/// <summary> Returns the class name (excluding package). </summary>
		/// <seealso cref="Structure.getName()">
		/// </seealso>
		public virtual System.String getStructureName()
		{
			System.String fullName = this.GetType().FullName;
			return fullName.Substring(fullName.LastIndexOf('.') + 1, (fullName.Length) - (fullName.LastIndexOf('.') + 1));
		}
		
		/// <summary> Sets the segment name.  This would normally be called by a Parser. </summary>
		/*public void setName(String name) {
		this.name = name;
		}*/
		static AbstractSegment()
		{
			log = HapiLogFactory.getHapiLog(typeof(AbstractSegment));
		}
	}
}