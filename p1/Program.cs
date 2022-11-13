using System;
using System.IO;
using Newtonsoft.Json;

namespace HomeWork1

{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>()))
            {

            }
            
        }
    }
}

