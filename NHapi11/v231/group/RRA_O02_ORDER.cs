using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RRA_O02_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (ORC - common order segment) <b></b><br>
 * 1: RRA_O02_ADMINISTRATION (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class RRA_O02_ORDER : AbstractGroup 
	{

		/** 
		 * Creates a new RRA_O02_ORDER Group.
		 */
		public RRA_O02_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RRA_O02_ADMINISTRATION), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRA_O02_ORDER - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns ORC (ORC - common order segment) - creates it if necessary
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
		 * Returns RRA_O02_ADMINISTRATION (a Group object) - creates it if necessary
		 */
		public RRA_O02_ADMINISTRATION ADMINISTRATION 
		{ 
			get
			{
				RRA_O02_ADMINISTRATION ret = null;
				try 
				{
					ret = (RRA_O02_ADMINISTRATION)this.get_Renamed("ADMINISTRATION");
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
