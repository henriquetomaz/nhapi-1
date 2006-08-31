using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
    ///<summary>
    ///Represents the ORR_O02_ORDER Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: ORC (Common order segment) 
    /// * 1: OBR (Observation request segment) 
    /// * 2: RQD (Requisition detail) 
    /// * 3: RQ1 (Requisition detail-1 segment) 
    /// * 4: RXO (Pharmacy prescription order segment) 
    /// * 5: ODS (Dietary orders, supplements, and preferences) 
    /// * 6: ODT (Diet tray instructions segment) 
    /// * 7: NTE (Notes and comments segment) optional repeating
    /// * 8: CTI (Clinical Trial Identification) optional repeating
    ///</summary>
    [Serializable]
    public class ORR_O02_ORDER : AbstractGroup
    {

        ///<summary> 
        /// Creates a new ORR_O02_ORDER Group.
        ///</summary>
        public ORR_O02_ORDER(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(ORC), true, false);
                this.add(typeof(OBR), true, false);
                this.add(typeof(RQD), true, false);
                this.add(typeof(RQ1), true, false);
                this.add(typeof(RXO), true, false);
                this.add(typeof(ODS), true, false);
                this.add(typeof(ODT), true, false);
                this.add(typeof(NTE), false, true);
                this.add(typeof(CTI), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORR_O02_ORDER - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns ORC (Common order segment) - creates it if necessary
        ///</summary>
        public ORC ORC
        {
            get
            {
                ORC ret = null;
                try
                {
                    ret = (ORC)this.GetStructure("ORC");
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
        /// Returns OBR (Observation request segment) - creates it if necessary
        ///</summary>
        public OBR OBR
        {
            get
            {
                OBR ret = null;
                try
                {
                    ret = (OBR)this.GetStructure("OBR");
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
        /// Returns RQD (Requisition detail) - creates it if necessary
        ///</summary>
        public RQD RQD
        {
            get
            {
                RQD ret = null;
                try
                {
                    ret = (RQD)this.GetStructure("RQD");
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
        /// Returns RQ1 (Requisition detail-1 segment) - creates it if necessary
        ///</summary>
        public RQ1 RQ1
        {
            get
            {
                RQ1 ret = null;
                try
                {
                    ret = (RQ1)this.GetStructure("RQ1");
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
        /// Returns RXO (Pharmacy prescription order segment) - creates it if necessary
        ///</summary>
        public RXO RXO
        {
            get
            {
                RXO ret = null;
                try
                {
                    ret = (RXO)this.GetStructure("RXO");
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
        /// Returns ODS (Dietary orders, supplements, and preferences) - creates it if necessary
        ///</summary>
        public ODS ODS
        {
            get
            {
                ODS ret = null;
                try
                {
                    ret = (ODS)this.GetStructure("ODS");
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
        /// Returns ODT (Diet tray instructions segment) - creates it if necessary
        ///</summary>
        public ODT ODT
        {
            get
            {
                ODT ret = null;
                try
                {
                    ret = (ODT)this.GetStructure("ODT");
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
        /// Returns  first repetition of NTE (Notes and comments segment) - creates it if necessary
        ///</summary>
        public NTE getNTE()
        {
            NTE ret = null;
            try
            {
                ret = (NTE)this.GetStructure("NTE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of NTE
        /// * (Notes and comments segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public NTE getNTE(int rep)
        {
            return (NTE)this.GetStructure("NTE", rep);
        }

        /** 
         * Returns the number of existing repetitions of NTE 
         */
        public int NTEReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("NTE").Length;
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

        ///<summary>
        /// Returns  first repetition of CTI (Clinical Trial Identification) - creates it if necessary
        ///</summary>
        public CTI getCTI()
        {
            CTI ret = null;
            try
            {
                ret = (CTI)this.GetStructure("CTI");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of CTI
        /// * (Clinical Trial Identification) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public CTI getCTI(int rep)
        {
            return (CTI)this.GetStructure("CTI", rep);
        }

        /** 
         * Returns the number of existing repetitions of CTI 
         */
        public int CTIReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("CTI").Length;
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