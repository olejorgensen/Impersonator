using System;
using System.IO;

namespace Tools.Impersonation.Test
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                // Impersonate, automatically release the impersonation.
                using (new Impersonator(args[0], args[1], args[2]))
                {
                    // The following code is executed under the impersonated user.
                    string[] files = Directory.GetFiles("c:\\windows");
                    Console.WriteLine($"There is {files.Length} files below c:\\windows");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No:");
                Console.WriteLine(ex);
            }
            Console.WriteLine("...");
            Console.ReadKey();
        }
    }
}
