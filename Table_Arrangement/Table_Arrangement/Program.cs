using System;
using System.Collections.Generic;

namespace Table_Arrangement
{
	internal class Program
	{
		List<Table> liRepetedTable = new List<Table>();

		static void Main(string[] args)
		{
			List<Table> liTables = new List<Table>
								   {
									   new Table()
									   {
										   TableName = "A",
										   ParentName = "C",
									   },

									   new Table()
									   {
										   TableName = "B",
										   ParentName = "A",
									   },

									   new Table()
									   {
										   TableName = "C",
										   ParentName = "B",
									   },
									   new Table()
									   {
										  TableName = "D",
										  ParentName = "E",
									   },

									   new Table()
									   {
										   TableName = "E",
										   ParentName = "A",
									   }
								   };

			Program program = new Program();
			program.ArrangeTables(liTables);

			program.DisplaySortedTable();



			List<Table> liTablesTest2S = new List<Table>
			                       {
				                       new Table()
				                       {
					                       TableName = "A",
					                       ParentName = "C",
				                       },

				                       new Table()
				                       {
					                       TableName = "B",
					                       ParentName = "A",
				                       },

				                       new Table()
				                       {
					                       TableName = "C",
					                       ParentName = "B",
				                       },
				                       new Table()
				                       {
					                       TableName = "D",
					                       ParentName = "E",
				                       },

				                       new Table()
				                       {
					                       TableName = "E",
					                       ParentName = "A",
				                       }
			                       };

			program.ArrangeTables(liTables);

			program.DisplaySortedTable();

			Console.ReadKey();
		}

		private List<Table> ArrangeTables(List<Table> liTableInput)
		{
			List<Table> liTable = new List<Table>(liTableInput);

			foreach(Table table in liTable)
			{ 
				GetAndInsertParent(table, liTable);
			}

			return liTable;
		}

		internal void GetAndInsertParent(Table table, List<Table> liTables)
		{
			if(liRepetedTable.Contains(table)) throw new Exception("cyclic parent link");

			Table parentTable = liTables.Find(row => row.TableName == table.ParentName);

			if(parentTable != null) GetAndInsertParent(parentTable, liTables);

			liRepetedTable.Add(table);
		}

		internal void DisplaySortedTable()
		{
			foreach(Table table in liRepetedTable)
			{
				Console.WriteLine(table);
			}
		}
	}

	internal class Table
	{
		internal string TableName { get; set; }
		internal string ParentName { get; set; }
	}
}
