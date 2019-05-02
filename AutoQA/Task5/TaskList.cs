using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoQA.Task5
{
    class TaskList
    {
        public static void ProcessTasks()
        {
            List<Task> tasks = new List<Task>();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please choose needed option:");
                Console.WriteLine();
                Console.WriteLine("1. Add a task to the list");
                Console.WriteLine("2. Calculate required time for all tasks in the list");
                Console.WriteLine("3. Show all tasks with particular priority");
                Console.WriteLine("4. Show tasks which you can complete by particular amount of time");
                Console.WriteLine("5. Exit");

                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    switch (value)
                    {
                        case 1:
                            AddTaskToList(tasks);
                            break;
                        case 2:
                            CalculateTimeForAllTasks(tasks);
                            break;
                        case 3:
                            TasksWithPriority(tasks);
                            break;
                        case 4:
                            TasksForTimeRange(tasks);
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Entered option does not exist, please, try again");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("The value is incorrect, please, try again");
                }
            }
        }

        private static void AddTaskToList(List<Task> tasks)
        {
            Console.Write("Please, enter the task description: ");
            string description = Console.ReadLine();

            Priority priority = InitPriority();
            Complexity complexity = InitComplexity();

            Task task = new Task(description, priority, complexity);
            tasks.Add(task);

            Console.WriteLine("The task is added to the list");
        }

        private static void CalculateTimeForAllTasks(List<Task> tasks)
        {
            CheckTasksExist(tasks);
          
            int timeForAllTasks = tasks.Select(t => t.Time).Sum();

            Console.WriteLine($"{timeForAllTasks} hour(s) is required to do all tasks from the list");
        }

        private static void TasksWithPriority(List<Task> tasks)
        {
            Console.WriteLine("Enter priority value to check how many such tasks do you have");
            Priority definedPriority = InitPriority();

            CheckTasksExist(tasks);

            List<Task> tasksByPriority = tasks.Where(task => definedPriority.Equals(task.Priority)).ToList();

            if (tasksByPriority.Count != 0)
            {
                Console.WriteLine($"You have {tasksByPriority.Count} task(s) with {definedPriority} priority:");
                PrintTaskList(tasksByPriority);
            }
            else
            {
                Console.WriteLine("You do not have tasks with such priority");
            }
        }

        private static void TasksForTimeRange(List<Task> tasks)
        { 

            Console.Write("Please, enter number of days: ");
            int days;
            while (!int.TryParse(Console.ReadLine(), out days))
            {
                Console.WriteLine("The value is incorrect, please, try again");
            }

            Console.Write("Please, enter number of hours per day: ");
            int hoursPerDay;
            while (!int.TryParse(Console.ReadLine(), out hoursPerDay) || hoursPerDay > 24)
            {
                Console.WriteLine("The value is incorrect, please, try again");
            }

            int timeRange = days * hoursPerDay;

            CheckTasksExist(tasks);

            var sortedTasks = tasks.OrderBy(task => task.Priority)
                                .ThenBy(task => task.Complexity)
                                .ToList();

            List<Task> tasksForRange = new List<Task>();
            int timeForTasks = 0;

            foreach (Task task in sortedTasks)
            {
                if ((task.Time + timeForTasks) <= timeRange)
                {
                    tasksForRange.Add(task);
                    timeForTasks += task.Time;

                    if (timeForTasks == timeRange)
                    {
                        break;
                    }
                }
            }

            PrintTaskList(tasksForRange);
        }

        private static void CheckTasksExist(List<Task> tasks) {
            if (tasks.Count <= 0)
            {
                Console.WriteLine("You do not have tasks in your list.");
                Console.WriteLine("Do you want to fill task list with test data?");
                Console.WriteLine();

                string[] confirmationStr = new string[2];

                confirmationStr[0] = ("Yes");
                confirmationStr[1] = ("No");

                while (true)
                {
                    for (int i = 0; i < confirmationStr.Length; i++)
                    {
                        Console.WriteLine("Please choose {0} to select {1}", i + 1, confirmationStr[i]);
                    }

                    int complexityOption;

                    if (int.TryParse(Console.ReadLine(), out (complexityOption)))
                    {
                        switch (complexityOption)
                        {
                            case 1:
                                FillTaskListWithTestData(tasks);
                                return;
                            case 2:
                                return;
                            default:
                                Console.WriteLine($"The value {complexityOption} is out of range, please, try again");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The value is incorrect, please, try again");
                    }
                }
            }
        }

        private static void PrintTaskList(List<Task> tasks)
        {
            if (tasks.Count != 0)
            {
                int taskNumber = 0;
                foreach (Task task in tasks)
                {
                    Console.WriteLine($"{++taskNumber}.");
                    Console.WriteLine($"Task description: {task.Description}");
                    Console.WriteLine($"Task priority: {task.Priority}");
                    Console.WriteLine($"Task complexity: {task.Complexity}");
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("You do not have tasks in the list or defined period of time is not enough");
        }

        private static Priority InitPriority()
        {
            string[] priorityStr = new string[3];

            priorityStr[0] = (Priority.High.ToString());
            priorityStr[1] = (Priority.Medium.ToString());
            priorityStr[2] = (Priority.Low.ToString());

            while (true)
            {
                for (int i = 0; i < priorityStr.Length; i++)
                {
                    Console.WriteLine("Please enter {0} to select {1} task priority", i + 1, priorityStr[i]);
                }

                int priorityOption;

                if (int.TryParse(Console.ReadLine(), out priorityOption))
                {
                    switch (priorityOption)
                    {
                        case 1:
                            return Priority.High;
                        case 2:
                            return Priority.Medium;
                        case 3:
                            return Priority.Low;
                        default:
                            Console.WriteLine($"The value {priorityOption} is out of range, please, try again");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("The value is incorrect, please, try again");
                }
            }
        }
        private static Complexity InitComplexity()
        {
            string[] complexityStr = new string[3];

            complexityStr[0] = (Complexity.Hard.ToString());
            complexityStr[1] = (Complexity.Medium.ToString());
            complexityStr[2] = (Complexity.Easy.ToString());
            while (true)
            {
                for (int i = 0; i < complexityStr.Length; i++)
                {
                    Console.WriteLine("Please enter {0} to select {1} task complexity", i + 1, complexityStr[i]);
                }

                int complexityOption;

                if (int.TryParse(Console.ReadLine(), out complexityOption))
                {
                    switch (complexityOption)
                    {
                        case 1:
                            return Complexity.Hard;
                        case 2:
                            return Complexity.Medium;
                        case 3:
                            return Complexity.Easy;
                        default:
                            Console.WriteLine($"The value {complexityOption} is out of range, please, try again");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("The value is incorrect, please, try again");
                }
            }
        }

        private static void FillTaskListWithTestData(List<Task> tasks)
        {
            for (int i = 0; i <= 30; i++) {
                tasks.Add(new Task("Task" + i, RandomEnumValue<Priority>(), RandomEnumValue<Complexity>()));
            }
        }

        private static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(new Random().Next(v.Length));
        }
    }
}
