using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XValidationEngine.Framework
{
    public class ValidationRule
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsValid { get; set; }

        public XInformation XInformation { get; set; }
        public ValidationRule()
        {
            IsValid = true;
        }
    }
}
