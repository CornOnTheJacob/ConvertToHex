/*
 * Jacob Mousser
 * Computer Programming and Mobile App Design
 * 11/3/2022
 */
using System;
using System.Text;

namespace ConvertHex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Checked string
            string input = "hello world";

            //Run function
            string hexadecimal = ConvertToHex(input);

            //Print output
            Console.WriteLine(hexadecimal);
        }

        static string ConvertToHex(string input)
        {
            //Variable setup
            string output = "";

            //Convert to hexadecimal
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            foreach (byte b in bytes)
            {
                output += b.ToString("x") + " ";
            }

            //Return
            return output;
        }
    }
}
