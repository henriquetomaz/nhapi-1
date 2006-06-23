using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OMN_O01_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common order segment) <b></b><br>
 * 1: OMN_O01_ORDER_DETAIL (a Group object) <b>optional </b><br>
 * 2: BLG (Billing Segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class OMN_O01_ORDER : AbstractGroup {

	/** 
	 * Creates a new OMN_O01_ORDER Group.
	 */
	public OMN_O01_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.3"), true, false);
	      this.add(factory.getGroupClass("OMN_O01_ORDER_DETAIL", "2.3"), false, false);
	      this.add(factory.getSegmentClass("BLG", "2.3"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OMN_O01_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORC (Common order segment) - creates it if necessary
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
	 * Returns OMN_O01_ORDER_DETAIL (a Group object) - creates it if necessary
	 */
	public OMN_O01_ORDER_DETAIL ORDER_DETAIL { 
get{
	   OMN_O01_ORDER_DETAIL ret = null;
	   try {
	      ret = (OMN_O01_ORDER_DETAIL)this.get_Renamed("ORDER_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns BLG (Billing Segment) - creates it if necessary
	 */
	public BLG BLG { 
get{
	   BLG ret = null;
	   try {
	      ret = (BLG)this.get_Renamed("BLG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
