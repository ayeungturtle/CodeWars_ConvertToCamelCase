using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_to_Camel_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            string test1 = "the_stealth_warrior";
            string test2 = "The-Stealth-Warrior";
            //string test = "helloworld";
            //Console.WriteLine((test[0].ToString()).ToUpper());
            //Console.ReadLine();

            Console.WriteLine(ToCamelCase(test1));
            Console.WriteLine(ToCamelCase(test2));

            Console.ReadLine();



        }
        public static string ToCamelCase(string str)
        {
            string title = str;
            while (title.Contains("-") || title.Contains("_"))
            {
                int spaceLocation = 0;
                if (title.Contains("-"))
                {
                    spaceLocation = title.IndexOf("-");
                }

                if (title.Contains("_"))
                {
                    spaceLocation = title.IndexOf("_");
                }

                title = title.Remove(spaceLocation, 1);
                title = title.Substring(0, spaceLocation) + ((title[spaceLocation].ToString()).ToUpper() + title.Substring(spaceLocation + 1));
            }



            return title;
        }
    }
}
