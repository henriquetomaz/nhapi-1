using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PPV_PCA_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (ORC - common order segment) <b></b><br>
 * 1: PPV_PCA_ORDER_DETAIL (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class PPV_PCA_ORDER : AbstractGroup 
	{

		/** 
		 * Creates a new PPV_PCA_ORDER Group.
		 */
		public PPV_PCA_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(PPV_PCA_ORDER_DETAIL), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPV_PCA_ORDER - this is probably a bug in the source code generator.", e);
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
		 * Returns PPV_PCA_ORDER_DETAIL (a Group object) - creates it if necessary
		 */
		public PPV_PCA_ORDER_DETAIL ORDER_DETAIL 
		{ 
			get
			{
				PPV_PCA_ORDER_DETAIL ret = null;
				try 
				{
					ret = (PPV_PCA_ORDER_DETAIL)this.get_Renamed("ORDER_DETAIL");
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
