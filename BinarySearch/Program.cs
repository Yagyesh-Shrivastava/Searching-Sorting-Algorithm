class Program
{
    /*
     * Created by --- Yagyesh Shrivastava
     */
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the Array");
        
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number in Array..");

        int[] arr = new int[n];
        //inserting the array elements
        for(int i = 0; i < n; i++)
        {
           arr[i] = Convert.ToInt32(Console.ReadLine());
        }


        //printing the array elements
        Console.WriteLine("Array Elements are:");
        for(int i = 0; i< n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Array.Sort(arr); // Binary Search always run on SORTED ARRAY
        //Binary Search
        Console.WriteLine("Enter the element to search:");
        int key = Convert.ToInt32(Console.ReadLine());

        int index = BinarySeach(arr, key);
        Console.WriteLine("element is at position: " + index);

        
        

    }

    public static int BinarySeach(int[] arr, int key)
    {
        int low = 0;
        int high = arr.Length - 1;
        
        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (key == arr[mid])
            {
                return mid;
            }

            else if (key < arr[mid])
            {
                high = mid - 1;
                
            }

            else
            {
                low = mid + 1;
                
            }
        }
        return -1;
    }
}