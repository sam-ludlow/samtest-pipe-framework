using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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

			SQLiteConnection connection = new SQLiteConnection(@"Data source=C:\ao-data\mame\0280\_machine.sqlite");

			DataTable table = new DataTable();
			SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM mame", connection);

			adapter.Fill(table);

			Console.WriteLine($"Hello World! 64bit:'{Environment.Is64BitProcess}' Version: '{version}' Data test:'{(string)table.Rows[0]["build"]}'");

			Console.ReadLine();

		}
	}
}
