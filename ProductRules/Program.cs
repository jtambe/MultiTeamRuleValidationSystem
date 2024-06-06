// See https://aka.ms/new-console-template for more information
using RuleService;

Console.WriteLine("Check out rule system");

MyModel model = new MyModel()
{
    Name = "",
    Id = 0,
    Description = "TV"
};


RuleService.RuleService ruleService = new RuleService.RuleService();
var erros = ruleService.Violations(model);

foreach (var error in erros)
{
    Console.WriteLine(error);
}

Console.ReadKey();
