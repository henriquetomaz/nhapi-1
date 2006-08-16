using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v23.segment;

using NHapi.Base.model;
/**
 * <p>Represents the MFN_M01_MF Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (Master file entry segment) <b></b><br>
 * 1: GenericSegment (any order segment) <b>optional </b><br>
 */
namespace NHapi.Base.model.v23.group
{
[Serializable]
public class MFN_M01_MF : AbstractGroup {

	/** 
	 * Creates a new MFN_M01_MF Group.
	 */
	public MFN_M01_MF(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("MFE", "2.3"), true, false);
	      this.add(factory.getSegmentClass("GenericSegment", "2.3"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M01_MF - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MFE (Master file entry segment) - creates it if necessary
	 */
	public MFE MFE { 
get{
	   MFE ret = null;
	   try {
	      ret = (MFE)this.get_Renamed("MFE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns GenericSegment (any order segment) - creates it if necessary
	 */
	public GenericSegment GenericSegment { 
get{
	   GenericSegment ret = null;
	   try {
	      ret = (GenericSegment)this.get_Renamed("GenericSegment");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}