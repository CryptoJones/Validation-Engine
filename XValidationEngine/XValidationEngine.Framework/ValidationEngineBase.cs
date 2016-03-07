using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XValidationEngine.Framework.Attributes;

namespace XValidationEngine.Framework
{
    public abstract class ValidationEngineBase<T>
    {
        public Dictionary<string, List<ValidationAttribute>> ValidationRules { get; set; }
        public abstract void BuildRuleSet();

        public ValidationEngineBase()
        {
            ValidationRules = new Dictionary<string, List<ValidationAttribute>>();
            BuildRuleSet();
        }
    }
}
