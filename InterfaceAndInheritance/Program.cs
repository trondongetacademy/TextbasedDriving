using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using Microsoft.VisualBasic.CompilerServices;

namespace InterfaceAndInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var view = new Control_Panel();
            Console.WriteLine(view);
        }
        
    }
}
