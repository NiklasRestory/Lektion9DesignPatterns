namespace Lektion9Mars14DesignPatterns1.Visitor
{
    public interface IVisitor
    {
        void Visit(AudioBook audioBook);
        void Visit(PaperBook paperBook);
    }
}