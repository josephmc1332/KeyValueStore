using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("With List<T>:");
            foreach (var item in Lister())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("With LinkedList:");
            foreach (var item in Link())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("With Queue:");
            foreach (var item in Que())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("With Stack:");
            foreach (var item in Stacker())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("With Dictionary:");
            foreach (var item in Dict())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("With SortedList:");
            foreach (var item in Sorter())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("With HashSet:");
            foreach (var item in Hash())
            {
                Console.WriteLine(item);
            }


        }

        //List<T>
        static List<int> Lister()
        {
            List<int> list = new List<int>(5);

            foreach (int number in new int[] { 11,22,33,44,55})
            {
                list.Add(number);
            }

            return list;
        }
        public static LinkedList<int> Link()
        {
            LinkedList<int> numbers = new LinkedList<int>();

            foreach (int number in new int[] { 11, 22, 33, 44, 55 })
            {
                numbers.AddFirst(number);               
            }
            return numbers;
        }
        public static Queue<int> Que()
        {
            Queue<int> numbers = new Queue<int>();

            foreach (int number in new int[] { 11, 22, 33, 44, 55 })
            {
                numbers.Enqueue(number);
            }
            return numbers;

        }
        public static Stack<int> Stacker()
        {
            Stack<int> numbers = new Stack<int>();
            foreach (int number in new int[] { 11, 22, 33, 44, 55 })
            {
                numbers.Push(number);
            }
            return numbers;
        }
        public static Dictionary<string, int> Dict()
        {
            Dictionary<string, int> playoff = new Dictionary<string, int>();

            playoff.Add("Alabama", 1);
            playoff.Add("Clemson", 2);
            playoff.Add("Notre Dame", 3);
            playoff.Add("LSU", 4);

            return playoff;
        }
        public static SortedList<string, int> Sorter()
        {
            SortedList<string, int> playoff = new SortedList<string, int>();

            playoff.Add("Alabama", 1);
            playoff.Add("Clemson", 2);
            playoff.Add("Notre Dame", 3);
            playoff.Add("LSU", 4);

            return playoff;
        }
        public static HashSet<int> Hash()
        {
            HashSet<int> numbers = new HashSet<int>(new int[] { 11, 22, 33, 44, 55 });

            return numbers;
        }



           

    }
}
