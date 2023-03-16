namespace Lektion9Mars14DesignPatterns1.Visitor
{
    public interface IVisitor
    {
        // Each visitor is a function, something we want to do.
        // They are required to have a unique implementation of their
        // purpose per kind of element exists. Depending on which
        // type they visit, a different function is called.
        void Visit(AudioBook audioBook);
        void Visit(PaperBook paperBook);
    }
}