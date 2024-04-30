using System;
using System.Collections;

namespace CollectionsDemo
{
    internal class HastableDemo
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();

            studentTable.Add("S1", "vikram");
            studentTable.Add("S2", "arun");
            studentTable.Add("S3", "bran");
            studentTable.Add("S4", "chris");

            DisplayStudentTable(studentTable);

            string studentName = (string)studentTable["S2"];
            Console.WriteLine("Student with Id: S2 : " + studentName);

            string searchKey = "S3";   // Checking if key exists in the table
            if (studentTable.ContainsKey(searchKey))   // Checks whether given searchKey exists in the studentTable or not
            {
                Console.WriteLine($"\nStudent with Id {searchKey} Exists in the given table\n");
            }
            else
            {
                Console.WriteLine($"\nStudent with Id {searchKey} doesn't Exist in the given table\n");
            }

            string updateKey = "S3";
            if (studentTable.ContainsKey(updateKey))
            {
                UpdateStudent(studentTable, updateKey);
            }
            else
            {
                Console.WriteLine($"\nStudent with Id {updateKey} doesn't Exist in the given table\n");
            }

            string removeKey = "S2";
            if (studentTable.ContainsKey(removeKey))
            {
                RemoveStudent(studentTable, removeKey);
            }
            else
            {
                Console.WriteLine($"\nStudent with Id {updateKey} doesn't Exist in the given table\n");
            }
        }

        static void DisplayStudentTable(Hashtable studentTable)
        {
            foreach (DictionaryEntry entry in studentTable)       // DictionaryEntry is the built-in model class -- It contains properties like Key and Value
            {
                Console.WriteLine($"\nId: {entry.Key} Name: {entry.Value}\n");
            }
        }

        static void UpdateStudent(Hashtable studentTable, string updateKey)
        {
            studentTable[updateKey] = "seth";
            DisplayStudentTable(studentTable);
        }

        static void RemoveStudent(Hashtable studentTable, string removeKey)
        {
            studentTable.Remove(removeKey);
            DisplayStudentTable(studentTable);
        }
    }
}
