using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace samtest_pipe_framework
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Version assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;
			string version = $"{assemblyVersion.Major}.{assemblyVersion.Minor}";

			Console.WriteLine($"Hello World! 64bit:'{Environment.Is64BitProcess}' Version: '{version}'");


		}
	}
}
