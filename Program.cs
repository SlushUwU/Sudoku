// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {

            // Sudoku Validator
            Console.WriteLine("Enter the first row of the Sudoku");
            string row1 = Console.ReadLine();
            Console.WriteLine("Enter the second row of the Sudoku");
            string row2 = Console.ReadLine();
            Console.WriteLine("Enter the third row of the Sudoku");
            string row3 = Console.ReadLine();
            Console.WriteLine("Your entered Sudoku:");
            if (row1 == null || row2 == null || row3 == null)
            {
                Console.WriteLine("Error");
            }
            string[] split1 = row1.Split(" ");
            string[] split2 = row2.Split(" ");
            string[] split3 = row3.Split(" ");
            // Add the Strings into allRows
            // string[,,] allRows = { { {"1"}, {"2"} }, { { "2" },{ "2"} }, { { "3"},{ "3"} } };
            foreach (string i in split1)
            {
                string[,] allRows = { { i } };
                Console.WriteLine(allRows);
            }
            // Print the Sudoku
            bool validSudoku = true;
            int counter_for_all = 0;
            int counter_for_one = 0;
            // Check if all numbers in row1 are just once definied if yes print "valid Sudoku" else print "invalid Sudoku"
            /*foreach (string number in allRows)
            {
                
            }*/
        }
    }
}



/*
 
 ArrayList rowArray1 = new ArrayList();
            ArrayList rowArray2 = new ArrayList();
            ArrayList rowArray3 = new ArrayList();
            ArrayList allRows = new ArrayList();
            // Split the given arrays into single numbers where each number is a string
            string[] row1Array = row1.Split(" ");
            string[] row2Array = row2.Split(" ");
            string[] row3Array = row3.Split(" ");
            // Add the single numbers to the rowArrays
            foreach (string number in row1Array)
            {
                rowArray1.Add(number);
            }
            foreach (string number in row2Array)
            {
                rowArray2.Add(number);
            }
            foreach (string number in row3Array)
            {
                rowArray3.Add(number);
            }
            // Add the rowArrays to the allRows array
            allRows.Add(rowArray1);
            allRows.Add(rowArray2);
            allRows.Add(rowArray3);
            // Show the entered Sudoku
            foreach (ArrayList row in allRows)
            {
                foreach (string number in row)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
 */