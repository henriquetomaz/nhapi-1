/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "DT.java".  Description:
/// "Note: The class description below has been excerpted from the Hl7 2.3.0 documentation"
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2005.  All Rights Reserved.
/// 
/// Contributor(s): ______________________________________.
/// 
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
using AbstractPrimitive = ca.uhn.hl7v2.model.AbstractPrimitive;
using DataTypeException = ca.uhn.hl7v2.model.DataTypeException;
using Message = ca.uhn.hl7v2.model.Message;
namespace ca.uhn.hl7v2.model.primitive
{
	
	/// <summary> Represents an HL7 DT (date) datatype.   
	/// 
	/// </summary>
	/// <author>  <a href="mailto:neal.acharya@uhn.on.ca">Neal Acharya</a>
	/// </author>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.3 $ updated on $Date: 2006/06/20 19:39:39 $ by $Author: whitedog12 $
	/// </version>
	public abstract class DT:AbstractPrimitive
	{
		private CommonDT Detail
		{
			get
			{
				if (myDetail == null)
				{
					myDetail = new CommonDT(Value);
				}
				return myDetail;
			}
			
		}
		//UPGRADE_NOTE: Respective javadoc comments were merged.  It should be changed in order to comply with .NET documentation conventions. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1199'"
		/// <seealso cref="AbstractPrimitive.getValue">
		/// </seealso>
		/// <seealso cref="AbstractPrimitive.setValue(java.lang.String)">
		/// </seealso>
		/// <throws>  DataTypeException if the value is incorrectly formatted and either validation is  </throws>
		/// <summary>      enabled for this primitive or detail setters / getters have been called, forcing further
		/// parsing.   
		/// </summary>
		override public System.String Value
		{
			get
			{
				System.String result = base.Value;
				
				if (myDetail != null)
				{
					result = myDetail.Value;
				}
				
				return result;
			}
			
			set
			{
				base.Value = value;
				
				if (myDetail != null)
				{
					myDetail.Value = value;
				}
			}
			
		}
		/// <seealso cref="CommonDT.setYearPrecision(int)">
		/// </seealso>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		virtual public int YearPrecision
		{
			set
			{
				Detail.YearPrecision = value;
			}
			
		}
		/// <summary> Returns the year as an integer.</summary>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		virtual public int Year
		{
			get
			{
				return Detail.Year;
			}
			
		}
		/// <summary> Returns the month as an integer.</summary>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		virtual public int Month
		{
			get
			{
				return Detail.Month;
			}
			
		}
		/// <summary> Returns the day as an integer.</summary>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		virtual public int Day
		{
			get
			{
				return Detail.Day;
			}
			
		}
		
		private CommonDT myDetail;
		
		/// <param name="theMessage">message to which this Type belongs
		/// </param>
		public DT(Message theMessage):base(theMessage)
		{
		}


		public DT(Message theMessage, string description):base(theMessage, description)
		{
		}
		
		/// <seealso cref="CommonDT.setYearMonthPrecision(int, int)">
		/// </seealso>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		public virtual void  setYearMonthPrecision(int yr, int mnth)
		{
			Detail.setYearMonthPrecision(yr, mnth);
		}
		
		/// <seealso cref="CommonDT.setYearMonthDayPrecision(int, int, int)">
		/// </seealso>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		public virtual void  setYearMonthDayPrecision(int yr, int mnth, int dy)
		{
			Detail.setYearMonthDayPrecision(yr, mnth, dy);
		}

		/// <summary>
		/// Used for setting the format of a date (Year, Month, Day).
		/// </summary>
		protected virtual string DateFormat
		{
			get
			{
				return "yyyyMMdd";
			}
		}

		public virtual DateTime GetAsDate()
		{	
			try
			{
				string[] dateFormats = new string[]{DateFormat};
				DateTime val =DateTime.MinValue;
				if(Value!=null && Value.Length>0)
					val = DateTime.ParseExact(Value,dateFormats,null, System.Globalization.DateTimeStyles.None);
				return val;
			}
			catch(Exception)
			{
				throw new HL7Exception("Could not get field as dateTime");
			}
		}


		public virtual void Set(DateTime value)
		{
			try
			{
				Value = value.ToString(DateFormat);
			}
			catch(FormatException)
			{
				throw new HL7Exception("Could not format the date " + value + " to a long date.  Format must be " + DateFormat);
			}
		}


	}
}