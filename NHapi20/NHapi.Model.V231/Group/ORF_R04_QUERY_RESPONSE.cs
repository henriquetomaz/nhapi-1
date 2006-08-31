using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the ORF_R04_QUERY_RESPONSE Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: ORF_R04_PATIENT (a Group object) optional 
    /// * 1: ORF_R04_ORDER (a Group object) repeating
    ///</summary>
    [Serializable]
    public class ORF_R04_QUERY_RESPONSE : AbstractGroup
    {

        ///<summary> 
        /// Creates a new ORF_R04_QUERY_RESPONSE Group.
        ///</summary>
        public ORF_R04_QUERY_RESPONSE(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(ORF_R04_PATIENT), false, false);
                this.add(typeof(ORF_R04_ORDER), true, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORF_R04_QUERY_RESPONSE - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns ORF_R04_PATIENT (a Group object) - creates it if necessary
        ///</summary>
        public ORF_R04_PATIENT PATIENT
        {
            get
            {
                ORF_R04_PATIENT ret = null;
                try
                {
                    ret = (ORF_R04_PATIENT)this.GetStructure("PATIENT");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns  first repetition of ORF_R04_ORDER (a Group object) - creates it if necessary
        ///</summary>
        public ORF_R04_ORDER getORDER()
        {
            ORF_R04_ORDER ret = null;
            try
            {
                ret = (ORF_R04_ORDER)this.GetStructure("ORDER");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of ORF_R04_ORDER
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public ORF_R04_ORDER getORDER(int rep)
        {
            return (ORF_R04_ORDER)this.GetStructure("ORDER", rep);
        }

        /** 
         * Returns the number of existing repetitions of ORF_R04_ORDER 
         */
        public int ORDERReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("ORDER").Length;
                }
                catch (HL7Exception e)
                {
                    string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.getHapiLog(GetType()).error(message, e);
                    throw new System.Exception(message);
                }
                return reps;
            }
        }

    }
}