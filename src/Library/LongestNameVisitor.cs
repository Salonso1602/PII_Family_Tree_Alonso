namespace Library
{
    public class LongestNameVisitor : Visitor
    {
        private Person longestName = new Person("p", 0);
        public Person LongestName
        {
            get
            {
                return this.longestName;
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
            if (p.Name.Length > this.LongestName.Name.Length)
            {
                longestName = p;
            }
        }
    }
}