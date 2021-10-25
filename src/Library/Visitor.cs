namespace Library
{
    public abstract class Visitor
    {
        public abstract void Visit(Node n);

        public abstract void Visit(Person p);
    }
}