using System.Collections;
using System.Threading.Channels;

namespace S2
{
    internal class Program
    {
        
        public static int NumberOfTimesGreaterThanTheNumber(int number , int[] arr)
        {
            int count = 0;
            if (arr is not null && arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > number)
                    {
                        count++;
                    }
                }
                return count;
            }
            return -1;
        }

        public static bool IsPalidrome(int[] arr)
        {
            if (arr is not null && arr.Length > 0)
            {

                int LastIndex = arr.Length - 1;
                for(int i = 0;i < arr.Length; i++)
                {
                    
                    if (arr[i] != arr[LastIndex])
                        return false;
                    LastIndex--;
                }

                return true;
            }
            return false;

        }

        public static void ReverseQueue<T>(ref Queue<T> queue)
        {
            if (queue is not null && queue.Count > 0)
            {
                Stack<T> stack = new Stack<T>();
                while (queue.Count > 0)
                {
                    stack.Push(queue.Dequeue());
                }
                while (stack.Count > 0)
                {
                    queue.Enqueue(stack.Pop());
                }
            }

        }

        public static bool IsBalanced(string str)
        {   
            
            Stack<char> stack = new Stack<char>();

            if (str is not null && str.Length > 0)
            {
                foreach (char ch in str)
                {
                    if (ch == '(' || ch == '{' || ch == '[')
                    {
                        stack.Push(ch);
                    }
                    else if (ch == ')' || ch == '}' || ch == ']')
                    {
                        if (stack.Count == 0)
                        {
                            return false;
                        }
                        char top = stack.Pop();
                        if ((ch == ')' && top != '(') || (ch == '}' && top != '{') || (ch == ']' && top != '['))
                        {
                            return false;
                        }
                    }
                }
            }
            return stack.Count == 0;
        }

        public static void RemoveDuplicatesFromArray(ref int[] arr)
        {
            if (arr is not null && arr.Length > 0)
            {

                List<int> list = new List<int>();
                foreach (int i in arr)
                {
                    if (!list.Contains(i))
                    {
                        list.Add(i);
                    }
                }

                arr = list.ToArray();

            }
        }

        public static void RemoveAllOddNumbers(ref ArrayList arrayList)
        {
            if (arrayList is not null && arrayList.Count > 0)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    int? num = (int?)arrayList[i];
                    
                    if (num % 2 != 0)
                    {
                        arrayList.Remove(num);
                        i--;
                    }
                }
            }
        }

        public static void PushInTheStack(ref Stack<int> stack, params int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
                stack.Push(i);
              
        }

        public static void FintTargetInTheStack(Stack<int> stack, int target)
        {
            int Count = 0;
            bool Flag = false;
            foreach (int i in stack)
            {
                Count++;
                if (i == target)
                {
                    Flag = true;
                    break;
                }
            }
            if (Flag)
                Console.WriteLine($"Target was found successfully and the count = {Count}");
            else
                Console.WriteLine("Target was not found");

        }

        public static Queue<int> ReverseFirstKElements(Queue<int> q, int k)
        {
            if (q == null || k > q.Count || k <= 0)
                return q;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(q.Dequeue());
            }

            while (stack.Count > 0)
            {
                q.Enqueue(stack.Pop());
            }

            int size = q.Count;
            for (int i = 0; i < size - k; i++)
            {
                q.Enqueue(q.Dequeue());
            }

            return q;
        }
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("please Enter the Size Of Array and Numbers of Queries in one line");


            //string Input = Console.ReadLine();
            //string[] StringNumbers = Input.Split(' ');

            //int.TryParse(StringNumbers[0], out int Size);
            //int.TryParse(StringNumbers[1], out int Queries);



            //Console.WriteLine("please Enter The Array in one line");
            //Input = Console.ReadLine();
            //StringNumbers = Input.Split(' ');




            //int[] arr = new int[Size];
            //for (int i = 0; i < Size; i++)
            //{
            //    int.TryParse(StringNumbers[i], out int number);
            //    arr[i] = number;
            //}


            //int[] arr02 = new int[Queries];

            //for (int i = 0; i < Queries; i++)
            //{
            //    Console.WriteLine("please Enter The Number to compare");
            //    int.TryParse(Console.ReadLine(), out int number);
            //    arr02[i] = NumberOfTimesGreaterThanTheNumber(number, arr);
            //    Console.WriteLine();
            //}

            //foreach (int i in arr02)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q2

            //Console.WriteLine("Please Enter the Size of Array");
            //int.TryParse(Console.ReadLine(), out int Size);

            //Console.WriteLine("Please Enter the Array in one line");
            //string Input = Console.ReadLine();
            //string[] StringNumbers = Input.Split(' ');

            //int[] arr = new int[Size];
            //for (int i = 0; i < Size; i++)
            //{
            //    int.TryParse(StringNumbers[i], out int number);
            //    arr[i] = number;
            //}
            //if (IsPalidrome(arr))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            #endregion

            #region Q3

            //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });

            //foreach (int i in queue)
            //    Console.WriteLine(i);

            //Console.WriteLine("After Reverse");

            //ReverseQueue<int>(ref queue);

            //foreach (int i in queue)
            //    Console.WriteLine(i);

            #endregion

            #region Q4

            //Console.WriteLine("Please Enter String of Parentheses");
            //string Input = Console.ReadLine();

            //if (IsBalanced(Input))
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced");
            //}

            #endregion

            #region Q5

            //int[] arr = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };

            //RemoveDuplicatesFromArray(ref arr);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q6

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //RemoveAllOddNumbers(ref arrayList);
            //foreach (var item in arrayList)
            //    Console.WriteLine(item);


            #endregion

            #region Q7

            //MyQueue myQueue = new MyQueue();
            //Console.WriteLine($"{myQueue.Capacity} , {myQueue.Count}"); // 0 , 0
            //myQueue.MyEnqueue(1);
            //myQueue.MyEnqueue("Apple");
            //myQueue.MyEnqueue(5.28);
            //myQueue.MyEnqueue(5.28);
            //myQueue.MyEnqueue(5.28);
            //Console.WriteLine($"{myQueue.Capacity} , {myQueue.Count}"); // 8 , 5

            //myQueue.Traverse();



            #endregion

            #region Q8

            //Stack<int> stack = new Stack<int>();
            //PushInTheStack(ref stack, 1, 2, 3, 4, 5, 6);

            //bool isParse;
            //int Num;

            //do
            //{
            //    Console.WriteLine("please Enter The Target Number :");
            //    isParse = int.TryParse(Console.ReadLine(), out Num);
            //    if(!isParse)
            //        Console.WriteLine("Invalid Input");

            //} while(!isParse);

            //FintTargetInTheStack(stack,Num);

            #endregion

            #region Q9

            //Console.WriteLine("please Enter The Size of two Arrays");
            //string[] sizesInput = Console.ReadLine().Split(',');
            //int n = int.Parse(sizesInput[0].Trim());
            //int m = int.Parse(sizesInput[1].Trim());


            //Console.WriteLine("please Enter the first array");
            //string arr1Input = Console.ReadLine().Trim('[', ']');
            //string[] arr1Parts = arr1Input.Split(',');
            //int[] arr1 = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr1[i] = int.Parse(arr1Parts[i].Trim());
            //}

            //Console.WriteLine("please Enter the second array");
            //string arr2Input = Console.ReadLine().Trim('[', ']');
            //string[] arr2Parts = arr2Input.Split(',');
            //int[] arr2 = new int[m];
            //for (int i = 0; i < m; i++)
            //{
            //    arr2[i] = int.Parse(arr2Parts[i].Trim());
            //}

            //List<int> result = new List<int>();


            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        if (arr1[i] == arr2[j])
            //        {
            //            result.Add(arr1[i]);
            //            arr2[j] = int.MinValue;
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine("the intersection");
            //Console.Write("[");
            //for (int i = 0; i < result.Count; i++)
            //{
            //    Console.Write(result[i]);
            //    if (i < result.Count - 1) Console.Write(",");
            //}
            //Console.WriteLine("]");


            #endregion

            #region Q10

            //Console.WriteLine("Please enter the array");
            //string inputArray = Console.ReadLine().Trim('[', ']');
            //string[] parts = inputArray.Split(',');
            //int n = parts.Length;
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(parts[i].Trim());
            //}

            //Console.WriteLine("Please enter the target sum:");
            //int target = int.Parse(Console.ReadLine());

            //int start = 0, currSum = 0;
            //bool found = false;
            //List<int> result = new List<int>();

            //for (int end = 0; end < n; end++)
            //{
            //    currSum += arr[end];

            //    while (currSum > target && start <= end)
            //    {
            //        currSum -= arr[start];
            //        start++;
            //    }

            //    if (currSum == target)
            //    {
            //        for (int k = start; k <= end; k++)
            //        {
            //            result.Add(arr[k]);
            //        }
            //        found = true;
            //        break;
            //    }
            //}

            //if (found)
            //{
            //    Console.Write("[");
            //    for (int i = 0; i < result.Count; i++)
            //    {
            //        Console.Write(result[i]);
            //        if (i < result.Count - 1) Console.Write(", ");
            //    }
            //    Console.WriteLine("]");
            //}
            //else
            //{
            //    Console.WriteLine("No subarray found with the given sum.");
            //}

            #endregion

            #region Q11

            //Console.WriteLine("Enter the queue");
            //string input = Console.ReadLine().Trim('[', ']');
            //string[] parts = input.Split(',');
            //Queue<int> q = new Queue<int>();
            //foreach (string s in parts)
            //{
            //    q.Enqueue(int.Parse(s.Trim()));
            //}

            //Console.WriteLine("Enter K");
            //int k = int.Parse(Console.ReadLine());

            //q = ReverseFirstKElements(q, k);

            //Console.Write("[");
            //int count = q.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    int val = q.Dequeue();
            //    Console.Write(val);
            //    if (i < count - 1) Console.Write(", ");
            //    q.Enqueue(val);
            //}
            //Console.WriteLine("]");


            #endregion

        }
    }
}
