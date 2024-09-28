using System;
using System.Collections.Generic;
using System.Reflection;

namespace LeetCode75
{
    public class EntryPoint
    {
        private static Dictionary<string,string> LeetCode75Dic = new Dictionary<string,string>
        {
            { "1768", "MergeStringsAlternately_1768" },
            { "1071", "GCDSs_1071" }
        };

        private void PrintProblems()
        {
            PrintOptions();
            Console.WriteLine("####################################################################################");
            foreach( var entry in LeetCode75Dic )
            {
                Console.WriteLine($"Problem : \n~ Key : {entry.Key} || Problem Name : {entry.Value}");
            }
            Console.WriteLine("####################################################################################");
        }

        private void PrintOptions()
        {
            Console.WriteLine("Options : \n~ If You Want to Exit, Enter X or x\n~ If You Want to Clear the Screen, Enter C or c");
        }

        public void Start()
        {
            PrintProblems();
            while( true )
            {
                Console.Write("Enter Problem Key: ");
                var input = Console.ReadLine();
                if( input.ToLower() == "x" )
                {
                    Environment.Exit(0);
                }
                else if( input.ToLower() == "c" )
                {
                    Console.Clear();
                    PrintProblems();
                }
                else if( LeetCode75Dic.ContainsKey(input) )
                {
                    var problemString = LeetCode75Dic[input];
                    try
                    {
                        // Get the current assembly
                        var assembly = Assembly.GetExecutingAssembly();

                        // Fully qualified class name (namespace + class name)
                        string ClassName = $"{problemString}";

                        // Get the type (class) from the assembly
                        var typeInfo = assembly.DefinedTypes.FirstOrDefault(obj=>obj.Name == ClassName);

                        if( typeInfo != null )
                        {
                            // Create an instance of the type (class)
                            var type = assembly.GetType(typeInfo.FullName);

                            var instance = Activator.CreateInstance(type);

                            // Invoke the "Run" method
                            type.GetMethod("Run")?.Invoke(instance,null);
                        }
                        else
                        {
                            Console.WriteLine("Problem not found.");
                        }
                    }
                    catch( Exception ex )
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }
    }
}
