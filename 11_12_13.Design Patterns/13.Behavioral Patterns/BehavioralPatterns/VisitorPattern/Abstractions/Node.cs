
namespace VisitorPattern.Abstractions
{
    public abstract class Node : IVisitable
    {
        public abstract void Accept(IVisitor visitor);
    }
}
