using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XValidationEngine.Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ValidationEngineTypeAttribute : Attribute
    {
        public Type ValidationType { get; set; }


        public ValidationEngineTypeAttribute()
            : base()
        {

        }
        
    }
}
