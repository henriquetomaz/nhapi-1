using System;
using NHapi.Base.model;
namespace NHapi.Base.model.v23.datatype
{
///<summary>
///<p>Represents the HL7 TX (text data) datatype.  A TX contains a single String value.
///<summary>
[Serializable]
public class TX : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized TX.
	///<param name="message">The Message to which this Type belongs</param>
	///<summary>
	public TX(Message message) : base(message){
	}

	///<summary>
	///  @return "2.3"
	///</summary>
	public String getVersion() {
	    return "2.3";
}
}
}