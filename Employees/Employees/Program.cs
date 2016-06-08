using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employee
    {
        public string FirsName { get; set; }

        public string LastName { get; set; }

        public int Rank { get; set; }

        public string Position { get; set; }
    }

    class Program
    {
        static Dictionary<string, int> PostAndRank = new Dictionary<string, int>();

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            for (int index = 0; index < N; index++)
            {
                string line = Console.ReadLine();

                string[] splitedLine = line.Split(new string[] {" - "}, StringSplitOptions.RemoveEmptyEntries);

                if (!PostAndRank.ContainsKey(splitedLine[0]))
                {
                    PostAndRank.Add(splitedLine[0], int.Parse(splitedLine[1]));
                }
                
            }

            List<Employee> Employees = new List<Employee>();

            int workers = int.Parse(Console.ReadLine());

            for (int index = 0; index < workers; index++)
            {
                string line = Console.ReadLine();

                string[] splitedLine = line.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                string[] splitedName = splitedLine[0].Split();

                Employee currentEmp = new Employee();
                currentEmp.FirsName = splitedName[0];
                currentEmp.LastName = splitedName[1];
                currentEmp.Position = splitedLine[1];
                currentEmp.Rank = PostAndRank[currentEmp.Position];

                Employees.Add(currentEmp);
            }

            var sortedWorkers = Employees.OrderByDescending(em => em.Rank).ThenBy(em => em.LastName).ThenBy(em => em.FirsName);

            foreach (var woker in sortedWorkers)
            {
                Console.WriteLine("{0} {1}", woker.FirsName, woker.LastName);
            }
        }
    }
}
