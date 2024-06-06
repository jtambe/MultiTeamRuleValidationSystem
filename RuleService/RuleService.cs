using System;
using System.Collections.Generic;
using System.Text;

namespace RuleService
{
    public partial class RuleService
    {

        public List<string> Violations(MyModel model)
        {
            List<string> violations = new List<string>();

            var interfaces = this.GetType().GetInterfaces();

            foreach(var i in interfaces)
            {
                var methods = i.GetMethods();
                foreach(var m in methods)
                {
                    var result = m.Invoke(this, new object[] { model });
                    if(result != null && !string.IsNullOrEmpty(result.ToString()))
                    {
                        violations.Add(result.ToString());
                    }
                }
            }

            return violations;
        }


    }
}
