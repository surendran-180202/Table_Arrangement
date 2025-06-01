using System;
using System.Collections.Generic;
using System.Linq;

namespace Table_Arrangement
{
    public class TableArrangement
    {
        private List<Table> OutputTable { get; set; }

        private List<Table> RepeatedTable { get; set; }

        public List<Table> ArrangeTables(List<Table> liTableInput)
        {
            OutputTable = new List<Table>();
            RepeatedTable = new List<Table>();

            foreach (Table table in liTableInput)
            {
                if(OutputTable.Count == liTableInput.Count) break;

                try
                {
                    GetAndInsertParent(table, liTableInput);
                }
                catch (Exception)
                {
                    Console.Write("cyclic parent link");
                    break;
                }
            }

            DisplaySortedTable();

            return OutputTable;
        }

        public void GetAndInsertParent(Table table, List<Table> liTable)
        {
            if (OutputTable.Contains(table)) return;
            if (RepeatedTable.Contains(table)) throw new Exception("cyclic parent link");
            
            Table[] parentTables = liTable.FindAll(row => table.ParentName != null && table.ParentName.Contains(row.TableName)).ToArray();

            foreach (Table parentTable in parentTables)
            {
                RepeatedTable.Add(table);
                GetAndInsertParent(parentTable, liTable);
            }

            OutputTable.Add(table);
        }

        public void DisplaySortedTable()
        {
            foreach (Table table in OutputTable)
            {
                Console.Write(table.TableName + " ");
            }

            Console.WriteLine();
        }
    }

    public class Table
    {
        public string TableName { get; set; }
        public string[] ParentName { get; set; }
    }
}