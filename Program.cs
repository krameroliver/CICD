﻿using System;

namespace CICD
{
    internal class Program
    {
        public static void os()
        {
            string msg1 = "This is a Windows operating system.";
            string msg2 = "This is a Unix operating system.";
            string msg3 = "ERROR: This platform identifier is invalid.";

            OperatingSystem os = Environment.OSVersion;
            PlatformID pid = os.Platform;
            switch (pid)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                    Console.WriteLine(msg1);
                    break;
                case PlatformID.Unix:
                    Console.WriteLine(msg2);
                    break;
                default:
                    Console.WriteLine(msg3);
                    break;
            }
        }

        public static void Main(string[] args)
        {
            os();
            Console.WriteLine();
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}