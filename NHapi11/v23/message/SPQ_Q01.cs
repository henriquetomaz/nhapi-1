using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a SPQ_Q01 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: SPR (Stored Procedure Request Definition) <b></b><br>
 * 2: RDF (Table Row Definition) <b>optional </b><br>
 * 3: DSC (Continuation pointer segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
public class SPQ_Q01 : AbstractMessage  {

	/** 
	 * Creates a new SPQ_Q01 Group with custom ModelClassFactory.
	 */
	public SPQ_Q01(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new SPQ_Q01 Group with DefaultModelClassFactory. 
	 */ 
	public SPQ_Q01() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(SPR), true, false);
	      this.add(typeof(RDF), false, false);
	      this.add(typeof(DSC), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SPQ_Q01 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (Message header segment) - creates it if necessary
	 */
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.get_Renamed("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns SPR (Stored Procedure Request Definition) - creates it if necessary
	 */
	public SPR SPR { 
get{
	   SPR ret = null;
	   try {
	      ret = (SPR)this.get_Renamed("SPR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RDF (Table Row Definition) - creates it if necessary
	 */
	public RDF RDF { 
get{
	   RDF ret = null;
	   try {
	      ret = (RDF)this.get_Renamed("RDF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns DSC (Continuation pointer segment) - creates it if necessary
	 */
	public DSC DSC { 
get{
	   DSC ret = null;
	   try {
	      ret = (DSC)this.get_Renamed("DSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
