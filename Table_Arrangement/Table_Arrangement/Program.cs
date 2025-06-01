using System;
using System.Collections.Generic;

namespace Table_Arrangement
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TableArrangement tableArrangement = new TableArrangement();

            // Test case 1
            // Cyclic parent link exception
            List<Table> liTestCase1 = new List<Table>
            {
                new Table
                {
                    TableName = "A",
                    ParentName = new[] { "C" }
                },

                new Table
                {
                    TableName = "B",
                    ParentName = new[] { "A" }
                },

                new Table
                {
                    TableName = "C",
                    ParentName = new[] { "B" }
                },
                new Table
                {
                    TableName = "D",
                    ParentName = new[] { "E" }
                },

                new Table
                {
                    TableName = "E",
                    ParentName = new[] { "A" }
                },

                new Table
                {
                    TableName = "F"
                }
            };
            tableArrangement.ArrangeTables(liTestCase1);

            //Test case 2
            // Cyclic parent link exception
            List<Table> liTestCase2 = new List<Table>
            {
                new Table
                {
                    TableName = "A",
                    ParentName = new[] { "C" }
                },

                new Table
                {
                    TableName = "B",
                    ParentName = new[] { "A" }
                },

                new Table
                {
                    TableName = "C",
                    ParentName = new[] { "B" }
                },
                new Table
                {
                    TableName = "D",
                    ParentName = new[] { "E" }
                },

                new Table
                {
                    TableName = "E",
                    ParentName = new[] { "A" }
                }
            };
            tableArrangement.ArrangeTables(liTestCase2);

            //Test case 3
            // Pass
            List<Table> liTestData3 = new List<Table>
            {
                new Table
                {
                    TableName = "A",
                    ParentName = new[] { "F", "E" }
                },

                new Table
                {
                    TableName = "B",
                    ParentName = new[] { "C" }
                },

                new Table
                {
                    TableName = "C",
                    ParentName = new[] { "D" }
                },
                new Table
                {
                    TableName = "D"
                },

                new Table
                {
                    TableName = "E"
                },

                new Table
                {
                    TableName = "F"
                }
            };
            tableArrangement.ArrangeTables(liTestData3);

            //Test case 4
            // Cyclic parent link exception
            List<Table> liTestData4 = new List<Table>
            {
                new Table
                {
                    TableName = "A",
                    ParentName = new[] { "B" }
                },

                new Table
                {
                    TableName = "B",
                    ParentName = new[] { "C" }
                },

                new Table
                {
                    TableName = "C",
                    ParentName = new[] { "A" }
                }
            };
            tableArrangement.ArrangeTables(liTestData4);

            //Test case 5
            // Pass
            List<Table> liTestData5 = new List<Table>
            {
                new Table
                {
                    TableName = "A",
                    ParentName = new[] { "B", "D" }
                },

                new Table
                {
                    TableName = "B",
                    ParentName = new[] { "C" }
                },

                new Table
                {
                    TableName = "C"
                },

                new Table
                {
                    TableName = "D"
                }
            };
            tableArrangement.ArrangeTables(liTestData5);

            // Test case 6
            // Cyclic parent link exception
            List<Table> liTestData6 = new List<Table>
            {
                new Table
                {
                    TableName = "A",
                    ParentName = new[] { "B" }
                },

                new Table
                {
                    TableName = "B",
                    ParentName = new[] { "A" }
                }
            };
            tableArrangement.ArrangeTables(liTestData6);


            // Test case 7
            // Pass
            List<Table> liTestData7 = new List<Table>
            {
                new Table
                {
                    TableName = "A",
                    ParentName = new[] { "B", "C" }
                },

                new Table
                {
                    TableName = "B",
                    ParentName = new[] { "C" }
                },

                new Table
                {
                    TableName = "C",
                    ParentName = new[] { "D" }
                },

                new Table
                {
                    TableName = "D",
                    ParentName = new[] { "H" }
                },

                new Table
                {
                    TableName = "E",
                    ParentName = new[] { "F", "G" }
                },

                new Table
                {
                    TableName = "F",
                    ParentName = new[] { "H", "I" }
                },

                new Table
                {
                    TableName = "G"
                },

                new Table
                {
                    TableName = "H"
                },

                new Table
                {
                    TableName = "I"
                }
            };
            tableArrangement.ArrangeTables(liTestData7);

            Console.ReadKey();
        }
    }
}