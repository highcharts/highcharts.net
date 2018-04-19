using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApiGenerator.XmlDoc;

namespace ApiGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Doc doc = XmlDocReader.Get(args[0]);

            foreach (var item in doc.Members.List)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
