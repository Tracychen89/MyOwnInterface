using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            apple a1 = new apple("round", "red");
            a1.roundShape();
            
            Console.WriteLine("The color is {0}", a1.getColor());
            Console.ReadLine();
            

        }
    }

    interface fruit
    {
        bool roundShape();
        string getColor();
    }

    class apple : fruit
    {
        private string shape;
        private string color;

        public apple()
        { }

        public apple(string shape, string color)
        {
            this.shape = shape;
            this.color = color;
        }

         public bool roundShape()
        {
            if (shape == "round")
            {
                Console.WriteLine("This is a round fruit");
                return true;
            }
            else
                return false;
        }

       public string getColor()
        {
            return color;
        }



    }
}
