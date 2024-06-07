Problem Definition
\
For a given class's object, we need to implement validation system with following conditions:
1. There will be multiple validation rules.
2. Multiple teams can add or remove rules.
3. We want to make a robust system such that teams can add or remove these validation rules without creating dependencies on each other.

\
Solution:
1. In this solution, we have used .Net and C# features
2. We have used `partial class` keyword provided by C#
3. We have used `Reflection` provided by C# .net

\
Implementation:
1. We define a sample MyModel class
2. We define `IRuleServiceTeam1` interface by Team1. Its implementation will be done in `RuleService` partial class.
3. We define `IRuleServiceTeam2` interface by Team2. Its implementation will be done in `RuleService` partial class.
4. We define `IRuleService` interface for main validations. Its implementation will be done in `RuleService` partial class.
5. Finally we will use Reflection in step 4 implementation to fetch all the interfaces for the RuleService partial class and Invoke all validation functions defined by different teams.