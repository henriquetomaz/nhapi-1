using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a QBP_Q13 message structure (see chapter 5). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: QPD (Query Parameter Definition) <b></b><br>
 * 2: QBP_Q13_QBP (a Group object) <b>optional </b><br>
 * 3: RDF (Table Row Definition) <b>optional </b><br>
 * 4: RCP (Response Control Parameter) <b></b><br>
 * 5: DSC (Continuation Pointer) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
	public class QBP_Q13 : AbstractMessage  
	{

		/** 
		 * Creates a new QBP_Q13 Group with custom ModelClassFactory.
		 */
		public QBP_Q13(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new QBP_Q13 Group with DefaultModelClassFactory. 
		 */ 
		public QBP_Q13() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(QPD), true, false);
				this.add(typeof(QBP_Q13_QBP), false, false);
				this.add(typeof(RDF), false, false);
				this.add(typeof(RCP), true, false);
				this.add(typeof(DSC), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating QBP_Q13 - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MSH (Message Header) - creates it if necessary
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
		 * Returns QPD (Query Parameter Definition) - creates it if necessary
		 */
		public QPD QPD 
		{ 
			get
			{
				QPD ret = null;
				try 
				{
					ret = (QPD)this.get_Renamed("QPD");
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
		 * Returns QBP_Q13_QBP (a Group object) - creates it if necessary
		 */
		public QBP_Q13_QBP QBP 
		{ 
			get
			{
				QBP_Q13_QBP ret = null;
				try 
				{
					ret = (QBP_Q13_QBP)this.get_Renamed("QBP");
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
		 * Returns RDF (Table Row Definition) - creates it if necessary
		 */
		public RDF RDF 
		{ 
			get
			{
				RDF ret = null;
				try 
				{
					ret = (RDF)this.get_Renamed("RDF");
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
		 * Returns RCP (Response Control Parameter) - creates it if necessary
		 */
		public RCP RCP 
		{ 
			get
			{
				RCP ret = null;
				try 
				{
					ret = (RCP)this.get_Renamed("RCP");
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
		 * Returns DSC (Continuation Pointer) - creates it if necessary
		 */
		public DSC DSC 
		{ 
			get
			{
				DSC ret = null;
				try 
				{
					ret = (DSC)this.get_Renamed("DSC");
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
