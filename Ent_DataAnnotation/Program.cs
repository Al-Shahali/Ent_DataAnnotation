using System;
using System.IO;

namespace Ent_DataAnnotation
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDBContext appDBContext = new AppDBContext();
            Console.WriteLine("Hello World!");
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine(Path.GetFullPath(@"App_Data\BKStore.mdf"));
        }
    }
}
