using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the REF_I12_PROVIDER_CONTACT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PRD (Provider Data) <b></b><br>
 * 1: CTD (Contact Data) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class REF_I12_PROVIDER_CONTACT : AbstractGroup {

	/** 
	 * Creates a new REF_I12_PROVIDER_CONTACT Group.
	 */
	public REF_I12_PROVIDER_CONTACT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PRD", "2.5"), true, false);
	      this.add(factory.getSegmentClass("CTD", "2.5"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating REF_I12_PROVIDER_CONTACT - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PRD (Provider Data) - creates it if necessary
	 */
	public PRD PRD { 
get{
	   PRD ret = null;
	   try {
	      ret = (PRD)this.get_Renamed("PRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of CTD (Contact Data) - creates it if necessary
	 */
	public CTD  getCTD() { 
	   CTD ret = null;
	   try {
	      ret = (CTD)this.get_Renamed("CTD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of CTD
	 * (Contact Data) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public CTD getCTD(int rep) { 
	   return (CTD)this.get_Renamed("CTD", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CTD 
	 */ 
	public int CTDReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("CTD").Length; 
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
