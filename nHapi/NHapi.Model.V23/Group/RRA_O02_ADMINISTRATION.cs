using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v23.segment;

using NHapi.Base.model;
/**
 * <p>Represents the RRA_O02_ADMINISTRATION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RXA (Pharmacy administration segment) <b></b><br>
 * 1: RXR (Pharmacy route segment) <b></b><br>
 */
namespace NHapi.Base.model.v23.group
{
[Serializable]
public class RRA_O02_ADMINISTRATION : AbstractGroup {

	/** 
	 * Creates a new RRA_O02_ADMINISTRATION Group.
	 */
	public RRA_O02_ADMINISTRATION(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("RXA", "2.3"), true, false);
	      this.add(factory.getSegmentClass("RXR", "2.3"), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRA_O02_ADMINISTRATION - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RXA (Pharmacy administration segment) - creates it if necessary
	 */
	public RXA RXA { 
get{
	   RXA ret = null;
	   try {
	      ret = (RXA)this.get_Renamed("RXA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RXR (Pharmacy route segment) - creates it if necessary
	 */
	public RXR RXR { 
get{
	   RXR ret = null;
	   try {
	      ret = (RXR)this.get_Renamed("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}