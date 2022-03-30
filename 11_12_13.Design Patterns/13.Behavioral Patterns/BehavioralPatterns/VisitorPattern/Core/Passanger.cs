using VisitorPattern.Abstractions;


namespace VisitorPattern.Core
{
    public class Passanger : IVisitor
    {
        public void Visit(Country countryVisit)
        {
            Console.WriteLine($"I visit {countryVisit.Name} with Capital: {countryVisit.CapitalName}");
        }

        public void Visit(Monument monumentVisit)
        {
            Console.WriteLine($"I like {monumentVisit.Title} : {monumentVisit.Description}");
        }
    }
}
