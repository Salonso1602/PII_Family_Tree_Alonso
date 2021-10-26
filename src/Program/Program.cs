using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node("Elizabeth",53);
            Node n2 = new Node("Mercedes",51);
            Node n3 = new Node("Lionel",36);
            Node n4 = new Node("Rafael",19);
            Node n5 = new Node("David",23);
            Node n6 = new Node("Pablo",27);
            Node n7 = new Node("Lara",8);
            Node n8 = new Node("Isabel",3);

            n1.AddChildren(n3);
            n1.AddChildren(n5);
            n1.AddChildren(n6);

            n2.AddChildren(n3);
            n2.AddChildren(n5);
            n2.AddChildren(n6);

            n3.AddChildren(n4);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí

            AgeAdderVisitor turista = new AgeAdderVisitor();
            turista.Visit(n3);
            Console.WriteLine($"La suma de las edades de la familia {n3.Person.Name} es {turista.SumOfAllAges}");

            LongestNameVisitor turistaName = new LongestNameVisitor();
            turistaName.Visit(n1);
            Console.WriteLine($"El nombre más largo de la familia {n1.Person.Name} es {turistaName.LongestName.Name}");

            OldestChildVisitor turistaOld = new OldestChildVisitor();
            turistaOld.Visit(n2);
            Console.WriteLine($"El hijo más grande de {n2.Person.Name} es {turistaOld.OldestChild.Name}");

        }
    }
}
