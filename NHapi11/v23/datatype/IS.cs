using System;

namespace ca.uhn.hl7v2.model.v23.datatype
{
	/// <summary>
	/// Summary description for IS.
	/// </summary>
	public class IS:ca.uhn.hl7v2.model.primitive.IS
	{
		/// <returns> "2.3"
		/// </returns>
		virtual public System.String Version
		{
			get
			{
				return "2.3";
			}
			
		}
		
		/// <param name="theMessage">message to which this Type belongs
		/// </param>
		/// <param name="theTable">HL7 table from which values are to be drawn 
		/// </param>
		public IS(Message theMessage, int theTable):base(theMessage, theTable)
		{
		}
		
		public IS(Message theMessage, System.Int32 theTable, string description):base(theMessage, theTable, description)
		{
		}
	}
}
