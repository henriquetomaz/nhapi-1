using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V22.Datatype
{

///<summary>
/// <p>The HL7 CM_MOC (Charge To Practise) data type.  Consists of the following components: </p><ol>
/// <li>dollar amount (ST)</li>
/// <li>charge code (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_MOC : AbstractType, IComposite{
	private IType[] data;

	///<summary>
	/// Creates a CM_MOC.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_MOC(IMessage message) : this(message, null){}

	///<summary>
	/// Creates a CM_MOC.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_MOC(IMessage message, string description) : base(message, description){
		data = new IType[2];
		data[0] = new ST(message,"Dollar amount");
		data[1] = new ST(message,"Charge code");
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
			throw new DataTypeException("Element " + index + " doesn't exist in 2 element CM_MOC composite"); 
		} 
	} 
	} 
	///<summary>
	/// Returns dollar amount (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST DollarAmount {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns charge code (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST ChargeCode {
get{
	   ST ret = null;
	   try {
	      ret = (ST)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}