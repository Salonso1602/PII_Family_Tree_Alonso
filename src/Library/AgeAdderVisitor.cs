namespace Library
{
    public class AgeAdderVisitor : Visitor
    {
        protected int sumOfAllAges = 0;
        public int SumOfAllAges 
        {
            get
            {
                return this.sumOfAllAges;
            }
        }
        public override void Visit(Node n)
        {
            n.Accept(this);
            foreach (Node child in n.Children)
            {
                this.Visit(child);
            }  
        }

        public override void Visit(Person p)
        {
            this.sumOfAllAges += p.Age;
        }
    }
}