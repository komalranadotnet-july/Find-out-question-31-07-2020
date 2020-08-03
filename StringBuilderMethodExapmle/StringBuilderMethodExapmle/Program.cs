using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderMethodExapmle
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder("Hello World!", 50);
            for (int i = 0; i < sb.Length; i++)
                Console.Write(sb[i]);


            StringBuilder sb1 = new StringBuilder();
            sb.Append("Hello ");
            sb.AppendLine("World!");
            sb.AppendLine("Hello C#");
            Console.WriteLine(sb);
          
            
            StringBuilder sbAmout = new StringBuilder("Your total amount is ");
            sbAmout.AppendFormat("{0:C} ", 25);
            Console.WriteLine(sbAmout);

            StringBuilder sb2 = new StringBuilder("Hello World!", 50);
            sb.Remove(6, 7);


            StringBuilder sb3 = new StringBuilder("Hello World!");
            sb.Replace("World", "C#");
            Console.WriteLine(sb);


        }
    }
}
