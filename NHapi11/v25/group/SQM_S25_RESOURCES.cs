using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the SQM_S25_RESOURCES Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RGS (Resource Group) <b></b><br>
 * 1: SQM_S25_SERVICE (a Group object) <b></b><br>
 * 2: SQM_S25_GENERAL_RESOURCE (a Group object) <b></b><br>
 * 3: SQM_S25_PERSONNEL_RESOURCE (a Group object) <b></b><br>
 * 4: SQM_S25_LOCATION_RESOURCE (a Group object) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class SQM_S25_RESOURCES : AbstractGroup {

	/** 
	 * Creates a new SQM_S25_RESOURCES Group.
	 */
	public SQM_S25_RESOURCES(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RGS), true, false);
	      this.add(typeof(SQM_S25_SERVICE), true, false);
	      this.add(typeof(SQM_S25_GENERAL_RESOURCE), true, false);
	      this.add(typeof(SQM_S25_PERSONNEL_RESOURCE), true, false);
	      this.add(typeof(SQM_S25_LOCATION_RESOURCE), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SQM_S25_RESOURCES - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RGS (Resource Group) - creates it if necessary
	 */
	public RGS RGS { 
get{
	   RGS ret = null;
	   try {
	      ret = (RGS)this.get_Renamed("RGS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns SQM_S25_SERVICE (a Group object) - creates it if necessary
	 */
	public SQM_S25_SERVICE SERVICE { 
get{
	   SQM_S25_SERVICE ret = null;
	   try {
	      ret = (SQM_S25_SERVICE)this.get_Renamed("SERVICE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns SQM_S25_GENERAL_RESOURCE (a Group object) - creates it if necessary
	 */
	public SQM_S25_GENERAL_RESOURCE GENERAL_RESOURCE { 
get{
	   SQM_S25_GENERAL_RESOURCE ret = null;
	   try {
	      ret = (SQM_S25_GENERAL_RESOURCE)this.get_Renamed("GENERAL_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns SQM_S25_PERSONNEL_RESOURCE (a Group object) - creates it if necessary
	 */
	public SQM_S25_PERSONNEL_RESOURCE PERSONNEL_RESOURCE { 
get{
	   SQM_S25_PERSONNEL_RESOURCE ret = null;
	   try {
	      ret = (SQM_S25_PERSONNEL_RESOURCE)this.get_Renamed("PERSONNEL_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns SQM_S25_LOCATION_RESOURCE (a Group object) - creates it if necessary
	 */
	public SQM_S25_LOCATION_RESOURCE LOCATION_RESOURCE { 
get{
	   SQM_S25_LOCATION_RESOURCE ret = null;
	   try {
	      ret = (SQM_S25_LOCATION_RESOURCE)this.get_Renamed("LOCATION_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
