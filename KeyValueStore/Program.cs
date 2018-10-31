using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueStore
{
    public class Program
    {
        static void Main()
        {
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }
    }
    public abstract class Dam : iam
    {
        public abstract void Run();

        public virtual void Walk()
        {
            Run();
        }
    }
    interface iam
    {
        void Walk();
    }
    public class ham : Dam
    {
        public override void Run()
        {
            Console.WriteLine("");
        }
        public override void Walk()
        {
            base.Walk();
        }
    }
}
