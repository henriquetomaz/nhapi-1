using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the SQM_S25_SERVICE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: AIS (Appointment Information) <b></b><br>
 * 1: APR (Appointment Preferences) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class SQM_S25_SERVICE : AbstractGroup {

	/** 
	 * Creates a new SQM_S25_SERVICE Group.
	 */
	public SQM_S25_SERVICE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(AIS), true, false);
	      this.add(typeof(APR), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SQM_S25_SERVICE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns AIS (Appointment Information) - creates it if necessary
	 */
	public AIS AIS { 
get{
	   AIS ret = null;
	   try {
	      ret = (AIS)this.get_Renamed("AIS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns APR (Appointment Preferences) - creates it if necessary
	 */
	public APR APR { 
get{
	   APR ret = null;
	   try {
	      ret = (APR)this.get_Renamed("APR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
