using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v23.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v23.segment{

/**
 * <p>Represents an HL7 FAC message segment. 
 * This segment has the following fields:</p><p>
 * FAC-1: Facility ID (EI)<br> 
 * FAC-2: Facility Type (ID)<br> 
 * FAC-3: Facility Address (XAD)<br> 
 * FAC-4: Facility Telecommunication (XTN)<br> 
 * FAC-5: Contact Person (XCN)<br> 
 * FAC-6: Contact Title (ST)<br> 
 * FAC-7: Contact Address (XAD)<br> 
 * FAC-8: Contact Telecommunication (XTN)<br> 
 * FAC-9: Signature Authority (XCN)<br> 
 * FAC-10: Signature Authority Title (ST)<br> 
 * FAC-11: Signature Authority Address (XAD)<br> 
 * FAC-12: Signature Authority Telecommunication (XTN)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class FAC : AbstractSegment  {

  /**
   * Creates a FAC (Facility) segment object that belongs to the given 
   * message.  
   */
  public FAC(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(EI), true, 0, 60, new System.Object[]{message}, "Facility ID");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 331}, "Facility Type");
       this.add(typeof(XAD), true, 1, 200, new System.Object[]{message}, "Facility Address");
       this.add(typeof(XTN), true, 1, 44, new System.Object[]{message}, "Facility Telecommunication");
       this.add(typeof(XCN), false, 0, 60, new System.Object[]{message}, "Contact Person");
       this.add(typeof(ST), false, 0, 60, new System.Object[]{message}, "Contact Title");
       this.add(typeof(XAD), false, 0, 60, new System.Object[]{message}, "Contact Address");
       this.add(typeof(XTN), false, 0, 44, new System.Object[]{message}, "Contact Telecommunication");
       this.add(typeof(XCN), true, 1, 60, new System.Object[]{message}, "Signature Authority");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Signature Authority Title");
       this.add(typeof(XAD), false, 1, 200, new System.Object[]{message}, "Signature Authority Address");
       this.add(typeof(XTN), false, 1, 44, new System.Object[]{message}, "Signature Authority Telecommunication");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns a single repetition of Facility ID(FAC-1).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public EI getFacilityID(int rep)
	{
			EI ret = null;
			try
			{
			Type t = this.getField(1, rep);
				ret = (EI)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Facility ID (FAC-1).
   */
  public EI[] getFacilityID() {
     EI[] ret = null;
    try {
        Type[] t = this.getField(1);  
        ret = new EI[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (EI)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Facility Type(FAC-2).
	*/
	public ID FacilityType
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Facility Address(FAC-3).
	*/
	public XAD FacilityAddress
	{
		get{
			XAD ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (XAD)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Facility Telecommunication(FAC-4).
	*/
	public XTN FacilityTelecommunication
	{
		get{
			XTN ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (XTN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Contact Person(FAC-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getContactPerson(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(5, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Contact Person (FAC-5).
   */
  public XCN[] getContactPerson() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(5);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns a single repetition of Contact Title(FAC-6).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getContactTitle(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(6, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Contact Title (FAC-6).
   */
  public ST[] getContactTitle() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(6);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns a single repetition of Contact Address(FAC-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XAD getContactAddress(int rep)
	{
			XAD ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Contact Address (FAC-7).
   */
  public XAD[] getContactAddress() {
     XAD[] ret = null;
    try {
        Type[] t = this.getField(7);  
        ret = new XAD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XAD)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns a single repetition of Contact Telecommunication(FAC-8).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getContactTelecommunication(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(8, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Contact Telecommunication (FAC-8).
   */
  public XTN[] getContactTelecommunication() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(8);  
        ret = new XTN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XTN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns Signature Authority(FAC-9).
	*/
	public XCN SignatureAuthority
	{
		get{
			XCN ret = null;
			try
			{
			Type t = this.getField(9, 0);
				ret = (XCN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Signature Authority Title(FAC-10).
	*/
	public ST SignatureAuthorityTitle
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(10, 0);
				ret = (ST)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Signature Authority Address(FAC-11).
	*/
	public XAD SignatureAuthorityAddress
	{
		get{
			XAD ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (XAD)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Signature Authority Telecommunication(FAC-12).
	*/
	public XTN SignatureAuthorityTelecommunication
	{
		get{
			XTN ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (XTN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }


}}