using System;
using System.Collections.Generic;

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
                catch (Exception exception)
                {
                    Console.Write("cyclic parent link");
                    break;
                }
            }

            DisplaySortedTable();

            return OutputTable;
        }

        public void GetAndInsertParent(Table table, List<Table> liTables)
        {
            if (OutputTable.Contains(table)) return;
            if (RepeatedTable.Contains(table)) throw new Exception("cyclic parent link");
            
            Table parentTable = liTables.Find(row => row.TableName == table.ParentName);
            if (parentTable != null)
            {
                RepeatedTable.Add(table);
                GetAndInsertParent(parentTable, liTables);
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
        public string ParentName { get; set; }
    }
}