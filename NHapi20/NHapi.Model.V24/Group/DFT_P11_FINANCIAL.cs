using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
///<summary>
///Represents the DFT_P11_FINANCIAL Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: FT1 (Financial Transaction) 
/// * 1: DFT_P11_FINANCIAL_PROCEDURE (a Group object) optional repeating
/// * 2: DFT_P11_FINANCIAL_COMMON_ORDER (a Group object) optional repeating
/// * 3: DG1 (Diagnosis) optional repeating
/// * 4: DRG (Diagnosis Related Group) optional 
/// * 5: GT1 (Guarantor) optional repeating
/// * 6: DFT_P11_FINANCIAL_INSURANCE (a Group object) optional repeating
///</summary>
[Serializable]
public class DFT_P11_FINANCIAL : AbstractGroup {

	///<summary> 
	/// Creates a new DFT_P11_FINANCIAL Group.
	///</summary>
	public DFT_P11_FINANCIAL(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(FT1), true, false);
	      this.add(typeof(DFT_P11_FINANCIAL_PROCEDURE), false, true);
	      this.add(typeof(DFT_P11_FINANCIAL_COMMON_ORDER), false, true);
	      this.add(typeof(DG1), false, true);
	      this.add(typeof(DRG), false, false);
	      this.add(typeof(GT1), false, true);
	      this.add(typeof(DFT_P11_FINANCIAL_INSURANCE), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating DFT_P11_FINANCIAL - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns FT1 (Financial Transaction) - creates it if necessary
	///</summary>
	public FT1 FT1 { 
get{
	   FT1 ret = null;
	   try {
	      ret = (FT1)this.GetStructure("FT1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of DFT_P11_FINANCIAL_PROCEDURE (a Group object) - creates it if necessary
	///</summary>
	public DFT_P11_FINANCIAL_PROCEDURE getFINANCIAL_PROCEDURE() {
	   DFT_P11_FINANCIAL_PROCEDURE ret = null;
	   try {
	      ret = (DFT_P11_FINANCIAL_PROCEDURE)this.GetStructure("FINANCIAL_PROCEDURE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DFT_P11_FINANCIAL_PROCEDURE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DFT_P11_FINANCIAL_PROCEDURE getFINANCIAL_PROCEDURE(int rep) { 
	   return (DFT_P11_FINANCIAL_PROCEDURE)this.GetStructure("FINANCIAL_PROCEDURE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DFT_P11_FINANCIAL_PROCEDURE 
	 */ 
	public int FINANCIAL_PROCEDUREReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("FINANCIAL_PROCEDURE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of DFT_P11_FINANCIAL_COMMON_ORDER (a Group object) - creates it if necessary
	///</summary>
	public DFT_P11_FINANCIAL_COMMON_ORDER getFINANCIAL_COMMON_ORDER() {
	   DFT_P11_FINANCIAL_COMMON_ORDER ret = null;
	   try {
	      ret = (DFT_P11_FINANCIAL_COMMON_ORDER)this.GetStructure("FINANCIAL_COMMON_ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DFT_P11_FINANCIAL_COMMON_ORDER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DFT_P11_FINANCIAL_COMMON_ORDER getFINANCIAL_COMMON_ORDER(int rep) { 
	   return (DFT_P11_FINANCIAL_COMMON_ORDER)this.GetStructure("FINANCIAL_COMMON_ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DFT_P11_FINANCIAL_COMMON_ORDER 
	 */ 
	public int FINANCIAL_COMMON_ORDERReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("FINANCIAL_COMMON_ORDER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of DG1 (Diagnosis) - creates it if necessary
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
	/// * (Diagnosis) - creates it if necessary
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
	/// Returns DRG (Diagnosis Related Group) - creates it if necessary
	///</summary>
	public DRG DRG { 
get{
	   DRG ret = null;
	   try {
	      ret = (DRG)this.GetStructure("DRG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of GT1 (Guarantor) - creates it if necessary
	///</summary>
	public GT1 getGT1() {
	   GT1 ret = null;
	   try {
	      ret = (GT1)this.GetStructure("GT1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of GT1
	/// * (Guarantor) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public GT1 getGT1(int rep) { 
	   return (GT1)this.GetStructure("GT1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of GT1 
	 */ 
	public int GT1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("GT1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of DFT_P11_FINANCIAL_INSURANCE (a Group object) - creates it if necessary
	///</summary>
	public DFT_P11_FINANCIAL_INSURANCE getFINANCIAL_INSURANCE() {
	   DFT_P11_FINANCIAL_INSURANCE ret = null;
	   try {
	      ret = (DFT_P11_FINANCIAL_INSURANCE)this.GetStructure("FINANCIAL_INSURANCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DFT_P11_FINANCIAL_INSURANCE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DFT_P11_FINANCIAL_INSURANCE getFINANCIAL_INSURANCE(int rep) { 
	   return (DFT_P11_FINANCIAL_INSURANCE)this.GetStructure("FINANCIAL_INSURANCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DFT_P11_FINANCIAL_INSURANCE 
	 */ 
	public int FINANCIAL_INSURANCEReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("FINANCIAL_INSURANCE").Length; 
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
