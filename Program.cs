namespace Day14LinkedList
{
   public class Program
    {
        private static readonly Node PopLast;

        public static void Main(string[]args)
        {
            Console.WriteLine("LinkedList Problem");
            LinkedList list = new LinkedList();
            //list.Add(70);
            //list.Add(30);
            //list.Add(56);
            //list.Display();

            //list.Append(56);                              
            //list.Append(30);
            //list.Append(70);
            //list.Display();

            //UC4
            //list.Add(56);
            //list.Add(70);
            //list.InsertAtParticularPosition(2, 30);
            //list.Display();

            //UC5
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Display();
            //list.Pop();
            //list.Display();

            //UC6
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Display();
            //list.PopLast(PopLast);
            //list.Display();

            //UC7
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.SearchNode(30);
            

        }
    }
}

