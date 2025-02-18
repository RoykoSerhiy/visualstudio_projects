﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registry
{
    class Program
    {
        static void Main(string[] args)
        {
            int SelectItem;
            RegistryKey[] regs = new[] {
            Registry.ClassesRoot,
            Registry.CurrentUser,
            Registry.LocalMachine,
            Registry.Users,
            Registry.CurrentConfig,
            };

            do
            {
                int i = 1;
                Console.WriteLine("Choose part system registry");
                foreach(RegistryKey reg in regs)
                {
                    Console.WriteLine("{0}. {1}" ,i++,reg.Name);
                }
                Console.WriteLine("0.Exit");
                Console.Write("> ");
                SelectItem = Convert.ToInt32(Console.ReadLine()[0]) - 48;
                Console.WriteLine();
                if (SelectItem > 0 && SelectItem <= regs.GetLength(0))
                    PrintRegKeys(regs[SelectItem - 1]);
            } while (SelectItem != 0);
        }
        static void PrintRegKeys(RegistryKey rk)
        {
            string[] names = rk.GetSubKeyNames();
            Console.WriteLine("Subparts {0}:" , rk.Name);
            Console.WriteLine("------------------------------");
            foreach (string s in names)
                Console.WriteLine(s);
            Console.WriteLine("------------------------------");
        }
    }
}
 