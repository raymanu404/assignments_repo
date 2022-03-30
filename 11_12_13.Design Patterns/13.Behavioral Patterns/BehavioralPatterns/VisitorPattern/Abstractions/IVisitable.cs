
namespace VisitorPattern.Abstractions
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor); //nodul/ cel care este vizitat accepta un vizitator
    }
}
