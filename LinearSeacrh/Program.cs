class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the Array");

        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number in Array..");

        int[] arr = new int[n];
        //inserting the array elements
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }


        //printing the array elements
        Console.WriteLine("Array Elements are:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        
        //Linear Search
        Console.WriteLine("Enter the element to search:");
        int key = Convert.ToInt32(Console.ReadLine());

        int index = LinearSearch(arr, key);
        Console.WriteLine("elment is at position: " + index);
    }

    public static int LinearSearch(int[] arr, int Key)
    {
        for(int i =0; i<arr.Length; i++)
        {
            if(arr[i] == Key)
            {
                return i;
            }
        }
        return -1;
    }

}


