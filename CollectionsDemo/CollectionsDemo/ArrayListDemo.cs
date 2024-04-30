using System;
using System.Collections;

namespace CollectionsDemo
{
    internal class ProgramModal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ProgramModal(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }

    class CRUDOperations
    {
        private ArrayList programList = new ArrayList();

        public void AddProgram(int id, string name)
        {
            ProgramModal program = new ProgramModal(id, name);
            programList.Add(program);
        }

        public void DisplayPrograms()
        {
            Console.WriteLine("Programs List:");
            foreach (ProgramModal program in programList)
            {
                Console.WriteLine(program);
            }
        }

        public void UpdateProgram(int id, string newName)
        {
            foreach (ProgramModal program in programList)
            {
                if (program.Id == id)
                {
                    program.Name = newName;
                    return;
                }
            }
            Console.WriteLine($"Program with ID {id} not found.");
        }

        public void DeleteProgram(int id)
        {
            foreach (ProgramModal program in programList)
            {
                if (program.Id == id)
                {
                    programList.Remove(program);
                    return;
                }
            }
            Console.WriteLine($"Program with ID {id} not found.");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            CRUDOperations crud = new CRUDOperations();

            // Adding programs
            crud.AddProgram(1, "Program 1");
            crud.AddProgram(2, "Program 2");
            crud.AddProgram(3, "Program 3");

            // Displaying programs
            crud.DisplayPrograms();

            // Updating program
            crud.UpdateProgram(2, "Updated Program 2");
            Console.WriteLine("After update:");
            crud.DisplayPrograms();

            // Deleting program
            crud.DeleteProgram(3);
            Console.WriteLine("After delete:");
            crud.DisplayPrograms();

            Console.ReadLine();
        }
    }
}
