using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RGV_O15_ENCODING Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RXE (Pharmacy/Treatment Encoded Order) <b></b><br>
 * 1: RGV_O15_TIMING_ENCODED (a Group object) <b>repeating</b><br>
 * 2: RXR (Pharmacy/Treatment Route) <b>repeating</b><br>
 * 3: RXC (Pharmacy/Treatment Component Order) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class RGV_O15_ENCODING : AbstractGroup {

	/** 
	 * Creates a new RGV_O15_ENCODING Group.
	 */
	public RGV_O15_ENCODING(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("RXE", "2.5"), true, false);
	      this.add(factory.getGroupClass("RGV_O15_TIMING_ENCODED", "2.5"), true, true);
	      this.add(factory.getSegmentClass("RXR", "2.5"), true, true);
	      this.add(factory.getSegmentClass("RXC", "2.5"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RGV_O15_ENCODING - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RXE (Pharmacy/Treatment Encoded Order) - creates it if necessary
	 */
	public RXE RXE { 
get{
	   RXE ret = null;
	   try {
	      ret = (RXE)this.get_Renamed("RXE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RGV_O15_TIMING_ENCODED (a Group object) - creates it if necessary
	 */
	public RGV_O15_TIMING_ENCODED  getTIMING_ENCODED() { 
	   RGV_O15_TIMING_ENCODED ret = null;
	   try {
	      ret = (RGV_O15_TIMING_ENCODED)this.get_Renamed("TIMING_ENCODED");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RGV_O15_TIMING_ENCODED
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RGV_O15_TIMING_ENCODED getTIMING_ENCODED(int rep) { 
	   return (RGV_O15_TIMING_ENCODED)this.get_Renamed("TIMING_ENCODED", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RGV_O15_TIMING_ENCODED 
	 */ 
	public int TIMING_ENCODEDReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("TIMING_ENCODED").Length; 
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

	/**
	 * Returns  first repetition of RXR (Pharmacy/Treatment Route) - creates it if necessary
	 */
	public RXR  getRXR() { 
	   RXR ret = null;
	   try {
	      ret = (RXR)this.get_Renamed("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RXR
	 * (Pharmacy/Treatment Route) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RXR getRXR(int rep) { 
	   return (RXR)this.get_Renamed("RXR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXR 
	 */ 
	public int RXRReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("RXR").Length; 
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

	/**
	 * Returns  first repetition of RXC (Pharmacy/Treatment Component Order) - creates it if necessary
	 */
	public RXC  getRXC() { 
	   RXC ret = null;
	   try {
	      ret = (RXC)this.get_Renamed("RXC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RXC
	 * (Pharmacy/Treatment Component Order) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RXC getRXC(int rep) { 
	   return (RXC)this.get_Renamed("RXC", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXC 
	 */ 
	public int RXCReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("RXC").Length; 
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
