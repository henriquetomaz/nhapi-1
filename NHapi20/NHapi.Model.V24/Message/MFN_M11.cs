using System;
using NHapi.Base.Log;
using NHapi.Model.V24.Group;
using NHapi.Model.V24.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V24.Message

{
///<summary>
/// Represents a MFN_M11 message structure (see chapter 8). This structure contains the 
/// following elements:
/// * 0: MSH (Message Header) 
/// * 1: MFI (Master File Identification) 
/// * 2: MFN_M11_MF_TEST_CALCULATED (a Group object) repeating
///</summary>
[Serializable]
public class MFN_M11 : AbstractMessage  {

	///<summary> 
	/// Creates a new MFN_M11 Group with custom IModelClassFactory.
	///</summary>
	public MFN_M11(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new MFN_M11 Group with DefaultModelClassFactory. 
	///</summary> 
	public MFN_M11() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for MFN_M11.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MFI), true, false);
	      this.add(typeof(MFN_M11_MF_TEST_CALCULATED), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M11 - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns MSH (Message Header) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns MFI (Master File Identification) - creates it if necessary
	///</summary>
	public MFI MFI { 
get{
	   MFI ret = null;
	   try {
	      ret = (MFI)this.GetStructure("MFI");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of MFN_M11_MF_TEST_CALCULATED (a Group object) - creates it if necessary
	///</summary>
	public MFN_M11_MF_TEST_CALCULATED getMF_TEST_CALCULATED() {
	   MFN_M11_MF_TEST_CALCULATED ret = null;
	   try {
	      ret = (MFN_M11_MF_TEST_CALCULATED)this.GetStructure("MF_TEST_CALCULATED");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of MFN_M11_MF_TEST_CALCULATED
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public MFN_M11_MF_TEST_CALCULATED getMF_TEST_CALCULATED(int rep) { 
	   return (MFN_M11_MF_TEST_CALCULATED)this.GetStructure("MF_TEST_CALCULATED", rep);
	}

	/** 
	 * Returns the number of existing repetitions of MFN_M11_MF_TEST_CALCULATED 
	 */ 
	public int MF_TEST_CALCULATEDReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("MF_TEST_CALCULATED").Length; 
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