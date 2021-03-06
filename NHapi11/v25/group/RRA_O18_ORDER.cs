using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RRA_O18_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: RRA_O18_TIMING (a Group object) <b></b><br>
 * 2: RRA_O18_ADMINISTRATION (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class RRA_O18_ORDER : AbstractGroup {

	/** 
	 * Creates a new RRA_O18_ORDER Group.
	 */
	public RRA_O18_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(RRA_O18_TIMING), true, false);
	      this.add(typeof(RRA_O18_ADMINISTRATION), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRA_O18_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORC (Common Order) - creates it if necessary
	 */
	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.get_Renamed("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RRA_O18_TIMING (a Group object) - creates it if necessary
	 */
	public RRA_O18_TIMING TIMING { 
get{
	   RRA_O18_TIMING ret = null;
	   try {
	      ret = (RRA_O18_TIMING)this.get_Renamed("TIMING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RRA_O18_ADMINISTRATION (a Group object) - creates it if necessary
	 */
	public RRA_O18_ADMINISTRATION ADMINISTRATION { 
get{
	   RRA_O18_ADMINISTRATION ret = null;
	   try {
	      ret = (RRA_O18_ADMINISTRATION)this.get_Renamed("ADMINISTRATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
