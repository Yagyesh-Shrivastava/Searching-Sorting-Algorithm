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
        Console.WriteLine("-----------\n");
        Console.WriteLine("Sorted Array:");
        sortArray(arr);
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i] + " ");
        }

        
        Console.ReadLine();
        
    }

    //public static int[] BubbleSort(int[] arr)
    //{
    //    for(int i = 1; i<arr.Length-1; i++)
    //    {          
    //        for(int j =0; j<arr.Length-i-1; j++)
    //        {
    //            if(arr[j+1] < arr[j])
    //            {
    //                int temp = arr[i];
    //                arr[i] = arr[j];
    //                arr[j] = temp;
    //            }
    //        }
    //    }
    //    return arr;
    //}

    //Selection Sort
    //public static int[] SelectionSort(int[] arr)
    //{
    //    for(int i =0; i<arr.Length-1; i++)
    //    {
    //        int min = i;
    //        for(int j=i+1; j<arr.Length; j++)
    //        {
    //            if(arr[j] < arr[min])
    //            {
    //                min = j;
    //            }
    //        }
    //        if(min != i)
    //        {
    //            int temp = arr[i];
    //            arr[i] = arr[min];
    //            arr[min] = temp;
    //        }
    //    }
    //    return arr;
    //}


    //Quick Sort
    public static int Partition(int[] arr, int left, int right)
    {
        
        int pivot = arr[left];
        
        while(true)
        {
            while(arr[left] < pivot)
            {
                left++;
            }

            while(arr[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                int temp = arr[right];
                arr[right] = arr[left];
                arr[left] = temp;
            }
            else
                return right;
        }
    }

    static public void quickSort(int[] arr, int left, int right)
    {
        int pivot;
        if (left < right)
        {
            pivot = Partition(arr, left, right);
            if (pivot > 1)
            {
                quickSort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                quickSort(arr, pivot + 1, right);
            }
        }
    }

    static public void sortArray(int[] arr)
    {
        quickSort(arr, 0, arr.Length-1);
    }
}