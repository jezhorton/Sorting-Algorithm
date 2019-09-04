using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;


namespace Algorithms_assignment
{   //filePath = System.IO.Directory.GetCurrentDirectory() +


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select you one of the following options \n 1: Select which array you want to select  \n 4: Exit program");
            string userInput = Console.ReadLine();

            Arrays arrays = new Arrays();

            switch (Convert.ToInt32(userInput))
            {

                case 1:
                    pathFinder();
                    break;

                case 2:
                    //Exit program
                    Environment.Exit(0);
                    break;

            }

        }
        public static void pathFinder()

        {
            Arrays Arrays = new Arrays();
            Algorithm AlgorithmAccess = new Algorithm();
            string path = "";
            string userInput = " ";
            Console.WriteLine("Please slect an option from the following");
            Console.WriteLine("Day_1 = A1  ");
            Console.WriteLine("Month_1 = B1");
            Console.WriteLine("Year_1 = C1");
            Console.WriteLine("Time_1 = D1 ");
            Console.WriteLine("Timestamp_1 = E1");
            Console.WriteLine("Region_1 = F1");
            Console.WriteLine("Longitude_1 = G1");
            Console.WriteLine("Latitude_1 = H1");
            Console.WriteLine("Magnitude_1 =I1");
            Console.WriteLine("Depth_1 = J1");
            Console.WriteLine("IRIS_ID_1 =K1");

            userInput = Console.ReadLine(); // storing the value  
            userInput = userInput.ToUpper();
            int userChoice = 0;
            int counter = 0;
            switch (userInput)
            {
                case "A1":
                    path = @"\textFiles\Day_1.txt";
                    Arrays.specificLoad(path); 
                    AlgorithmAccess.heapSort(Arrays.Day_1, userChoice);

                    foreach (string line in Arrays.current)
                    {
                        Arrays.Day_1[counter] = Convert.ToDecimal(line);
                        ++counter;

                    }
                    Console.WriteLine(" Would you like to have the data to: \n1: Ascending \n2: Descending");
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    Arrays.Day_1 = AlgorithmAccess.heapSort(Arrays.Day_1, userChoice);
                    foreach (int num in Arrays.Day_1)
                    {
                        Console.WriteLine(num);
                    }

                    break;


                    //case "B1":
                    //   path = @"\textFiles\Month_1.txt";
                    //   Arrays.specificLoad(path); 
                    //    AlgorithmAccess.heapSort(Arrays.Month_1, userChoice);
                    //    foreach (string line in Arrays.specificLoad(path))
                    //    {
                    //        Arrays.Month_1[counter] = line;
                    //        ++counter;
                    //     }
                    //  Console.WriteLine(" Would you like to have the data to: \n1: Ascending \n2: Descending");
                    //    userChoice = Convert.ToInt32(Console.ReadLine());
                    //    break;


                case "C1":
                    path = @"\textFiles\Year_1.txt";
                    Arrays.specificLoad(path); 
                    AlgorithmAccess.heapSort(Arrays.Year_1, userChoice);
                    foreach (string line in Arrays.current)
                    {
                        Arrays.Year_1[counter] = Convert.ToDecimal(line);
                        ++counter;
                    }
                    Console.WriteLine(" Would you like to have the data to: \n1: Ascending \n2: Descending");
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    Arrays.Day_1 = AlgorithmAccess.heapSort(Arrays.Year_1, userChoice);
                    foreach (int num in Arrays.Year_1)
                    {
                        Console.WriteLine(num);
                    }
                    break;



                case "D1":
                    path = @"\textFiles\Time_1.txt";
                    Arrays.specificLoad(path); 
                    AlgorithmAccess.heapSort(Arrays.Time_1, userChoice);
                    foreach (string line in Arrays.current)
                    {
                        Arrays.Time_1[counter] = Convert.ToDecimal(line);
                        ++counter;
                    }
                    Console.WriteLine(" Would you like to have the data to: \n1: Ascending \n2: Descending");
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    break;

                    path = @"\textFiles\Timestamp_1.txt";
                    Arrays.specificLoad(path); 
                    AlgorithmAccess.heapSort(Arrays.Timestamp_1, userChoice);
                    foreach (string line in Arrays.current)
                    {
                        Arrays.Timestamp_1[counter] = Convert.ToDecimal(line);
                        ++counter;
                    }
                    Console.WriteLine(" Would you like to have the data to: \n1: Ascending \n2: Descending");
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    break;



                //case "F1":
                //    path = @"\textFiles\Region_1.txt";
                //    Arrays.specificLoad(path); // potential errors like with 'arrays
                //    AlgorithmAccess.heapSort(Arrays.Region_1, userChoice);
                //    foreach (string line in Arrays.current)
                //    {
                //        Arrays.Region_1[counter] = line;
                //        ++counter;
                //    }
                //    Console.WriteLine(" Would you like to have the data to: \n1: Ascending \n2: Descending");
                //    userChoice = Convert.ToInt32(Console.ReadLine());
                //    break;

                case "G1":
                    path = @"\textFiles\Longitude_1.txt";
                    Arrays.specificLoad(path); 
                    AlgorithmAccess.heapSort(Arrays.Longitude_1, userChoice);
                    foreach (string line in Arrays.current)
                    {
                        Arrays.Longitude_1[counter] = Convert.ToDecimal(line);
                        ++counter;
                    }
                    Console.WriteLine(" Would you like to have the data to: \n1: Ascending \n2: Descending");
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    break;


                case "H1":
                    path = @"\textFiles\Latitude_1.txt";
                    Arrays.specificLoad(path); 
                    AlgorithmAccess.heapSort(Arrays.Latitude_1, userChoice);
                    foreach (string line in Arrays.current)
                    {
                        Arrays.Latitude_1[counter] = Convert.ToDecimal(line);
                        ++counter;
                    }
                    Console.WriteLine(" Would you like to have the data to: \n1: Ascending \n2: Descending");
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    break;



                case "I1":
                    path = @"\textFiles\Magnitude_1.txt";
                    Arrays.specificLoad(path); 
                    AlgorithmAccess.heapSort(Arrays.Magnitude_1, userChoice);
                    foreach (string line in Arrays.current)
                    {
                        Arrays.Magnitude_1[counter] = Convert.ToDecimal(line);
                        ++counter;
                    }
                    Console.WriteLine(" Would you like to have the data to: \n1: Ascending \n2: Descending");
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    break;



                case "J1":
                    path = @"\textFiles\Depth_1.txt";
                    Arrays.specificLoad(path); 
                    AlgorithmAccess.heapSort(Arrays.Depth_1, userChoice);
                    foreach (string line in Arrays.current)
                    {
                        Arrays.Depth_1[counter] = Convert.ToDecimal(line);
                        ++counter;
                    }
                    Console.WriteLine(" Would you like to have the data to: \n1: Ascending \n2: Descending");
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    break;

                case "K1":
                    path = @"\textFiles\IRIS_ID_1.txt";
                    Arrays.specificLoad(path); 
                    AlgorithmAccess.heapSort(Arrays.IRIS_ID_1, userChoice);
                    foreach (string line in Arrays.current)
                    {
                        Arrays.IRIS_ID_1[counter] = Convert.ToDecimal(line);
                        ++counter;
                    }
                    Console.WriteLine(" Would you like to have the data to: \n1: Ascending \n2: Descending");
                    userChoice = Convert.ToInt32(Console.ReadLine());

                    break;



            }
            Console.ReadLine();
        }




        class Arrays
        {
            public Program filepath = new Program();


            public decimal[] Day_1 = new decimal[600];


            public string[] Month_1 = new string[600];


            public decimal[] Year_1 = new decimal[600];


            public decimal[] Time_1 = new decimal[600];


            public decimal[] Timestamp_1 = new decimal[600];


            public string[] Region_1 = new string[600];


            public decimal[] Longitude_1 = new decimal[600];


            public decimal[] Latitude_1 = new decimal[600];


            public decimal[] Magnitude_1 = new decimal[600];


            public decimal[] Depth_1 = new decimal[600];


            public decimal[] IRIS_ID_1 = new decimal[600];


            public string[] current;


            public void specificLoad(string path)
            {
                current = File.ReadAllLines(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + path);
            }

        }
        class Algorithm
        {
            public List<decimal> unsorted = new List<decimal>();
            public decimal[] heapSort(decimal[] sortThis, int choice)
            {

                for (int i = 0; i < (sortThis.Length); i++)
                {
                    unsorted.Add(sortThis[i]);
                }

                int counter = 0;

                while (unsorted.Count != 0)
                {


                    if (choice == 1)
                    {
                        sortThis[counter] = unsorted.Min();
                        unsorted.Remove(unsorted.Min());
                        counter++;
                    }
                    else
                    {
                        sortThis[counter] = unsorted.Max();
                        unsorted.Remove(unsorted.Max());
                        counter++;
                    }

                }
                return sortThis;
            }

        }
    }
}
