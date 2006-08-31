using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V25.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V25.Segment{

///<summary>
/// Represents an HL7 OM2 message segment. 
/// This segment has the following fields:
/// * OM2-1: Sequence Number - Test/Observation Master File (NM)
/// * OM2-2: Units of Measure (CE)
/// * OM2-3: Range of Decimal Precision (NM)
/// * OM2-4: Corresponding SI Units of Measure (CE)
/// * OM2-5: SI Conversion Factor (TX)
/// * OM2-6: Reference (Normal) Range - Ordinal and Continuous Observations (RFR)
/// * OM2-7: Critical Range for Ordinal and Continuous Observations (RFR)
/// * OM2-8: Absolute Range for Ordinal and Continuous Observations (RFR)
/// * OM2-9: Delta Check Criteria (DLT)
/// * OM2-10: Minimum Meaningful Increments (NM)
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class OM2 : AbstractSegment  {

  /**
   * Creates a OM2 (Numeric Observation) segment object that belongs to the given 
   * message.  
   */
	public OM2(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Sequence Number - Test/Observation Master File");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Units of Measure");
       this.add(typeof(NM), false, 0, 10, new System.Object[]{message}, "Range of Decimal Precision");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Corresponding SI Units of Measure");
       this.add(typeof(TX), false, 1, 60, new System.Object[]{message}, "SI Conversion Factor");
       this.add(typeof(RFR), false, 0, 250, new System.Object[]{message}, "Reference (Normal) Range - Ordinal and Continuous Observations");
       this.add(typeof(RFR), false, 0, 205, new System.Object[]{message}, "Critical Range for Ordinal and Continuous Observations");
       this.add(typeof(RFR), false, 1, 250, new System.Object[]{message}, "Absolute Range for Ordinal and Continuous Observations");
       this.add(typeof(DLT), false, 0, 250, new System.Object[]{message}, "Delta Check Criteria");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Minimum Meaningful Increments");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Sequence Number - Test/Observation Master File(OM2-1).
	///</summary>
	public NM SequenceNumberTestObservationMasterFile
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

	///<summary>
	/// Returns Units of Measure(OM2-2).
	///</summary>
	public CE UnitsOfMeasure
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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

	///<summary>
	/// Returns a single repetition of Range of Decimal Precision(OM2-3).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public NM getRangeOfDecimalPrecision(int rep)
	{
			NM ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (NM)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Range of Decimal Precision (OM2-3).
   ///</summary>
  public NM[] getRangeOfDecimalPrecision() {
     NM[] ret = null;
    try {
        IType[] t = this.GetField(3);  
        ret = new NM[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (NM)t[i];
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

	///<summary>
	/// Returns Corresponding SI Units of Measure(OM2-4).
	///</summary>
	public CE CorrespondingSIUnitsOfMeasure
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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

	///<summary>
	/// Returns SI Conversion Factor(OM2-5).
	///</summary>
	public TX SIConversionFactor
	{
		get{
			TX ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (TX)t;
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

	///<summary>
	/// Returns a single repetition of Reference (Normal) Range - Ordinal and Continuous Observations(OM2-6).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public RFR getReferenceNormalRangeOrdinalAndContinuousObservations(int rep)
	{
			RFR ret = null;
			try
			{
			IType t = this.GetField(6, rep);
				ret = (RFR)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Reference (Normal) Range - Ordinal and Continuous Observations (OM2-6).
   ///</summary>
  public RFR[] getReferenceNormalRangeOrdinalAndContinuousObservations() {
     RFR[] ret = null;
    try {
        IType[] t = this.GetField(6);  
        ret = new RFR[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (RFR)t[i];
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

	///<summary>
	/// Returns a single repetition of Critical Range for Ordinal and Continuous Observations(OM2-7).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public RFR getCriticalRangeForOrdinalAndContinuousObservations(int rep)
	{
			RFR ret = null;
			try
			{
			IType t = this.GetField(7, rep);
				ret = (RFR)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Critical Range for Ordinal and Continuous Observations (OM2-7).
   ///</summary>
  public RFR[] getCriticalRangeForOrdinalAndContinuousObservations() {
     RFR[] ret = null;
    try {
        IType[] t = this.GetField(7);  
        ret = new RFR[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (RFR)t[i];
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

	///<summary>
	/// Returns Absolute Range for Ordinal and Continuous Observations(OM2-8).
	///</summary>
	public RFR AbsoluteRangeForOrdinalAndContinuousObservations
	{
		get{
			RFR ret = null;
			try
			{
			IType t = this.GetField(8, 0);
				ret = (RFR)t;
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

	///<summary>
	/// Returns a single repetition of Delta Check Criteria(OM2-9).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public DLT getDeltaCheckCriteria(int rep)
	{
			DLT ret = null;
			try
			{
			IType t = this.GetField(9, rep);
				ret = (DLT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Delta Check Criteria (OM2-9).
   ///</summary>
  public DLT[] getDeltaCheckCriteria() {
     DLT[] ret = null;
    try {
        IType[] t = this.GetField(9);  
        ret = new DLT[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (DLT)t[i];
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

	///<summary>
	/// Returns Minimum Meaningful Increments(OM2-10).
	///</summary>
	public NM MinimumMeaningfulIncrements
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(10, 0);
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


}}