using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OMD_O03_ORDER_DIET Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: OMD_O03_TIMING_DIET (a Group object) <b></b><br>
 * 2: OMD_O03_DIET (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class OMD_O03_ORDER_DIET : AbstractGroup {

	/** 
	 * Creates a new OMD_O03_ORDER_DIET Group.
	 */
	public OMD_O03_ORDER_DIET(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.5"), true, false);
	      this.add(factory.getGroupClass("OMD_O03_TIMING_DIET", "2.5"), true, false);
	      this.add(factory.getGroupClass("OMD_O03_DIET", "2.5"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OMD_O03_ORDER_DIET - this is probably a bug in the source code generator.", e);
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
	 * Returns OMD_O03_TIMING_DIET (a Group object) - creates it if necessary
	 */
	public OMD_O03_TIMING_DIET TIMING_DIET { 
get{
	   OMD_O03_TIMING_DIET ret = null;
	   try {
	      ret = (OMD_O03_TIMING_DIET)this.get_Renamed("TIMING_DIET");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns OMD_O03_DIET (a Group object) - creates it if necessary
	 */
	public OMD_O03_DIET DIET { 
get{
	   OMD_O03_DIET ret = null;
	   try {
	      ret = (OMD_O03_DIET)this.get_Renamed("DIET");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
