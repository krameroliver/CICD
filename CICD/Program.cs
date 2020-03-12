using System;
using sun.awt;

namespace CICD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(OSInfo.getOSType());
        }
    }
}