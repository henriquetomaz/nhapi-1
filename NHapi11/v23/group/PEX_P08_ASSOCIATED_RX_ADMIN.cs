using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PEX_P08_ASSOCIATED_RX_ADMIN Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RXA (Pharmacy administration segment) <b></b><br>
 * 1: RXR (Pharmacy route segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class PEX_P08_ASSOCIATED_RX_ADMIN : AbstractGroup 
	{

		/** 
		 * Creates a new PEX_P08_ASSOCIATED_RX_ADMIN Group.
		 */
		public PEX_P08_ASSOCIATED_RX_ADMIN(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(RXA), true, false);
				this.add(typeof(RXR), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PEX_P08_ASSOCIATED_RX_ADMIN - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns RXA (Pharmacy administration segment) - creates it if necessary
		 */
		public RXA RXA 
		{ 
			get
			{
				RXA ret = null;
				try 
				{
					ret = (RXA)this.get_Renamed("RXA");
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
		 * Returns RXR (Pharmacy route segment) - creates it if necessary
		 */
		public RXR RXR 
		{ 
			get
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
		}

	}
}
