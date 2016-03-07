using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XValidationEngine.Framework.ValidationEngines
{
    public class DefaultValidationEngine<T> : ValidationEngineBase<T>, IValidationEngine<T>
    {
        public override void BuildRuleSet()
        {
            throw new NotImplementedException();
        }

        public List<ValidationRule> TryValidate(T Obj)
        {
            throw new NotImplementedException();
        }
    }
}
