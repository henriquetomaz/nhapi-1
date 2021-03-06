using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PEX_P07_RX_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RXE (RXE - pharmacy/treatment encoded order segment) <b></b><br>
 * 1: RXR (RXR - pharmacy/treatment route segment) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class PEX_P07_RX_ORDER : AbstractGroup 
	{

		/** 
		 * Creates a new PEX_P07_RX_ORDER Group.
		 */
		public PEX_P07_RX_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(RXE), true, false);
				this.add(typeof(RXR), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PEX_P07_RX_ORDER - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns RXE (RXE - pharmacy/treatment encoded order segment) - creates it if necessary
		 */
		public RXE RXE 
		{ 
			get
			{
				RXE ret = null;
				try 
				{
					ret = (RXE)this.get_Renamed("RXE");
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
		 * Returns  first repetition of RXR (RXR - pharmacy/treatment route segment) - creates it if necessary
		 */
		public RXR getRXR() 
		{
			RXR ret = null;
			try 
			{
				ret = (RXR)this.get_Renamed("RXR");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RXR
		 * (RXR - pharmacy/treatment route segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RXR getRXR(int rep) 
		{ 
			return (RXR)this.get_Renamed("RXR", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RXR 
		 */ 
		public int RXRReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("RXR").Length; 
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
