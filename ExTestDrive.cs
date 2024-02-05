using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Exception_Magnets
{
    class ExTestDrive
    {
        public static void Zero(string test)
        {
            Console.Write("t");
            try
            {
                doRisky(test);
                Console.Write("o");
                
            }
            catch(MyException)
            {
                Console.Write("a");
            }
            finally
            {

                Console.Write("w");
                Console.Write("s");
            }
        }

        static void doRisky(string t)
        {
            Console.Write("h");
            if ("yes".Equals(t))
            {
                
                throw new MyException();
            }
            Console.Write("r");

        }
    }
}
