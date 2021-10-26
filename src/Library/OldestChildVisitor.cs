namespace Library
{
    public class OldestChildVisitor : Visitor
    {
        private Person oldestChild = new Person("p", 0);
        public Person OldestChild
        {
            get
            {
                return this.oldestChild;
            }
        }
        public override void Visit(Node n)
        {
            foreach (Node child in n.Children)
            {
                child.Accept(this);
            }  
        }
        public override void Visit(Person p)
        {
            if (p.Age > this.OldestChild.Age)
            {
                this.oldestChild = p;
            }
        }
    }
}