using System;
using System.IO;

namespace Tools.Impersonation.Test
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            // Impersonate, automatically release the impersonation.
            using (new Impersonator("yourUsername", "yourDomain", "yourPassword"))
            {
                // The following code is executed under the impersonated user.
                string[] files = Directory.GetFiles("c:\\windows");
            }
        }
    }
}