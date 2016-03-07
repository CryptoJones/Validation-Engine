using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XValidationEngine.Framework
{
    public interface IValidationEngine<T>
    {
        List<ValidationRule> TryValidate(T Obj);
    }
}
