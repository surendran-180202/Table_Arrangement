using System;
using System.Collections.Generic;

namespace Table_Arrangement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TableArrangement tableArrangement = new TableArrangement();

            //Test case 1
            // Cyclic parent link exception
            List<Table> liTestCase1 = new List<Table>
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
            tableArrangement.ArrangeTables(liTestCase1);

            //Test case 2
            // Cyclic parent link exception
            List<Table> liTestCase2 = new List<Table>
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
            tableArrangement.ArrangeTables(liTestCase2);

            //Test case 3
            // Pass
            List<Table> liTestData3 = new List<Table>
            {
                new Table()
                {
                    TableName = "A",
                    ParentName = "F",
                },

                new Table()
                {
                    TableName = "B",
                    ParentName = "C",
                },

                new Table()
                {
                    TableName = "C",
                    ParentName = "D",
                },
                new Table()
                {
                    TableName = "D",
                },

                new Table()
                {
                    TableName = "E",
                },

                new Table()
                {
                    TableName = "F",
                },
            };
            tableArrangement.ArrangeTables(liTestData3);

            //Test case 4
            // Cyclic parent link exception
            List<Table> liTestData4 = new List<Table>
            {
                new Table()
                {
                    TableName = "A",
                    ParentName = "B",
                },

                new Table()
                {
                    TableName = "B",
                    ParentName = "C",
                },

                new Table()
                {
                    TableName = "C",
                    ParentName = "A",
                },
            };
            tableArrangement.ArrangeTables(liTestData4);

            //Test case 5
            // Pass
            List<Table> liTestData5 = new List<Table>
            {
                new Table()
                {
                    TableName = "A",
                    ParentName = "B",
                },

                new Table()
                {
                    TableName = "B",
                    ParentName = "C",
                },

                new Table()
                {
                    TableName = "C",
                },
            };
            tableArrangement.ArrangeTables(liTestData5);

            // Test case 6
            // Cyclic parent link exception
            List<Table> liTestData6 = new List<Table>
            {
                new Table()
                {
                    TableName = "A",
                    ParentName = "B",
                },

                new Table()
                {
                    TableName = "B",
                    ParentName = "A",
                },
            };
            tableArrangement.ArrangeTables(liTestData6);

            Console.ReadKey();
        }
    }
}