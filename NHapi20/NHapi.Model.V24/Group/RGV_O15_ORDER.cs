using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V24.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V24.Group
{
///<summary>
///Represents the RGV_O15_ORDER Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
/// * 0: ORC (Common Order) 
/// * 1: RGV_O15_ORDER_DETAIL (a Group object) optional 
/// * 2: RGV_O15_ENCODING (a Group object) optional 
/// * 3: RGV_O15_GIVE (a Group object) repeating
///</summary>
[Serializable]
public class RGV_O15_ORDER : AbstractGroup {

	///<summary> 
	/// Creates a new RGV_O15_ORDER Group.
	///</summary>
	public RGV_O15_ORDER(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(RGV_O15_ORDER_DETAIL), false, false);
	      this.add(typeof(RGV_O15_ENCODING), false, false);
	      this.add(typeof(RGV_O15_GIVE), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RGV_O15_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns ORC (Common Order) - creates it if necessary
	///</summary>
	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.GetStructure("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RGV_O15_ORDER_DETAIL (a Group object) - creates it if necessary
	///</summary>
	public RGV_O15_ORDER_DETAIL ORDER_DETAIL { 
get{
	   RGV_O15_ORDER_DETAIL ret = null;
	   try {
	      ret = (RGV_O15_ORDER_DETAIL)this.GetStructure("ORDER_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RGV_O15_ENCODING (a Group object) - creates it if necessary
	///</summary>
	public RGV_O15_ENCODING ENCODING { 
get{
	   RGV_O15_ENCODING ret = null;
	   try {
	      ret = (RGV_O15_ENCODING)this.GetStructure("ENCODING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of RGV_O15_GIVE (a Group object) - creates it if necessary
	///</summary>
	public RGV_O15_GIVE getGIVE() {
	   RGV_O15_GIVE ret = null;
	   try {
	      ret = (RGV_O15_GIVE)this.GetStructure("GIVE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RGV_O15_GIVE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RGV_O15_GIVE getGIVE(int rep) { 
	   return (RGV_O15_GIVE)this.GetStructure("GIVE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RGV_O15_GIVE 
	 */ 
	public int GIVEReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("GIVE").Length; 
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
