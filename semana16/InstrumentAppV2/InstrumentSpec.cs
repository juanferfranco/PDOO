using System;
using System.Collections.Generic;	


namespace InstrumentAppV2
{
	public class InstrumentSpec
	{
		private Dictionary<string,object> properties = null;

		public InstrumentSpec(Dictionary<string,object> properties)	{
			this.properties = new Dictionary<string, object>(properties);
		}

		public object getProperty(string propertyName){
			object value = null;
			if(properties.TryGetValue(propertyName, out value)){
				return value;
			} else {
				return null;
			}
		}

		public Dictionary<string,object> getProperties(){
			return properties;
		}

		public virtual bool matches(InstrumentSpec otherSpec){

			Dictionary<string,object> otherProperties = otherSpec.getProperties();

			foreach (KeyValuePair<string,object> kvotherProperties in otherProperties) {
				// Verifico si yo hago match con las propiedades de otro instrumento
				if (properties.ContainsKey (kvotherProperties.Key)) {
					object propertyValue = properties[kvotherProperties.Key];
					if(kvotherProperties.Value.ToString() != propertyValue.ToString()){
						return false;
					}
				}
			}
			return true;
		}
	}
}

