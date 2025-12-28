class Enterprise
{
    public void DynamicProductPrice()
    {
        Console.WriteLine("Enter the no. of products: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter product prices(positive only): ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (arr[i] < 0)
            {
                Console.WriteLine("You entered a negative value!");
            }
        }

        int total = 0;
        foreach (int i in arr)
        {
            total += i;
        }

        double average = total / n;
        Console.WriteLine("The average price is: " + average);

        System.Array.Sort(arr);
        Console.WriteLine("Sorted Array: " + arr.ToString); 

        for (int i = 0; i < n; i++)
        {
            if (arr[i] < average)
            {
                arr[i] = 0;
            }
        }

        Array.Resize(ref arr, arr.Length + 5);
        for (int i = n; i < arr.Length; i++)
        {
            arr[i] = (int)average;
        }

        Console.WriteLine("Final Array: " + arr.ToString);
        
    }
}