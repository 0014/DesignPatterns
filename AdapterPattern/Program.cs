using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using AdapterPattern.Library;
using AdapterPattern.Model;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Example3();
        }

        private static void Example1()
        {
            var myRenderer = new DataRenderer(new StubDbAdapter());

            var writer = new StringWriter();
            myRenderer.Render(writer);

            Console.Write(writer.ToString());
        }

        private static void Example2()
        {
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Github\DesignPatterns\AdapterPattern\Sample.mdf;Integrated Security=True";

            var adapter = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand("Select * from Pattern")
                {
                    Connection = new SqlConnection(connectionString)
                }
            };

            var myRenderer = new DataRenderer(adapter);

            var writer = new StringWriter();
            myRenderer.Render(writer);

            Console.Write(writer.ToString());
        }

        private static void Example3()
        {
            var myRenderer = new PatternRenderer();

            var patterns = new List<Pattern>
            {
                new Pattern {Id = 1, Name = "Pattern One", Description = "Pattern One Description"},
                new Pattern {Id = 2, Name = "Pattern Two", Description = "Pattern Two Description"}
            };

            Console.Write(myRenderer.ListPatterns(patterns));
        }
    }
}
