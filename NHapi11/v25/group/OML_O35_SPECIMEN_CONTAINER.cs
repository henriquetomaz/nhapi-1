using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OML_O35_SPECIMEN_CONTAINER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: SAC (Specimen Container detail) <b></b><br>
 * 1: OML_O35_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class OML_O35_SPECIMEN_CONTAINER : AbstractGroup {

	/** 
	 * Creates a new OML_O35_SPECIMEN_CONTAINER Group.
	 */
	public OML_O35_SPECIMEN_CONTAINER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(SAC), true, false);
	      this.add(typeof(OML_O35_ORDER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OML_O35_SPECIMEN_CONTAINER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns SAC (Specimen Container detail) - creates it if necessary
	 */
	public SAC SAC { 
get{
	   SAC ret = null;
	   try {
	      ret = (SAC)this.get_Renamed("SAC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of OML_O35_ORDER (a Group object) - creates it if necessary
	 */
	public OML_O35_ORDER getORDER() {
	   OML_O35_ORDER ret = null;
	   try {
	      ret = (OML_O35_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OML_O35_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OML_O35_ORDER getORDER(int rep) { 
	   return (OML_O35_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OML_O35_ORDER 
	 */ 
	public int ORDERReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("ORDER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
