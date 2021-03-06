using System;
using ca.uhn.hl7v2.model;
namespace ca.uhn.hl7v2.model.v25.datatype
{
///<summary>
///<p>Represents the HL7 TX (Text Data) datatype.  A TX contains a single String value.
///<summary>
[Serializable]
public class TX : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized TX.
	///<param name="message">The Message to which this Type belongs</param>
	///<summary>
	public TX(Message message) : base(message){
	}

	public TX(Message message, string description) : base(message,description){
	}

	///<summary>
	///  @return "2.5"
	///</summary>
	public string getVersion() {
	    return "2.5";
}
}
}