using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V25UCH.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V25UCH.Group
{
///<summary>
///Represents the ORL_O34_ORDER Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: ORC (Common Order) </li>
///<li>1: ORL_O34_TIMING (a Group object) optional repeating</li>
///<li>2: ORL_O34_OBSERVATION_REQUEST (a Group object) optional </li>
///</ol>
///</summary>
[Serializable]
public class ORL_O34_ORDER : AbstractGroup {

	///<summary> 
	/// Creates a new ORL_O34_ORDER Group.
	///</summary>
	public ORL_O34_ORDER(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(ORL_O34_TIMING), false, true);
	      this.add(typeof(ORL_O34_OBSERVATION_REQUEST), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORL_O34_ORDER - this is probably a bug in the source code generator.", e);
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
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of ORL_O34_TIMING (a Group object) - creates it if necessary
	///</summary>
	public ORL_O34_TIMING GetTIMING() {
	   ORL_O34_TIMING ret = null;
	   try {
	      ret = (ORL_O34_TIMING)this.GetStructure("TIMING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of ORL_O34_TIMING
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public ORL_O34_TIMING GetTIMING(int rep) { 
	   return (ORL_O34_TIMING)this.GetStructure("TIMING", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORL_O34_TIMING 
	 */ 
	public int TIMINGRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("TIMING").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns ORL_O34_OBSERVATION_REQUEST (a Group object) - creates it if necessary
	///</summary>
	public ORL_O34_OBSERVATION_REQUEST OBSERVATION_REQUEST { 
get{
	   ORL_O34_OBSERVATION_REQUEST ret = null;
	   try {
	      ret = (ORL_O34_OBSERVATION_REQUEST)this.GetStructure("OBSERVATION_REQUEST");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
