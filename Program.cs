namespace Lab_8_OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates 5 new employee objects
            Employee e1 = new Employee(1001, "John", "male", 20000);
            Employee e2 = new Employee(1002, "Bert", "male", 25000);
            Employee e3 = new Employee(1003, "Kim", "female", 32000);
            Employee e4 = new Employee(1004, "Bruce", "male", 65000);
            Employee e5 = new Employee(1005, "Anna", "female", 70000);

            // Pushes the employee objects to a stack
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(e1);
            stack.Push(e2);
            stack.Push(e3);
            stack.Push(e4);
            stack.Push(e5);

            // Prints the properties of each employee in the stack. Returns how many are left in the stack, but never removes any objects.
            foreach (Employee e in stack)
            {
                Console.Write("Id: {0}, ", e.Id);
                Console.Write("Name: {0}, ", e.Name);
                Console.Write("Gender: {0}, ", e.Gender);
                Console.WriteLine("Salary: {0}.", e.Salary);
                Console.WriteLine($"{stack.Count()} remaining in stack");
                Console.WriteLine();
            }

            Console.WriteLine("------------------");

            Console.WriteLine();
            Console.WriteLine("Using Pop Method:");
            Console.WriteLine();
            
            // Uses the pop method to print all the employees in the stack. Removes them while printing, so stack.Count in decremented every time.
            while(stack.Count > 0)
            {
                Employee emp = stack.Pop();
                Console.Write("Id: {0} ,", emp.Id);
                Console.Write("Name: {0}, ", emp.Name);
                Console.Write("Gender: {0}, ", emp.Gender);
                Console.WriteLine("Salary: {0}.", emp.Salary);
                Console.WriteLine($"{stack.Count()} remaining in stack");
                Console.WriteLine();
            }

            Console.WriteLine("------------------");

            // Pushes the employees back into the stack
            stack.Push(e1);
            stack.Push(e2);
            stack.Push(e3);
            stack.Push(e4);
            stack.Push(e5);

            Console.WriteLine();
            Console.WriteLine("Using Peek Method");
            Console.WriteLine();

            // Uses the peek method to print the top employee in the stack. Does not remove any object.
            for (int i = 0; i < 2; i++)
            {
                Employee emp = stack.Peek();
                Console.Write("Id: {0}, ", emp.Id);
                Console.Write("Name: {0}, ", emp.Name);
                Console.Write("Gender: {0}, ", emp.Gender);
                Console.WriteLine("Salary: {0}.", emp.Salary);
                Console.WriteLine($"{stack.Count()} remaining in stack");
                Console.WriteLine();
            }

            Console.WriteLine("------------------");

            Console.WriteLine();
            Console.WriteLine("Using Contains Method");
            Console.WriteLine();

            // Uses the contains method to check if the stack contains a certain object.
            if (stack.Contains(e3))
            {
                Console.WriteLine("e3 is in the stack.");
            }
        }
    }
}