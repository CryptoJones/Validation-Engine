using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XValidationEngine.Framework.Attributes;
using XValidationEngine.Framework.ValidationEngines;

namespace XValidationEngine.Framework
{
    public static class ValidationEngineFactory<T> where T : class
    {
        public static IValidationEngine<T> GetEngine()
        {
            var t = typeof(T);
            var ruleEngineTypeAttr = t.GetCustomAttributes(typeof(ValidationEngineTypeAttribute), true);

            if (ruleEngineTypeAttr != null)
            {
                var ruleType = Activator.CreateInstance((ruleEngineTypeAttr[0] as ValidationEngineTypeAttribute).ValidationType);
                return ruleType as IValidationEngine<T>;
            }

            return new DefaultValidationEngine<T>();
        }
    }
}
