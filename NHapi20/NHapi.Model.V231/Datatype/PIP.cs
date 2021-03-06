using System;
using NHapi.Base.Model;
using NHapi.Base.Log;
using NHapi.Base;
using NHapi.Base.Model.Primitive;

namespace NHapi.Model.V231.Datatype
{

///<summary>
/// <p>The HL7 PIP (Privileges) data type.  Consists of the following components: </p><ol>
/// <li>privilege (CE)</li>
/// <li>privilege class (CE)</li>
/// <li>expiration date (DT)</li>
/// <li>activation date (DT)</li>
/// <li>facility (EI) (EI)</li>
/// </ol>
///</summary>
[Serializable]
public class PIP : AbstractType, IComposite{
	private IType[] data;

	///<summary>
	/// Creates a PIP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public PIP(IMessage message) : this(message, null){}

	///<summary>
	/// Creates a PIP.
	/// <param name="message">The Message to which this Type belongs</param>
	/// <param name="description">The description of this type</param>
	///</summary>
	public PIP(IMessage message, string description) : base(message, description){
		data = new IType[5];
		data[0] = new CE(message,"Privilege");
		data[1] = new CE(message,"Privilege class");
		data[2] = new DT(message,"Expiration date");
		data[3] = new DT(message,"Activation date");
		data[4] = new EI(message,"Facility (EI)");
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
	///<param name="index">The index item to get (zero based)</param>
	///<returns>The data component (as a type) at the requested number (ordinal)</returns>
	///</summary>
	public IType this[int index] { 

get{
		try { 
			return this.data[index]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + index + " doesn't exist in 5 element PIP composite"); 
		} 
	} 
	} 
	///<summary>
	/// Returns privilege (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE Privilege {
get{
	   CE ret = null;
	   try {
	      ret = (CE)this[0];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns privilege class (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE PrivilegeClass {
get{
	   CE ret = null;
	   try {
	      ret = (CE)this[1];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns expiration date (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT ExpirationDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)this[2];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns activation date (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT ActivationDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)this[3];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns facility (EI) (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public EI Facility {
get{
	   EI ret = null;
	   try {
	      ret = (EI)this[4];
	   } catch (DataTypeException e) {
	      HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}