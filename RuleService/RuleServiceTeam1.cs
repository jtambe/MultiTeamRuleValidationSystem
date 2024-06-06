using System;
using System.Collections.Generic;
using System.Text;

namespace RuleService
{
    public interface IRuleServiceTeam1
    {
        string Rule1(MyModel model);
    }

    public partial class RuleService : IRuleServiceTeam1
    {
        public string Rule1(MyModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Name))
            {
                return "Name cannot be empty";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
