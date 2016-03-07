using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XValidationEngine.Framework.Attributes
{

    public abstract class ValidationAttribute : Attribute
    {
        private object _keyValue;

        public string Name { get; set; }
        public string Message { get; set; }

        public ValidationAttribute()
        {

        }
        
        public LogLevel LogLevel { get; set; }
        
        protected XInformation Information { get; set; }
        public abstract ValidationRule Validate(object value, ValidationContext context);
        
        protected virtual object GetPropertyValue(ValidationContext context, string keyIdentifier)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (keyIdentifier == null) throw new ArgumentNullException("keyIdentifier");
            PropertyInfo[] props = GetProperties(context.ObjectToValidate);
            var keyProperty = props.FirstOrDefault(x => x.Name.ToUpper() == keyIdentifier.ToUpper());
            if (keyProperty != null)
            {
                _keyValue = keyProperty.GetValue(context.ObjectToValidate);
            }
            return _keyValue;
        }

        private PropertyInfo[] GetProperties(object p)
        {
            return p.GetType().GetProperties();
        }
    }
}

