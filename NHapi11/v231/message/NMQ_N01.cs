using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v231.group;
using ca.uhn.hl7v2.model.v231.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a NMQ_N01 message structure (see chapter 14). This structure contains the 
 * following elements: </p>
 * 0: MSH (MSH - message header segment) <b></b><br>
 * 1: NMQ_N01_QRY_WITH_DETAIL (a Group object) <b>optional </b><br>
 * 2: NMQ_N01_CLOCK_AND_STATISTICS (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.message

{
	[Serializable]
	public class NMQ_N01 : AbstractMessage  
	{

		/** 
		 * Creates a new NMQ_N01 Group with custom ModelClassFactory.
		 */
		public NMQ_N01(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new NMQ_N01 Group with DefaultModelClassFactory. 
		 */ 
		public NMQ_N01() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(NMQ_N01_QRY_WITH_DETAIL), false, false);
				this.add(typeof(NMQ_N01_CLOCK_AND_STATISTICS), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating NMQ_N01 - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MSH (MSH - message header segment) - creates it if necessary
		 */
		public MSH MSH 
		{ 
			get
			{
				MSH ret = null;
				try 
				{
					ret = (MSH)this.get_Renamed("MSH");
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
		 * Returns NMQ_N01_QRY_WITH_DETAIL (a Group object) - creates it if necessary
		 */
		public NMQ_N01_QRY_WITH_DETAIL QRY_WITH_DETAIL 
		{ 
			get
			{
				NMQ_N01_QRY_WITH_DETAIL ret = null;
				try 
				{
					ret = (NMQ_N01_QRY_WITH_DETAIL)this.get_Renamed("QRY_WITH_DETAIL");
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
		 * Returns  first repetition of NMQ_N01_CLOCK_AND_STATISTICS (a Group object) - creates it if necessary
		 */
		public NMQ_N01_CLOCK_AND_STATISTICS getCLOCK_AND_STATISTICS() 
		{
			NMQ_N01_CLOCK_AND_STATISTICS ret = null;
			try 
			{
				ret = (NMQ_N01_CLOCK_AND_STATISTICS)this.get_Renamed("CLOCK_AND_STATISTICS");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of NMQ_N01_CLOCK_AND_STATISTICS
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public NMQ_N01_CLOCK_AND_STATISTICS getCLOCK_AND_STATISTICS(int rep) 
		{ 
			return (NMQ_N01_CLOCK_AND_STATISTICS)this.get_Renamed("CLOCK_AND_STATISTICS", rep);
		}

		/** 
		 * Returns the number of existing repetitions of NMQ_N01_CLOCK_AND_STATISTICS 
		 */ 
		public int CLOCK_AND_STATISTICSReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("CLOCK_AND_STATISTICS").Length; 
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
