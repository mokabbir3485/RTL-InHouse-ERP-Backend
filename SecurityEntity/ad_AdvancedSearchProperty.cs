using System;
using System.Text;

namespace SecurityEntity
{
    public class ad_AdvancedSearchProperty
	{
        public string PropertyName { get; set; }
        public bool IsAdditionalAttribute { get; set; }

        public ad_AdvancedSearchProperty()
		{ }

        public ad_AdvancedSearchProperty(string propertyName, bool isAdditionalAttribute)
		{
            this.PropertyName = propertyName;
            this.IsAdditionalAttribute = isAdditionalAttribute;
		}
	}
}
