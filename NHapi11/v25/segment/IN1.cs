using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 IN1 message segment. 
 * This segment has the following fields:</p><p>
 * IN1-1: Set ID - IN1 (SI)<br> 
 * IN1-2: Insurance Plan ID (CE)<br> 
 * IN1-3: Insurance Company ID (CX)<br> 
 * IN1-4: Insurance Company Name (XON)<br> 
 * IN1-5: Insurance Company Address (XAD)<br> 
 * IN1-6: Insurance Co Contact Person (XPN)<br> 
 * IN1-7: Insurance Co Phone Number (XTN)<br> 
 * IN1-8: Group Number (ST)<br> 
 * IN1-9: Group Name (XON)<br> 
 * IN1-10: Insured's Group Emp ID (CX)<br> 
 * IN1-11: Insured's Group Emp Name (XON)<br> 
 * IN1-12: Plan Effective Date (DT)<br> 
 * IN1-13: Plan Expiration Date (DT)<br> 
 * IN1-14: Authorization Information (AUI)<br> 
 * IN1-15: Plan Type (IS)<br> 
 * IN1-16: Name Of Insured (XPN)<br> 
 * IN1-17: Insured's Relationship To Patient (CE)<br> 
 * IN1-18: Insured's Date Of Birth (TS)<br> 
 * IN1-19: Insured's Address (XAD)<br> 
 * IN1-20: Assignment Of Benefits (IS)<br> 
 * IN1-21: Coordination Of Benefits (IS)<br> 
 * IN1-22: Coord Of Ben. Priority (ST)<br> 
 * IN1-23: Notice Of Admission Flag (ID)<br> 
 * IN1-24: Notice Of Admission Date (DT)<br> 
 * IN1-25: Report Of Eligibility Flag (ID)<br> 
 * IN1-26: Report Of Eligibility Date (DT)<br> 
 * IN1-27: Release Information Code (IS)<br> 
 * IN1-28: Pre-Admit Cert (PAC) (ST)<br> 
 * IN1-29: Verification Date/Time (TS)<br> 
 * IN1-30: Verification By (XCN)<br> 
 * IN1-31: Type Of Agreement Code (IS)<br> 
 * IN1-32: Billing Status (IS)<br> 
 * IN1-33: Lifetime Reserve Days (NM)<br> 
 * IN1-34: Delay Before L.R. Day (NM)<br> 
 * IN1-35: Company Plan Code (IS)<br> 
 * IN1-36: Policy Number (ST)<br> 
 * IN1-37: Policy Deductible (CP)<br> 
 * IN1-38: Policy Limit - Amount (CP)<br> 
 * IN1-39: Policy Limit - Days (NM)<br> 
 * IN1-40: Room Rate - Semi-Private (CP)<br> 
 * IN1-41: Room Rate - Private (CP)<br> 
 * IN1-42: Insured's Employment Status (CE)<br> 
 * IN1-43: Insured's Administrative Sex (IS)<br> 
 * IN1-44: Insured's Employer's Address (XAD)<br> 
 * IN1-45: Verification Status (ST)<br> 
 * IN1-46: Prior Insurance Plan ID (IS)<br> 
 * IN1-47: Coverage Type (IS)<br> 
 * IN1-48: Handicap (IS)<br> 
 * IN1-49: Insured's ID Number (CX)<br> 
 * IN1-50: Signature Code (IS)<br> 
 * IN1-51: Signature Code Date (DT)<br> 
 * IN1-52: Insured_s Birth Place (ST)<br> 
 * IN1-53: VIP Indicator (IS)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class IN1 : AbstractSegment  {

  /**
   * Creates a IN1 (Insurance) segment object that belongs to the given 
   * message.  
   */
  public IN1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID - IN1");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Insurance Plan ID");
       this.add(typeof(CX), true, 0, 250, new System.Object[]{message}, "Insurance Company ID");
       this.add(typeof(XON), false, 0, 250, new System.Object[]{message}, "Insurance Company Name");
       this.add(typeof(XAD), false, 0, 250, new System.Object[]{message}, "Insurance Company Address");
       this.add(typeof(XPN), false, 0, 250, new System.Object[]{message}, "Insurance Co Contact Person");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Insurance Co Phone Number");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "Group Number");
       this.add(typeof(XON), false, 0, 250, new System.Object[]{message}, "Group Name");
       this.add(typeof(CX), false, 0, 250, new System.Object[]{message}, "Insured's Group Emp ID");
       this.add(typeof(XON), false, 0, 250, new System.Object[]{message}, "Insured's Group Emp Name");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Plan Effective Date");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Plan Expiration Date");
       this.add(typeof(AUI), false, 1, 239, new System.Object[]{message}, "Authorization Information");
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 86}, "Plan Type");
       this.add(typeof(XPN), false, 0, 250, new System.Object[]{message}, "Name Of Insured");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Insured's Relationship To Patient");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Insured's Date Of Birth");
       this.add(typeof(XAD), false, 0, 250, new System.Object[]{message}, "Insured's Address");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 135}, "Assignment Of Benefits");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 173}, "Coordination Of Benefits");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "Coord Of Ben. Priority");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Notice Of Admission Flag");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Notice Of Admission Date");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Report Of Eligibility Flag");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Report Of Eligibility Date");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 93}, "Release Information Code");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "Pre-Admit Cert (PAC)");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Verification Date/Time");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Verification By");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 98}, "Type Of Agreement Code");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 22}, "Billing Status");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Lifetime Reserve Days");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Delay Before L.R. Day");
       this.add(typeof(IS), false, 1, 8, new System.Object[]{message, 42}, "Company Plan Code");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "Policy Number");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Policy Deductible");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Policy Limit - Amount");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Policy Limit - Days");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Room Rate - Semi-Private");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Room Rate - Private");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Insured's Employment Status");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 1}, "Insured's Administrative Sex");
       this.add(typeof(XAD), false, 0, 250, new System.Object[]{message}, "Insured's Employer's Address");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "Verification Status");
       this.add(typeof(IS), false, 1, 8, new System.Object[]{message, 72}, "Prior Insurance Plan ID");
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 309}, "Coverage Type");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 295}, "Handicap");
       this.add(typeof(CX), false, 0, 250, new System.Object[]{message}, "Insured's ID Number");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 535}, "Signature Code");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Signature Code Date");
       this.add(typeof(ST), false, 1, 250, new System.Object[]{message}, "Insured_s Birth Place");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 99}, "VIP Indicator");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - IN1(IN1-1).
	*/
	public SI SetIDIN1
	{
		get{
			SI ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (SI)t;
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
	* Returns Insurance Plan ID(IN1-2).
	*/
	public CE InsurancePlanID
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (CE)t;
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
	* Returns a single repetition of Insurance Company ID(IN1-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CX getInsuranceCompanyID(int rep)
	{
			CX ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insurance Company ID (IN1-3).
   */
  public CX[] getInsuranceCompanyID() {
     CX[] ret = null;
    try {
        Type[] t = this.getField(3);  
        ret = new CX[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CX)t[i];
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
	* Returns a single repetition of Insurance Company Name(IN1-4).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XON getInsuranceCompanyName(int rep)
	{
			XON ret = null;
			try
			{
			Type t = this.getField(4, rep);
				ret = (XON)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insurance Company Name (IN1-4).
   */
  public XON[] getInsuranceCompanyName() {
     XON[] ret = null;
    try {
        Type[] t = this.getField(4);  
        ret = new XON[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XON)t[i];
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
	* Returns a single repetition of Insurance Company Address(IN1-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XAD getInsuranceCompanyAddress(int rep)
	{
			XAD ret = null;
			try
			{
			Type t = this.getField(5, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insurance Company Address (IN1-5).
   */
  public XAD[] getInsuranceCompanyAddress() {
     XAD[] ret = null;
    try {
        Type[] t = this.getField(5);  
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
	* Returns a single repetition of Insurance Co Contact Person(IN1-6).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XPN getInsuranceCoContactPerson(int rep)
	{
			XPN ret = null;
			try
			{
			Type t = this.getField(6, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insurance Co Contact Person (IN1-6).
   */
  public XPN[] getInsuranceCoContactPerson() {
     XPN[] ret = null;
    try {
        Type[] t = this.getField(6);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
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
	* Returns a single repetition of Insurance Co Phone Number(IN1-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getInsuranceCoPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insurance Co Phone Number (IN1-7).
   */
  public XTN[] getInsuranceCoPhoneNumber() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(7);  
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
	* Returns Group Number(IN1-8).
	*/
	public ST GroupNumber
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns a single repetition of Group Name(IN1-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XON getGroupName(int rep)
	{
			XON ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (XON)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Group Name (IN1-9).
   */
  public XON[] getGroupName() {
     XON[] ret = null;
    try {
        Type[] t = this.getField(9);  
        ret = new XON[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XON)t[i];
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
	* Returns a single repetition of Insured's Group Emp ID(IN1-10).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CX getInsuredSGroupEmpID(int rep)
	{
			CX ret = null;
			try
			{
			Type t = this.getField(10, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insured's Group Emp ID (IN1-10).
   */
  public CX[] getInsuredSGroupEmpID() {
     CX[] ret = null;
    try {
        Type[] t = this.getField(10);  
        ret = new CX[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CX)t[i];
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
	* Returns a single repetition of Insured's Group Emp Name(IN1-11).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XON getInsuredSGroupEmpName(int rep)
	{
			XON ret = null;
			try
			{
			Type t = this.getField(11, rep);
				ret = (XON)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insured's Group Emp Name (IN1-11).
   */
  public XON[] getInsuredSGroupEmpName() {
     XON[] ret = null;
    try {
        Type[] t = this.getField(11);  
        ret = new XON[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XON)t[i];
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
	* Returns Plan Effective Date(IN1-12).
	*/
	public DT PlanEffectiveDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (DT)t;
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
	* Returns Plan Expiration Date(IN1-13).
	*/
	public DT PlanExpirationDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(13, 0);
				ret = (DT)t;
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
	* Returns Authorization Information(IN1-14).
	*/
	public AUI AuthorizationInformation
	{
		get{
			AUI ret = null;
			try
			{
			Type t = this.getField(14, 0);
				ret = (AUI)t;
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
	* Returns Plan Type(IN1-15).
	*/
	public IS PlanType
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(15, 0);
				ret = (IS)t;
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
	* Returns a single repetition of Name Of Insured(IN1-16).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XPN getNameOfInsured(int rep)
	{
			XPN ret = null;
			try
			{
			Type t = this.getField(16, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Name Of Insured (IN1-16).
   */
  public XPN[] getNameOfInsured() {
     XPN[] ret = null;
    try {
        Type[] t = this.getField(16);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
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
	* Returns Insured's Relationship To Patient(IN1-17).
	*/
	public CE InsuredSRelationshipToPatient
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(17, 0);
				ret = (CE)t;
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
	* Returns Insured's Date Of Birth(IN1-18).
	*/
	public TS InsuredSDateOfBirth
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(18, 0);
				ret = (TS)t;
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
	* Returns a single repetition of Insured's Address(IN1-19).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XAD getInsuredSAddress(int rep)
	{
			XAD ret = null;
			try
			{
			Type t = this.getField(19, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insured's Address (IN1-19).
   */
  public XAD[] getInsuredSAddress() {
     XAD[] ret = null;
    try {
        Type[] t = this.getField(19);  
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
	* Returns Assignment Of Benefits(IN1-20).
	*/
	public IS AssignmentOfBenefits
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(20, 0);
				ret = (IS)t;
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
	* Returns Coordination Of Benefits(IN1-21).
	*/
	public IS CoordinationOfBenefits
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(21, 0);
				ret = (IS)t;
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
	* Returns Coord Of Ben. Priority(IN1-22).
	*/
	public ST CoordOfBenPriority
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(22, 0);
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
	* Returns Notice Of Admission Flag(IN1-23).
	*/
	public ID NoticeOfAdmissionFlag
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(23, 0);
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
	* Returns Notice Of Admission Date(IN1-24).
	*/
	public DT NoticeOfAdmissionDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(24, 0);
				ret = (DT)t;
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
	* Returns Report Of Eligibility Flag(IN1-25).
	*/
	public ID ReportOfEligibilityFlag
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(25, 0);
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
	* Returns Report Of Eligibility Date(IN1-26).
	*/
	public DT ReportOfEligibilityDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(26, 0);
				ret = (DT)t;
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
	* Returns Release Information Code(IN1-27).
	*/
	public IS ReleaseInformationCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(27, 0);
				ret = (IS)t;
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
	* Returns Pre-Admit Cert (PAC)(IN1-28).
	*/
	public ST PreAdmitCert
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(28, 0);
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
	* Returns Verification Date/Time(IN1-29).
	*/
	public TS VerificationDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(29, 0);
				ret = (TS)t;
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
	* Returns a single repetition of Verification By(IN1-30).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getVerificationBy(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(30, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Verification By (IN1-30).
   */
  public XCN[] getVerificationBy() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(30);  
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
	* Returns Type Of Agreement Code(IN1-31).
	*/
	public IS TypeOfAgreementCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(31, 0);
				ret = (IS)t;
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
	* Returns Billing Status(IN1-32).
	*/
	public IS BillingStatus
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(32, 0);
				ret = (IS)t;
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
	* Returns Lifetime Reserve Days(IN1-33).
	*/
	public NM LifetimeReserveDays
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(33, 0);
				ret = (NM)t;
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
	* Returns Delay Before L.R. Day(IN1-34).
	*/
	public NM DelayBeforeLRDay
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(34, 0);
				ret = (NM)t;
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
	* Returns Company Plan Code(IN1-35).
	*/
	public IS CompanyPlanCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(35, 0);
				ret = (IS)t;
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
	* Returns Policy Number(IN1-36).
	*/
	public ST PolicyNumber
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(36, 0);
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
	* Returns Policy Deductible(IN1-37).
	*/
	public CP PolicyDeductible
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(37, 0);
				ret = (CP)t;
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
	* Returns Policy Limit - Amount(IN1-38).
	*/
	public CP PolicyLimitAmount
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(38, 0);
				ret = (CP)t;
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
	* Returns Policy Limit - Days(IN1-39).
	*/
	public NM PolicyLimitDays
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(39, 0);
				ret = (NM)t;
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
	* Returns Room Rate - Semi-Private(IN1-40).
	*/
	public CP RoomRateSemiPrivate
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(40, 0);
				ret = (CP)t;
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
	* Returns Room Rate - Private(IN1-41).
	*/
	public CP RoomRatePrivate
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(41, 0);
				ret = (CP)t;
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
	* Returns Insured's Employment Status(IN1-42).
	*/
	public CE InsuredSEmploymentStatus
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(42, 0);
				ret = (CE)t;
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
	* Returns Insured's Administrative Sex(IN1-43).
	*/
	public IS InsuredSAdministrativeSex
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(43, 0);
				ret = (IS)t;
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
	* Returns a single repetition of Insured's Employer's Address(IN1-44).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XAD getInsuredSEmployerSAddress(int rep)
	{
			XAD ret = null;
			try
			{
			Type t = this.getField(44, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insured's Employer's Address (IN1-44).
   */
  public XAD[] getInsuredSEmployerSAddress() {
     XAD[] ret = null;
    try {
        Type[] t = this.getField(44);  
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
	* Returns Verification Status(IN1-45).
	*/
	public ST VerificationStatus
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(45, 0);
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
	* Returns Prior Insurance Plan ID(IN1-46).
	*/
	public IS PriorInsurancePlanID
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(46, 0);
				ret = (IS)t;
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
	* Returns Coverage Type(IN1-47).
	*/
	public IS CoverageType
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(47, 0);
				ret = (IS)t;
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
	* Returns Handicap(IN1-48).
	*/
	public IS Handicap
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(48, 0);
				ret = (IS)t;
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
	* Returns a single repetition of Insured's ID Number(IN1-49).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CX getInsuredSIDNumber(int rep)
	{
			CX ret = null;
			try
			{
			Type t = this.getField(49, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insured's ID Number (IN1-49).
   */
  public CX[] getInsuredSIDNumber() {
     CX[] ret = null;
    try {
        Type[] t = this.getField(49);  
        ret = new CX[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CX)t[i];
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
	* Returns Signature Code(IN1-50).
	*/
	public IS SignatureCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(50, 0);
				ret = (IS)t;
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
	* Returns Signature Code Date(IN1-51).
	*/
	public DT SignatureCodeDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(51, 0);
				ret = (DT)t;
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
	* Returns Insured_s Birth Place(IN1-52).
	*/
	public ST InsuredSBirthPlace
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(52, 0);
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
	* Returns VIP Indicator(IN1-53).
	*/
	public IS VIPIndicator
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(53, 0);
				ret = (IS)t;
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