using System;

class Program
{
    static void Main(string[] args)
    {
        int largest_number = 0;
        int list_sum = 0;
        int list_size;
        List<int> user_list = new List<int>();
        int user_input;
        do {
            Console.WriteLine("Enter a list of numbers! Type 0 when finished.");
            user_input = int.Parse(Console.ReadLine());
            if (user_input != 0)
            {
                user_list.Add(user_input);
            }
        }while (user_input != 0);
        foreach (int item in user_list)
        {
            Console.WriteLine(item);
            list_sum += item;
            if (item > largest_number)
            {
                largest_number = item;
            }
        }
        list_size = user_list.Count;
        Console.WriteLine("Sum of all items in list: " + list_sum);
        Console.WriteLine("Average of all items in list: "+ (list_sum / list_size));
        Console.WriteLine("Largest item in the list: " + largest_number);

    }
}