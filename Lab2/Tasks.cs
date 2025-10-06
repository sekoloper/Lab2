namespace Lab2
{
    static internal class Tasks
    {
        static public void Choose(string taskNum)
        {
            switch(taskNum)
            {
                case "0": break;
                case "1": Task1(); break;
                case "2": Task2(); break;
                case "3": Task3(); break;
                case "4": Task4(); break;
                case "5": Task5(); break;
                default: Console.WriteLine("Некорректный номер задания."); break;
            }
        }

        static private void Task1()
        {

            Time time1 = new Time(10);
            Time time2 = new Time(10000);
            Time time3 = new Time(100000);

            Console.WriteLine($"{time1.Seconds} секунд от начала суток это {time1}");
            Console.WriteLine($"{time2.Seconds} секунд от начала суток это {time2}");
            Console.WriteLine($"{time3.Seconds} секунд от начала суток это {time3}");
        }

        static private void Task2()
        {
            House house1 = new House(1);
            House house2 = new House(5);
            House house3 = new House(23);

            Console.WriteLine("Созданы следующие дома:");
            Console.WriteLine($"{house1}\n{house2}\n{house3}");
        }

        static private void Task3()
        {
            Department department = new Department("IT");
            Employee employee1 = new Employee("Петров", department);
            Employee employee2 = new Employee("Козлов", department);
            Employee employee3 = new Employee("Сидоров", department);
            department.Head = employee2;

            Console.WriteLine($"Сотрудники отдела {department}");
            for (int i = 0; i < employee1.Department.Employees.Length; i++)
            {
                Console.WriteLine(employee1.Department.Employees[i]);
            }
        }
        static private void Task4()
        {
            House house1 = new House(2);
            House house2 = new House(35);
            House house3 = new House(93);

            Console.WriteLine("Созданы следующие дома:");
            Console.WriteLine($"{house1}\n{house2}\n{house3}");

            //house1.Floors = 4; уберите комментарий, чтобы увидеть, что дому нельзя изменить колиечство этажей 
        }

        static private void Task5()
        {
            Gun gun = new Gun(3);
            for (int i = 0; i < 5; i++)
            {
                gun.Shoot();
            }
        }
    }
}
