using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OMS_O01_ORDER_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RQD (Requisition detail) <b></b><br>
 * 1: NTE (Notes and comments segment) <b>optional repeating</b><br>
 * 2: OMS_O01_OBSERVATION (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class OMS_O01_ORDER_DETAIL : AbstractGroup 
	{

		/** 
		 * Creates a new OMS_O01_ORDER_DETAIL Group.
		 */
		public OMS_O01_ORDER_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(RQD), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(OMS_O01_OBSERVATION), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OMS_O01_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns RQD (Requisition detail) - creates it if necessary
		 */
		public RQD RQD 
		{ 
			get
			{
				RQD ret = null;
				try 
				{
					ret = (RQD)this.get_Renamed("RQD");
				} 
				catch(HL7Exception e) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
		}

		/**
		 * Returns  first repetition of NTE (Notes and comments segment) - creates it if necessary
		 */
		public NTE getNTE() 
		{
			NTE ret = null;
			try 
			{
				ret = (NTE)this.get_Renamed("NTE");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of NTE
		 * (Notes and comments segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public NTE getNTE(int rep) 
		{ 
			return (NTE)this.get_Renamed("NTE", rep);
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
					reps = this.getAll("NTE").Length; 
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

		/**
		 * Returns  first repetition of OMS_O01_OBSERVATION (a Group object) - creates it if necessary
		 */
		public OMS_O01_OBSERVATION getOBSERVATION() 
		{
			OMS_O01_OBSERVATION ret = null;
			try 
			{
				ret = (OMS_O01_OBSERVATION)this.get_Renamed("OBSERVATION");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of OMS_O01_OBSERVATION
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public OMS_O01_OBSERVATION getOBSERVATION(int rep) 
		{ 
			return (OMS_O01_OBSERVATION)this.get_Renamed("OBSERVATION", rep);
		}

		/** 
		 * Returns the number of existing repetitions of OMS_O01_OBSERVATION 
		 */ 
		public int OBSERVATIONReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("OBSERVATION").Length; 
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
