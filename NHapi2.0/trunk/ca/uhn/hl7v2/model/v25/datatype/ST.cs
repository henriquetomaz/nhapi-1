using System;
using ca.uhn.hl7v2.model;
namespace ca.uhn.hl7v2.model.v25.datatype
{
///<summary>
///<p>Represents the HL7 ST (String Data) datatype.  A ST contains a single String value.
///<summary>
[Serializable]
public class ST : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized ST.
	///<param name="message">The Message to which this Type belongs</param>
	///<summary>
	public ST(Message message) : base(message){
	}

	///<summary>
	///  @return "2.5"
	///</summary>
	public String getVersion() {
	    return "2.5";
}
}
}