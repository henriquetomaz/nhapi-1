using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the SRM_S02_RESOURCES Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RGS (Resource Group) <b></b><br>
 * 1: SRM_S02_SERVICE (a Group object) <b>optional repeating</b><br>
 * 2: SRM_S02_GENERAL_RESOURCE (a Group object) <b>optional repeating</b><br>
 * 3: SRM_S02_LOCATION_RESOURCE (a Group object) <b>optional repeating</b><br>
 * 4: SRM_S02_PERSONNEL_RESOURCE (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class SRM_S02_RESOURCES : AbstractGroup 
	{

		/** 
		 * Creates a new SRM_S02_RESOURCES Group.
		 */
		public SRM_S02_RESOURCES(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(RGS), true, false);
				this.add(typeof(SRM_S02_SERVICE), false, true);
				this.add(typeof(SRM_S02_GENERAL_RESOURCE), false, true);
				this.add(typeof(SRM_S02_LOCATION_RESOURCE), false, true);
				this.add(typeof(SRM_S02_PERSONNEL_RESOURCE), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SRM_S02_RESOURCES - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns RGS (Resource Group) - creates it if necessary
		 */
		public RGS RGS 
		{ 
			get
			{
				RGS ret = null;
				try 
				{
					ret = (RGS)this.get_Renamed("RGS");
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
		 * Returns  first repetition of SRM_S02_SERVICE (a Group object) - creates it if necessary
		 */
		public SRM_S02_SERVICE getSERVICE() 
		{
			SRM_S02_SERVICE ret = null;
			try 
			{
				ret = (SRM_S02_SERVICE)this.get_Renamed("SERVICE");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of SRM_S02_SERVICE
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public SRM_S02_SERVICE getSERVICE(int rep) 
		{ 
			return (SRM_S02_SERVICE)this.get_Renamed("SERVICE", rep);
		}

		/** 
		 * Returns the number of existing repetitions of SRM_S02_SERVICE 
		 */ 
		public int SERVICEReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("SERVICE").Length; 
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
		 * Returns  first repetition of SRM_S02_GENERAL_RESOURCE (a Group object) - creates it if necessary
		 */
		public SRM_S02_GENERAL_RESOURCE getGENERAL_RESOURCE() 
		{
			SRM_S02_GENERAL_RESOURCE ret = null;
			try 
			{
				ret = (SRM_S02_GENERAL_RESOURCE)this.get_Renamed("GENERAL_RESOURCE");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of SRM_S02_GENERAL_RESOURCE
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public SRM_S02_GENERAL_RESOURCE getGENERAL_RESOURCE(int rep) 
		{ 
			return (SRM_S02_GENERAL_RESOURCE)this.get_Renamed("GENERAL_RESOURCE", rep);
		}

		/** 
		 * Returns the number of existing repetitions of SRM_S02_GENERAL_RESOURCE 
		 */ 
		public int GENERAL_RESOURCEReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("GENERAL_RESOURCE").Length; 
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
		 * Returns  first repetition of SRM_S02_LOCATION_RESOURCE (a Group object) - creates it if necessary
		 */
		public SRM_S02_LOCATION_RESOURCE getLOCATION_RESOURCE() 
		{
			SRM_S02_LOCATION_RESOURCE ret = null;
			try 
			{
				ret = (SRM_S02_LOCATION_RESOURCE)this.get_Renamed("LOCATION_RESOURCE");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of SRM_S02_LOCATION_RESOURCE
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public SRM_S02_LOCATION_RESOURCE getLOCATION_RESOURCE(int rep) 
		{ 
			return (SRM_S02_LOCATION_RESOURCE)this.get_Renamed("LOCATION_RESOURCE", rep);
		}

		/** 
		 * Returns the number of existing repetitions of SRM_S02_LOCATION_RESOURCE 
		 */ 
		public int LOCATION_RESOURCEReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("LOCATION_RESOURCE").Length; 
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
		 * Returns  first repetition of SRM_S02_PERSONNEL_RESOURCE (a Group object) - creates it if necessary
		 */
		public SRM_S02_PERSONNEL_RESOURCE getPERSONNEL_RESOURCE() 
		{
			SRM_S02_PERSONNEL_RESOURCE ret = null;
			try 
			{
				ret = (SRM_S02_PERSONNEL_RESOURCE)this.get_Renamed("PERSONNEL_RESOURCE");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of SRM_S02_PERSONNEL_RESOURCE
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public SRM_S02_PERSONNEL_RESOURCE getPERSONNEL_RESOURCE(int rep) 
		{ 
			return (SRM_S02_PERSONNEL_RESOURCE)this.get_Renamed("PERSONNEL_RESOURCE", rep);
		}

		/** 
		 * Returns the number of existing repetitions of SRM_S02_PERSONNEL_RESOURCE 
		 */ 
		public int PERSONNEL_RESOURCEReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("PERSONNEL_RESOURCE").Length; 
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
