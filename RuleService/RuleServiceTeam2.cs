using System;
using System.Collections.Generic;
using System.Text;

namespace RuleService
{
    public interface IRuleServiceTeam2
    {
        string Rule2(MyModel model);
    }

    public partial class RuleService : IRuleServiceTeam2
    {
        public string Rule2(MyModel model)
        {
            if (model.Id <= 0)
            {
                return "Id cannot be empty";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
