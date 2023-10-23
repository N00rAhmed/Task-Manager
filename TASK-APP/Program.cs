using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace TASK_APP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.Run(new Options());
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            // Define a dictionary to map assembly names to resource names
            Dictionary<string, string> assemblyResourceMap = new Dictionary<string, string>
            {
                { "Npgsql", "TASK_APP.Npgsql.dll" },
                { "System.Threading.Tasks.Extensions", "TASK_APP.System.Threading.Tasks.Extensions.dll" },
                { "Microsoft.Bcl.AsyncInterfaces", "TASK_APP.Microsoft.Bcl.AsyncInterfaces.dll" },
                { "Microsoft.Extensions.Logging.Abstractions", "TASK_APP.Microsoft.Extensions.Logging.Abstractions.dll" },
                { "System.Memory", "TASK_APP.System.Memory.dll" },
                { "System.Runtime.CompilerServices.Unsafe", "TASK_APP.System.Runtime.CompilerServices.Unsafe.dll" },
                { "System.Runtime", "TASK_APP.System.Runtime.dll" },
                { "System.Numerics.Vectors", "TASK_APP.System.Numerics.Vectors.dll" },
                { "System.Threading.Channels", "TASK_APP.System.Threading.Channels.dll" },
                { "netstandard", "TASK_APP.netstandard.dll" },
                { "System.Threading.Tasks.Parallel", "TASK_APP.System.Threading.Tasks.Parallel.dll" },
                { "System.Threading.Tasks", "TASK_APP.System.Threading.Tasks.dll" }
/*System.Runtime.dll*/
/*System.Runtime*/
/*System.Runtime.CompilerServices.Unsafe*/
/*'System.Memory, */
/*Microsoft.Extensions.Logging.Abstractions.dll*/
                // Add other assemblies and their resource names as needed
            };

            // Get the requested assembly name
            string assemblyName = new AssemblyName(args.Name).Name;

            // Check if the assembly is in the mapping
            if (assemblyResourceMap.ContainsKey(assemblyName))
            {
                // Load the assembly from the embedded resource
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(assemblyResourceMap[assemblyName]))
                {
                    byte[] assemblyData = new byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            }

            // Return null if the assembly is not found in the mapping
            return null;
        }
    }
}
