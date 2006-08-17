using System;
using NHapi.Base.Model;
using NHapi.Base;
using NHapi.Base.Model.Primitive;
namespace NHapi.Model.V22.Datatype
{
///<summary>
///<p>Represents the HL7 SI (SEQUENCE ID) datatype.  A SI contains a single String value.
///<summary>
[Serializable]
public class SI : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized SI.
	///<param name="message">The Message to which this Type belongs</param>
	///<summary>
	public SI(IMessage message) : base(message){
	}

	public SI(IMessage message, string description) : base(message,description){
	}

	///<summary>
	///  @return "2.2"
	///</summary>
	public string getVersion() {
	    return "2.2";
}
}
}