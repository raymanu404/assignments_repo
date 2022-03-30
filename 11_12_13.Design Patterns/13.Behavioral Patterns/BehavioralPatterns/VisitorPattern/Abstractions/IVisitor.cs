using VisitorPattern.Core;

namespace VisitorPattern.Abstractions
{
    public interface IVisitor
    {
        void Visit(Country countryVisit);

        void Visit(Monument monumentVisit);
    }
}
