using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OMD_O01_INSURANCE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: IN1 (IN1 - insurance segment) <b></b><br>
 * 1: IN2 (IN2 - insurance additional information segment) <b>optional </b><br>
 * 2: IN3 (IN3 - insurance additional information, certification segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class OMD_O01_INSURANCE : AbstractGroup 
	{

		/** 
		 * Creates a new OMD_O01_INSURANCE Group.
		 */
		public OMD_O01_INSURANCE(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(IN1), true, false);
				this.add(typeof(IN2), false, false);
				this.add(typeof(IN3), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OMD_O01_INSURANCE - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns IN1 (IN1 - insurance segment) - creates it if necessary
		 */
		public IN1 IN1 
		{ 
			get
			{
				IN1 ret = null;
				try 
				{
					ret = (IN1)this.get_Renamed("IN1");
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
		 * Returns IN2 (IN2 - insurance additional information segment) - creates it if necessary
		 */
		public IN2 IN2 
		{ 
			get
			{
				IN2 ret = null;
				try 
				{
					ret = (IN2)this.get_Renamed("IN2");
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
		 * Returns IN3 (IN3 - insurance additional information, certification segment) - creates it if necessary
		 */
		public IN3 IN3 
		{ 
			get
			{
				IN3 ret = null;
				try 
				{
					ret = (IN3)this.get_Renamed("IN3");
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
