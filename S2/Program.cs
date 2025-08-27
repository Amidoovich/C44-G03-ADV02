using System.Collections;
using System.Threading.Channels;

namespace S2
{
    internal class Program
    {
        
        public static int NumberOfGreaterThanTheNumber(int number , int[] arr)
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
                int left = 0;
                int right = arr.Length - 1;
                while (left < right)
                {
                    if (arr[left] != arr[right])
                    {
                        return false;
                    }
                    left++;
                    right--;
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
            //    arr02[i] = NumberOfGreaterThanTheNumber(number, arr);
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






        }
    }
}
