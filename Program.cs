
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project1
{
    class Lab4
    {
        static void Main()//(string[] args)
        {
            /* LAB 1
            Console.WriteLine("Hello : ");
            Console.WriteLine("Astha Here ....");
            */
            /* LAB 2
            int a = 20, b = 10;
            Console.WriteLine(a+"+"+b+"="+(a+b));
            */
            /*LAB 3
            float n1 = 20, n2 = 10;
            Console.WriteLine(n1+"/"+n2+"="+n1 / n2);
            */

            /*  LAB 4
             Console.WriteLine(-1 + 4 * 6);
             Console.WriteLine((35 + 5) % 7);
             Console.WriteLine(14 + -4 * 6 / 11);
             Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        
            */
            /*  LAB 5
            int a = 5, b = 6;
            
            Console.WriteLine("Before swap a= "+a+" b= "+b);
            a = a * b; //5*6=30
            b = a / b; //30/6=5
            a = a / b; //30/5=6
            Console.WriteLine("After swap a= " + a + " b= " + b);
            */
            /*  LAB 6
            int n1, n2, n3;
            Console.WriteLine("Enter Number 1 = ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 = ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3 = ");
            n3 = Convert.ToInt32(Console.ReadLine());
             * 
            Console.WriteLine(n1+"*"+n2+"*"+n3 +"="+(n1*n2*n3));
            */
            /* LAB 7
            float n1, n2;
            Console.WriteLine("Enter Number 1 = ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 = ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + "+" + n2 + "=" + (n1 + n2));
            Console.WriteLine(n1 + "-" + n2 + "=" + (n1 - n2));
            Console.WriteLine(n1 + "*" + n2 + "=" + (n1 * n2));
            Console.WriteLine(n1 + "/" + n2 + "=" + (n1 / n2 ));
            Console.WriteLine(n1 + "%" + n2 + "=" + (n1 % n2));
            */
            /* LAB 8
            int n1, n;
            Console.WriteLine("Enter Number  = ");
            n1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                 
                n=n1*i;
                Console.WriteLine(n1 + "*" + i + "=" + n);
            }
            */
            /* LAB 9
            int n1, n2, n3, n4;
            Console.WriteLine("Enter Number 1 = ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 = ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3 = ");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 4 = ");
            n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Average = "+n1 +","+ n2 +"," + n3 +","+ n4 +" is " + (n1 + n2 + n3 + n4)/4);
            */
            /* LAB 10
            int x, y, z, n1, n2;
            Console.WriteLine("Enter Number 1 = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3 = ");
            z = Convert.ToInt32(Console.ReadLine());
            n1 = (x + y) * z;
            n2 = (x * y) + (y * z);
            Console.WriteLine("Result of specified numbers "+x +","+y +","+z+",  (x+y).z is " +n1 +" and x.y + y.z is " +n2);
            */
            /* LAB 11
            int x ;
            Console.WriteLine("Enter Your Age = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than " + x);
            */
            /* LAB 12
            int num;
            string s = "", ns = "";
            Console.WriteLine("Enter Number = ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                    for (int j = 0; j < 4; j++)
                     {
                            if (i == 0)
                            {
                                   s += string.Format("{0} ", num);
                            }
                            else
                            {
                                    ns += num;
                            }
                    }   
            }

            Console.WriteLine("{0}\n{1}\n{0}\n{1}", s, ns);
            Console.Read();
            */
            /* LAB 13
            int num;
            Console.WriteLine("Enter Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");
            for (int i = 0; i < 5; i++)
            {
                if (i == 0 || i == 4)
                {
                    Console.WriteLine("{0}{0}{0}", num);
                }
                else 
                {
                    Console.WriteLine("{0} {0}", num);
                }
            }
            Console.Read();
             */
            /* LAB 14
             
            int celsius;
            Console.Write("Enter the amount of Celsius: ");
            celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
            */
            /* LAB 15
            static void Main(string[] args)
            {
                Console.WriteLine(remove_char("Atmiya", 1));
                Console.WriteLine(remove_char("Atmiya University", 9));
                Console.WriteLine(remove_char("University", 0));     
            }
           public static string remove_char(string str, int n)
            {
                return str.Remove(n, 1);
            }
            */

            /* LAB 16
            string str;
            int l= 0;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }
            */

            /* LAB 17
            int n1, n2;
            Console.WriteLine("Enter Number 1 = ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 = ");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 < 0 && n2 < 0 || n1 > 0 && n2 > 0)
            {
                Console.WriteLine(" False.");
            }
            else
            {
                Console.WriteLine("True");
            }
            */

            /* LAB 18
            int a, b, c, d;
            Console.WriteLine("Enter the first integer no..");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first integer no..");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("The two integer sum is {0}", c); 
            if (a == b)
            {
                d = c * 3;
                Console.WriteLine("{0}", d);
            }
            */


            /* LAB 19
            static void Main(string[] args)
                {
                    Console.WriteLine(result(13, 40));
                    Console.WriteLine(result(50, 21));
                    Console.WriteLine(result(0, 23));
                }

                public static int result(int a, int b)
                {      
                    if (a > b)
                    {
                        return (a - b)*2;
                    }
                    return b - a;
                }
                 */

            // LAB 20
            //int a, b, c;
            //Console.WriteLine("Enter first integer no:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter first integer no:");
            //b = Convert.ToInt32(Console.ReadLine());
            //if(a==20 ||b==20 ||(a+b==20))
            //{
            //    Console.WriteLine("True");
            //}


            //  LAB 21
            //   Console.WriteLine("Input first number:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input second number:");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(IsTwenty());

            //bool IsTwenty()
            //{
            //    if (x == 20 || y == 20)
            //        return true;
            //    else if (x + y == 20)
            //        return true;
            //    else
            //        return false;
            //}

            // LAB 22
            // string a = "Write a c# sharp Program to display the following pattern using the alphabet.";
            // Console.WriteLine(a.ToLower());


            // LAB 23
            // Console.WriteLine("odd no 1 to 99");
            // for (int i = 1; i < 100;i++ )
            // {
            //     if (i % 2 != 0)
            //     {
            //         Console.WriteLine(i.ToString());
            //     }
            // }

            // LAB 23   ( or )
            //Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            //  for (int n = 1; n < (99 + 1); n++)
            //    {
            //        if (n % 2 != 0)
            //        {
            //            Console.WriteLine(n.ToString());
            //        }
            //    }

            // LAB 24
            /*public static void Main() 
            {     
                        Console.WriteLine("\nSum of the first 500 prime numbers: ");
                        long sum = 0;
                            int ctr = 0;
                            int n = 2;
                         while (ctr < 500)
                            {
                            if (isPrime(n))
                            {
                                sum += n;
                                ctr++;
                            }
                            n++;
                        }

                            Console.WriteLine(sum.ToString());
                    
                }
                public static bool isPrime(int n)
                    {
                            int x = (int)Math.Floor(Math.Sqrt(n));

                            if (n == 1) return false;
                            if (n == 2) return true;

                            for (int i = 2; i <= x; ++i)
                            {
                                if (n % i == 0) return false;
                            }

                            return true;
                    }
            */

            // LAB 25
            //int a,sum=0;
            //Console.WriteLine("Input a number integer:");
            //a = Convert.ToInt32(Console.ReadLine());
            //while(a!=0)
            //{
            //    sum = sum + a % 10;     // 0+12%10=1.2;
            //    a = a / 10;             // 12/10=1.2
            //}
            //Console.WriteLine("Sum of the digit of the said integer:{0}",sum);


            // LAB 26      
            //int num = 123;
            //int sum = 0;
            //while(num > 0)
            //{
            //  sum += number % 10;
            //  num /= 10;
            //}
            //Console.WriteLine(sum);

            // LAB 27
            //FileInfo f = new FileInfo("/home/students/abc.txt");
            //        Console.WriteLine("\nSize of a file: "+f.Length.ToString());

            // LAB 28
            /*
                    //declaring a variable and assigning hex value
                    string hex_value = "10FA";

                    //converting hex to integer
                    int int_value = Convert.ToInt32(hex_value, 16);

                    //printing the values
                    Console.WriteLine("hex_value = {0}", hex_value);
                    Console.WriteLine("int_value = {0}", int_value);

                    Console.ReadLine();
                    */

            // LAB 29
            //int[]a={1,3,-5,4};
            //int[]b={1,4,-5,-2};
            //Console.WriteLine("Array1:[{0}]",string.Join(",",a));
            //Console.WriteLine("Array2:[{0}]",string.Join(",",b));
            //for(int i=0;i<a.Length;i++)
            //{
            //    Console.Write(a[i]*b[i]+"");
            //}
            //Console.WriteLine("\n");

            //  LAB 30
            //string str;
            //Console.WriteLine("Input a sring :");
            //str = Console.ReadLine();
            //if(str.Length>4)
            //{
            //    Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
            //}

            // LAB 31
            //Console.WriteLine("Input first integer :");
            //int x = Convert.ToInt32(Console.ReadLine());
            //if (x > 0)
            //{
            //    Console.WriteLine(x % 3 == 0 || x % 7 == 0);
            //}


            // LAB 32
            //Console.WriteLine("\nInput first integer:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //if (x > 0)
            //{
            //    Console.WriteLine(x % 3 == 0 || x % 7 == 0);
            //}
            /* LAB 33   
              int n1, n2;
              Console.WriteLine("Enter Number 1 = ");
              n1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Number 2 = ");
              n2 = Convert.ToInt32(Console.ReadLine());
              if (n1 < 100 && n2 < 100 || n1 > 200 && n2 > 200)
              {
                  Console.WriteLine(" False.");
              } 
              else
              {
                  Console.WriteLine("True");
              }
              */


            // LAB 34
            //int a, b;
            //Console.WriteLine("Input a first number:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input a second number:");
            //b = Convert.ToInt32(Console.ReadLine());
            //if(a>-10 && b<10)
            //{
            //    Console.WriteLine("True");
            //}

            // LAB 35
            //string str = "PHP Tutorial";
            //Console.WriteLine((str.Substring(1,2).Equals("Hp")?str.Remove(1,2): str ));

            // LAB 36
            //Console.WriteLine("\nInput first integer:");  
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input second integer:");  
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input third integer:");  
            //int z = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Largest of three: "+Math.Max(x, Math.Max(y, z)));
            //Console.WriteLine("Lowest of three: "+Math.Min(x, Math.Min(y, z)));

            // LAB 37
            //int x,y,n = 20;
            //Console.WriteLine("Input first integer:");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input first integer:");
            //y = Convert.ToInt32(Console.ReadLine());
            //var val1 = Math.Abs(x - n);
            //var val2 = Math.Abs(y - n);
            //Console.WriteLine(val1 == val2?0 : (val1<val2 ? x:y));

            //   LAB 38
            //Console.WriteLine("\nInput an integer:");  
            //int x = Convert.ToInt32(Console.ReadLine());
            //int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
            //Console.WriteLine("Number of " + x + " present in the said array:");
            //Console.WriteLine(nums.Count(n => n == x));

            // LAB 39
            //        // Declare the array of two elements.
            //    int[][] arr = new int[2][];

            //    // Initialize the elements.
            //    arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            //    arr[1] = new int[4] { 2, 4, 6, 8 };

            //    // Display the array elements.
            //        for (int i = 0; i < arr.Length; i++)
            //        {
            //            System.Console.Write("Element({0}): ", i);

            //            for (int j = 0; j < arr[i].Length; j++)
            //            {
            //                System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
            //            }
            //            System.Console.WriteLine();
            //                }
            //        // Keep the console window open in debug mode.
            //        System.Console.WriteLine("Press any key to exit.");
            //        System.Console.ReadKey();




            // LAB 40
            //int[] nums = {1,2,2,3,3,4,5,6,5,7,7,7,8,8,1};
            //Console.WriteLine("Array1:[{0}]",string.Join(",",nums));
            //var sum = 0;
            //for (var i = 0; i < nums.Length; i++)
            //{ 
            //    sum=sum+nums[i];
            //}
            //Console.WriteLine("Sum:{0}",sum);

            // LAB 41
            //int[] nums1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            //Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums1));
            //int[] nums2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};
            //Console.WriteLine("\nArray2: [{0}]", string.Join(", ", nums2));

            //Console.WriteLine("\nCheck if the first element or the last element of the two arrays ( length 1 or more) are equal.");
            //Console.WriteLine((nums1[0].Equals(nums2[0])) || (nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])));


            // LAB 42
            //int[] nums = {1, 2, 8};
            //Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            //var temp = nums[0];
            //for (var i = 0; i < nums.Length - 1; i++)
            //{
            //    nums[i] = nums[i + 1];
            //}
            //nums[nums.Length - 1] = temp;
            //Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));

            // LAB 43

            //int[] nums = {1, 2, 5, 7,  8};
            //Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            //var h_val = nums[0];
            //for (var i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > nums[0])
            //        h_val = nums[i];
            //}
            //Console.WriteLine("\nHighest value between first and last values of the said array: {0}", h_val);


            // LAB 44
            //int[] array1 = {1, 2, 5};
            //Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array1));
            //int[] array2 = {0, 3, 8};
            //Console.WriteLine("\nArray2: [{0}]", string.Join(", ", array2));
            //int[] array3 = {-1, 0, 2};
            //Console.WriteLine("\nArray3: [{0}]", string.Join(", ", array3));
            //int[] new_array = { array1[1], array2[1], array3[1] };
            //Console.WriteLine("\nNew array: [{0}]", string.Join(", ", new_array));



            //      LAB 45
            //            for (int i = 0; i < arr_size; i++) {
            //            int count = 0;

            //            for (int j = 0; j < arr_size; j++) {
            //                if (arr[i] == arr[j])
            //                    count++;
            //            }
            //            if (count % 2 != 0)
            //                return arr[i];
            //        }
            //        return -1;
            //    }

            //    // Driver code
            //    public static void Main()
            //    {
            //        int[] arr = { 2, 3, 5, 4, 5, 2, 4, 3, 5, 2, 4, 4, 2 };
            //        int n = arr.Length;
            //        Console.Write(getOddOccurrence(arr, n));
            //    }
            //}



        }

    }
}

