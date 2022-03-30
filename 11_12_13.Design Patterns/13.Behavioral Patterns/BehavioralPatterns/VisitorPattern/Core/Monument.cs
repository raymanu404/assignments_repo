using VisitorPattern.Abstractions;

namespace VisitorPattern.Core
{
    public class Monument : IVisitable
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
