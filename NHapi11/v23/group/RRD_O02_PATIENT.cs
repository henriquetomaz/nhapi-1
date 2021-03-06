using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RRD_O02_PATIENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RRD_O02_RESPONSE (a Group object) <b>optional </b><br>
 * 1: RRD_O02_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class RRD_O02_PATIENT : AbstractGroup 
	{

		/** 
		 * Creates a new RRD_O02_PATIENT Group.
		 */
		public RRD_O02_PATIENT(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(RRD_O02_RESPONSE), false, false);
				this.add(typeof(RRD_O02_ORDER), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRD_O02_PATIENT - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns RRD_O02_RESPONSE (a Group object) - creates it if necessary
		 */
		public RRD_O02_RESPONSE RESPONSE 
		{ 
			get
			{
				RRD_O02_RESPONSE ret = null;
				try 
				{
					ret = (RRD_O02_RESPONSE)this.get_Renamed("RESPONSE");
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
		 * Returns  first repetition of RRD_O02_ORDER (a Group object) - creates it if necessary
		 */
		public RRD_O02_ORDER getORDER() 
		{
			RRD_O02_ORDER ret = null;
			try 
			{
				ret = (RRD_O02_ORDER)this.get_Renamed("ORDER");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RRD_O02_ORDER
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RRD_O02_ORDER getORDER(int rep) 
		{ 
			return (RRD_O02_ORDER)this.get_Renamed("ORDER", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RRD_O02_ORDER 
		 */ 
		public int ORDERReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("ORDER").Length; 
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
