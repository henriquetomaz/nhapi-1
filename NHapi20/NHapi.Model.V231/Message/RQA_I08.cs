using System;
using NHapi.Base.Log;
using NHapi.Model.V231.Group;
using NHapi.Model.V231.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V231.Message

{
///<summary>
/// Represents a RQA_I08 message structure (see chapter ). This structure contains the 
/// following elements:
/// * 0: MSH (MSH - message header segment) 
/// * 1: RF1 (Referral Infomation) optional 
/// * 2: RQA_I08_AUTHORIZATION (a Group object) optional 
/// * 3: RQA_I08_PROVIDER (a Group object) repeating
/// * 4: PID (PID - patient identification segment) 
/// * 5: NK1 (NK1 - next of kin / associated parties segment-) optional repeating
/// * 6: RQA_I08_GUARANTOR_INSURANCE (a Group object) optional 
/// * 7: ACC (ACC - accident segment) optional 
/// * 8: DG1 (DG1 - diagnosis segment) optional repeating
/// * 9: DRG (DRG - diagnosis related group segment) optional repeating
/// * 10: AL1 (AL1 - patient allergy information segment) optional repeating
/// * 11: RQA_I08_PROCEDURE (a Group object) optional repeating
/// * 12: RQA_I08_OBSERVATION (a Group object) optional repeating
/// * 13: RQA_I08_VISIT (a Group object) optional 
/// * 14: NTE (NTE - notes and comments segment) optional repeating
///</summary>
[Serializable]
public class RQA_I08 : AbstractMessage  {

	///<summary> 
	/// Creates a new RQA_I08 Group with custom IModelClassFactory.
	///</summary>
	public RQA_I08(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new RQA_I08 Group with DefaultModelClassFactory. 
	///</summary> 
	public RQA_I08() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for RQA_I08.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(RF1), false, false);
	      this.add(typeof(RQA_I08_AUTHORIZATION), false, false);
	      this.add(typeof(RQA_I08_PROVIDER), true, true);
	      this.add(typeof(PID), true, false);
	      this.add(typeof(NK1), false, true);
	      this.add(typeof(RQA_I08_GUARANTOR_INSURANCE), false, false);
	      this.add(typeof(ACC), false, false);
	      this.add(typeof(DG1), false, true);
	      this.add(typeof(DRG), false, true);
	      this.add(typeof(AL1), false, true);
	      this.add(typeof(RQA_I08_PROCEDURE), false, true);
	      this.add(typeof(RQA_I08_OBSERVATION), false, true);
	      this.add(typeof(RQA_I08_VISIT), false, false);
	      this.add(typeof(NTE), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RQA_I08 - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns MSH (MSH - message header segment) - creates it if necessary
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
	/// Returns RF1 (Referral Infomation) - creates it if necessary
	///</summary>
	public RF1 RF1 { 
get{
	   RF1 ret = null;
	   try {
	      ret = (RF1)this.GetStructure("RF1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RQA_I08_AUTHORIZATION (a Group object) - creates it if necessary
	///</summary>
	public RQA_I08_AUTHORIZATION AUTHORIZATION { 
get{
	   RQA_I08_AUTHORIZATION ret = null;
	   try {
	      ret = (RQA_I08_AUTHORIZATION)this.GetStructure("AUTHORIZATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of RQA_I08_PROVIDER (a Group object) - creates it if necessary
	///</summary>
	public RQA_I08_PROVIDER getPROVIDER() {
	   RQA_I08_PROVIDER ret = null;
	   try {
	      ret = (RQA_I08_PROVIDER)this.GetStructure("PROVIDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RQA_I08_PROVIDER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RQA_I08_PROVIDER getPROVIDER(int rep) { 
	   return (RQA_I08_PROVIDER)this.GetStructure("PROVIDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RQA_I08_PROVIDER 
	 */ 
	public int PROVIDERReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PROVIDER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns PID (PID - patient identification segment) - creates it if necessary
	///</summary>
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.GetStructure("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of NK1 (NK1 - next of kin / associated parties segment-) - creates it if necessary
	///</summary>
	public NK1 getNK1() {
	   NK1 ret = null;
	   try {
	      ret = (NK1)this.GetStructure("NK1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NK1
	/// * (NK1 - next of kin / associated parties segment-) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NK1 getNK1(int rep) { 
	   return (NK1)this.GetStructure("NK1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NK1 
	 */ 
	public int NK1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NK1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns RQA_I08_GUARANTOR_INSURANCE (a Group object) - creates it if necessary
	///</summary>
	public RQA_I08_GUARANTOR_INSURANCE GUARANTOR_INSURANCE { 
get{
	   RQA_I08_GUARANTOR_INSURANCE ret = null;
	   try {
	      ret = (RQA_I08_GUARANTOR_INSURANCE)this.GetStructure("GUARANTOR_INSURANCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns ACC (ACC - accident segment) - creates it if necessary
	///</summary>
	public ACC ACC { 
get{
	   ACC ret = null;
	   try {
	      ret = (ACC)this.GetStructure("ACC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of DG1 (DG1 - diagnosis segment) - creates it if necessary
	///</summary>
	public DG1 getDG1() {
	   DG1 ret = null;
	   try {
	      ret = (DG1)this.GetStructure("DG1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DG1
	/// * (DG1 - diagnosis segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DG1 getDG1(int rep) { 
	   return (DG1)this.GetStructure("DG1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DG1 
	 */ 
	public int DG1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("DG1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of DRG (DRG - diagnosis related group segment) - creates it if necessary
	///</summary>
	public DRG getDRG() {
	   DRG ret = null;
	   try {
	      ret = (DRG)this.GetStructure("DRG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DRG
	/// * (DRG - diagnosis related group segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DRG getDRG(int rep) { 
	   return (DRG)this.GetStructure("DRG", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DRG 
	 */ 
	public int DRGReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("DRG").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of AL1 (AL1 - patient allergy information segment) - creates it if necessary
	///</summary>
	public AL1 getAL1() {
	   AL1 ret = null;
	   try {
	      ret = (AL1)this.GetStructure("AL1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of AL1
	/// * (AL1 - patient allergy information segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public AL1 getAL1(int rep) { 
	   return (AL1)this.GetStructure("AL1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of AL1 
	 */ 
	public int AL1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("AL1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of RQA_I08_PROCEDURE (a Group object) - creates it if necessary
	///</summary>
	public RQA_I08_PROCEDURE getPROCEDURE() {
	   RQA_I08_PROCEDURE ret = null;
	   try {
	      ret = (RQA_I08_PROCEDURE)this.GetStructure("PROCEDURE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RQA_I08_PROCEDURE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RQA_I08_PROCEDURE getPROCEDURE(int rep) { 
	   return (RQA_I08_PROCEDURE)this.GetStructure("PROCEDURE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RQA_I08_PROCEDURE 
	 */ 
	public int PROCEDUREReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PROCEDURE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of RQA_I08_OBSERVATION (a Group object) - creates it if necessary
	///</summary>
	public RQA_I08_OBSERVATION getOBSERVATION() {
	   RQA_I08_OBSERVATION ret = null;
	   try {
	      ret = (RQA_I08_OBSERVATION)this.GetStructure("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RQA_I08_OBSERVATION
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RQA_I08_OBSERVATION getOBSERVATION(int rep) { 
	   return (RQA_I08_OBSERVATION)this.GetStructure("OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RQA_I08_OBSERVATION 
	 */ 
	public int OBSERVATIONReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("OBSERVATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns RQA_I08_VISIT (a Group object) - creates it if necessary
	///</summary>
	public RQA_I08_VISIT VISIT { 
get{
	   RQA_I08_VISIT ret = null;
	   try {
	      ret = (RQA_I08_VISIT)this.GetStructure("VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary
	///</summary>
	public NTE getNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (NTE - notes and comments segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE getNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTEReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
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