using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORU_R01_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORU_R01_PATIENT (a Group object) <b>optional </b><br>
 * 1: ORU_R01_ORDER_OBSERVATION (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class ORU_R01_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new ORU_R01_RESPONSE Group.
	 */
	public ORU_R01_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getGroupClass("ORU_R01_PATIENT", "2.3"), false, false);
	      this.add(factory.getGroupClass("ORU_R01_ORDER_OBSERVATION", "2.3"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORU_R01_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORU_R01_PATIENT (a Group object) - creates it if necessary
	 */
	public ORU_R01_PATIENT PATIENT { 
get{
	   ORU_R01_PATIENT ret = null;
	   try {
	      ret = (ORU_R01_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ORU_R01_ORDER_OBSERVATION (a Group object) - creates it if necessary
	 */
	public ORU_R01_ORDER_OBSERVATION  getORDER_OBSERVATION() { 
	   ORU_R01_ORDER_OBSERVATION ret = null;
	   try {
	      ret = (ORU_R01_ORDER_OBSERVATION)this.get_Renamed("ORDER_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ORU_R01_ORDER_OBSERVATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ORU_R01_ORDER_OBSERVATION getORDER_OBSERVATION(int rep) { 
	   return (ORU_R01_ORDER_OBSERVATION)this.get_Renamed("ORDER_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORU_R01_ORDER_OBSERVATION 
	 */ 
	public int ORDER_OBSERVATIONReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("ORDER_OBSERVATION").Length; 
	    }
 catch (HL7Exception e) 
{ 
	        String message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
