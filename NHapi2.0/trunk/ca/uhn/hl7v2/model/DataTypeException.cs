/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "DataTypeException.java".  Description: 
/// "Represents a problem with the validity of a data type, such as an attempt 
/// to set the value of a primitive type to something invalid for that type" 
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
namespace ca.uhn.hl7v2.model
{
	
	/// <summary> Represents a problem with the validity of a data type, such as an attempt 
	/// to set the value of a primitive type to something invalid for that type. 
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	[Serializable]
	public class DataTypeException:HL7Exception
	{
		
		
		/// <param name="message">
		/// </param>
		/// <param name="errorCondition">
		/// </param>
		/// <param name="cause">
		/// </param>
		//UPGRADE_NOTE: Exception 'java.lang.Throwable' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
		public DataTypeException(System.String message, int errorCondition, System.Exception cause):base(message, errorCondition, cause)
		{
		}
		
		/// <param name="message">
		/// </param>
		/// <param name="errorCondition">
		/// </param>
		public DataTypeException(System.String message, int errorCondition):base(message, errorCondition)
		{
		}
		
		/// <param name="message">
		/// </param>
		/// <param name="cause">
		/// </param>
		//UPGRADE_NOTE: Exception 'java.lang.Throwable' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
		public DataTypeException(System.String message, System.Exception cause):base(message, cause)
		{
		}
		
		/// <param name="message">
		/// </param>
		/// <param name="cause">
		/// </param>
		//UPGRADE_NOTE: Exception 'java.lang.Throwable' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
        //UPGARDE_NOTE: base exception does not offer just an Exception constructor
        //public DataTypeException(System.Exception cause):base(cause)
        //{
        //}
		
		
		/// <param name="message">
		/// </param>
		public DataTypeException(System.String message):base(message)
		{
		}
	}
}