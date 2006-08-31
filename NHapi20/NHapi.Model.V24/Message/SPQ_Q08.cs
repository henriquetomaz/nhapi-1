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
/// Represents a SPQ_Q08 message structure (see chapter [AAA]). This structure contains the 
/// following elements:
/// * 0: MSH (Message Header) 
/// * 1: SPR (Stored Procedure Request Definition) 
/// * 2: RDF (Table Row Definition) optional 
/// * 3: DSC (Continuation Pointer) optional 
///</summary>
[Serializable]
public class SPQ_Q08 : AbstractMessage  {

	///<summary> 
	/// Creates a new SPQ_Q08 Group with custom IModelClassFactory.
	///</summary>
	public SPQ_Q08(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new SPQ_Q08 Group with DefaultModelClassFactory. 
	///</summary> 
	public SPQ_Q08() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for SPQ_Q08.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(SPR), true, false);
	      this.add(typeof(RDF), false, false);
	      this.add(typeof(DSC), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SPQ_Q08 - this is probably a bug in the source code generator.", e);
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
	/// Returns SPR (Stored Procedure Request Definition) - creates it if necessary
	///</summary>
	public SPR SPR { 
get{
	   SPR ret = null;
	   try {
	      ret = (SPR)this.GetStructure("SPR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RDF (Table Row Definition) - creates it if necessary
	///</summary>
	public RDF RDF { 
get{
	   RDF ret = null;
	   try {
	      ret = (RDF)this.GetStructure("RDF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns DSC (Continuation Pointer) - creates it if necessary
	///</summary>
	public DSC DSC { 
get{
	   DSC ret = null;
	   try {
	      ret = (DSC)this.GetStructure("DSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
