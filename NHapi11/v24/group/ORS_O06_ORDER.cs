using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORS_O06_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: RQD (Requisition Detail) <b></b><br>
 * 2: RQ1 (Requisition Detail-1) <b>optional </b><br>
 * 3: NTE (Notes and Comments) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class ORS_O06_ORDER : AbstractGroup 
	{

		/** 
		 * Creates a new ORS_O06_ORDER Group.
		 */
		public ORS_O06_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RQD), true, false);
				this.add(typeof(RQ1), false, false);
				this.add(typeof(NTE), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORS_O06_ORDER - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns ORC (Common Order) - creates it if necessary
		 */
		public ORC ORC 
		{ 
			get
			{
				ORC ret = null;
				try 
				{
					ret = (ORC)this.get_Renamed("ORC");
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
		 * Returns RQD (Requisition Detail) - creates it if necessary
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
		 * Returns RQ1 (Requisition Detail-1) - creates it if necessary
		 */
		public RQ1 RQ1 
		{ 
			get
			{
				RQ1 ret = null;
				try 
				{
					ret = (RQ1)this.get_Renamed("RQ1");
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
		 * Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
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
		 * (Notes and Comments) - creates it if necessary
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

	}
}
