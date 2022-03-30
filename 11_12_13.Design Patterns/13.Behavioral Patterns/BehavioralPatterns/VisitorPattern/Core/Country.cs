using VisitorPattern.Abstractions;

namespace VisitorPattern.Core
{
    public class Country : IVisitable
    {
        public string Name { get; set; } = null!;
        public string CapitalName { get; set; } = null!;
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
