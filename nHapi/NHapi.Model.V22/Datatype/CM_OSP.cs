using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V22.Datatype
{

///<summary>
/// <p>The HL7 CM_OSP (occurence span) data type.  Consists of the following components: </p><ol>
/// <li>occurrence span code (ID)</li>
/// <li>occurrence span start date (DT)</li>
/// <li>occurrence span stop date (DT)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_OSP : AbstractType, IComposite{
	private IType[] data;

	///<summary>
	/// Creates a CM_OSP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_OSP(IMessage message) : this(message, null){}

	///<summary>
	/// Creates a CM_OSP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_OSP(IMessage message, string description) : base(message, description){
		data = new IType[3];
		data[0] = new ID(message, 0,"Occurrence span code");
		data[1] = new DT(message,"Occurrence span start date");
		data[2] = new DT(message,"Occurrence span stop date");
	}

	///<summary>
	/// Returns an array containing the data elements.
	///</summary>
	public IType[] Components
	{ 
		get{
			return this.data; 
		}
	}

	///<summary>
	/// Returns an individual data component.
	/// @throws DataTypeException if the given element number is out of range.
	///<param name="number">The ordinal item to get</param>
	///<returns>The data component (as a type) at the requested number (ordinal)</returns>
	///<summary>
	public IType this[int index] { 

get{
		try { 
			return this.data[index]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + index + " doesn't exist in 3 element CM_OSP composite"); 
		} 
	} 
	} 
	///<summary>
	/// Returns occurrence span code (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID OccurrenceSpanCode {
get{
	   ID ret = null;
	   try {
	      ret = (ID)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns occurrence span start date (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT OccurrenceSpanStartDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns occurrence span stop date (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT OccurrenceSpanStopDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}