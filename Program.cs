namespace solv__assignmant_2_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "Ali", Gender.M, 5000, new HiringDate(1, 1, 2020), SecurityLevel.DBA);
            EmpArr[1] = new Employee(2, "Sara", Gender.F, 3000, new HiringDate(15, 3, 2021), SecurityLevel.Guest);
            EmpArr[2] = new Employee(3, "Omar", Gender.M, 7000, new HiringDate(20, 5, 2022), SecurityLevel.Developer); // مثلاً مسؤول الأمان

            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp);
            }

        }
    }
}
