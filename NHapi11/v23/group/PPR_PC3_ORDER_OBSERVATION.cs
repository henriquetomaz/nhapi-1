using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PPR_PC3_ORDER_OBSERVATION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OBX (Observation segment) <b></b><br>
 * 1: NTE (Notes and comments segment) <b>optional repeating</b><br>
 * 2: VAR (Variance) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class PPR_PC3_ORDER_OBSERVATION : AbstractGroup 
	{

		/** 
		 * Creates a new PPR_PC3_ORDER_OBSERVATION Group.
		 */
		public PPR_PC3_ORDER_OBSERVATION(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(OBX), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(VAR), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPR_PC3_ORDER_OBSERVATION - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns OBX (Observation segment) - creates it if necessary
		 */
		public OBX OBX 
		{ 
			get
			{
				OBX ret = null;
				try 
				{
					ret = (OBX)this.get_Renamed("OBX");
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
		 * Returns  first repetition of VAR (Variance) - creates it if necessary
		 */
		public VAR getVAR() 
		{
			VAR ret = null;
			try 
			{
				ret = (VAR)this.get_Renamed("VAR");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of VAR
		 * (Variance) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public VAR getVAR(int rep) 
		{ 
			return (VAR)this.get_Renamed("VAR", rep);
		}

		/** 
		 * Returns the number of existing repetitions of VAR 
		 */ 
		public int VARReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("VAR").Length; 
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
