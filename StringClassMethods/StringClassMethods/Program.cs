using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
          string   firstname = " STEVEN CLARK ";
          string   lastname = "Clark";

            Console.WriteLine(firstname.Contains("ven")); //Check whether specified value exists or not in string
           
            Console.WriteLine(firstname.IndexOf("e")); //Returns the first index position of specified value
           
            Console.WriteLine(firstname.ToLower()); //Covert string into lower case
         
            Console.WriteLine(lastname.ToUpper());//Convert string into Upper case
          
            Console.WriteLine(firstname.Length);//Returns the Length of String
          
            Console.WriteLine(firstname.Trim());//It removes starting and ending white spaces from string.


        }
    }
}
