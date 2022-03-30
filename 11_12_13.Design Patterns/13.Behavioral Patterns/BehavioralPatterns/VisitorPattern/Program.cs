using VisitorPattern.Abstractions;
using VisitorPattern.Core;

Passanger passanger = new Passanger();

List<IVisitable> nodes = new List<IVisitable>()
{
    new Country() { Name = "Spain", CapitalName = "Madrid"},
    new Country() { Name = "France", CapitalName = "Paris"},
    new Country() { Name = "Italy", CapitalName = "Rome"},
    new Monument(){ Title = "Eiffel Tower", Description = "Eiffel Tower "},
    new Monument(){ Title = "Colloseum", Description = "Colloseum... "},

};

nodes.ForEach(n => n.Accept(passanger));
