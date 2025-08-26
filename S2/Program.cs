using System.Collections;
using System.Collections.ObjectModel;
using System.Text.Json.Nodes;

namespace S2
{
    internal class Program
    {
        
        public static int SumArrayList(ArrayList arrayList)
        {
            int Sum = 0;
            //if (arrayList is not null && arrayList.Count > 0)
            if (arrayList?.Count > 0)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    Sum =  Sum + (int?)arrayList[i] ?? 0; 
                }
            }
            return Sum;

        }
        public static int SumList(List<int> List)
        {
            int Sum = 0;
            //if (arrayList is not null && arrayList.Count > 0)
            if (List?.Count > 0)
            {
                for (int i = 0; i < List.Count; i++)
                {
                    Sum =  Sum + List[i]; 
                }
            }
            return Sum;

        }
        static void Main(string[] args)
        {

            #region Array List

            //ArrayList arrayList = new ArrayList(); // Capacity = 0 , Count = 0

            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}");

            #region Add Elements

            //arrayList.Add( 1 ); // Boxing type value => Ref Type 
            // Add new Element using Add() , Adding At End Of The ArrayList 

            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 4 , 1
            //arrayList.AddRange(new int[] { 2, 3, 4 });

            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 4 , 4

            //arrayList.Add(5);
            //arrayList.Add(6);

            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 8 , 5

            ////arrayList.AddRange(new int[] { 6, 7, 8, 9 });
            ////Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 16 , 9

            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Insert Elements

            //arrayList.Insert(1,10); // boxing

            //Console.WriteLine("///////////////////");

            //foreach (int i in arrayList) // unboxing Ref Type => Value Type
            //{
            //    Console.WriteLine(i);
            //}

            ////arrayList.Insert(7, 200); // ArgumentOutOfRangeException

            //arrayList.InsertRange(2, new int[] { 20, 30 });
            //Console.WriteLine("///////////////////");
            //foreach (int i in arrayList) // unboxing Ref Type => Value Type
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region Trim
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 8 , 6
            //arrayList.TrimToSize(); // Set Capacity = Count
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 6 , 6

            //arrayList.Add(100);
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 12 , 7 
            #endregion

            #region Remove()
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 12 , 7
            //foreach (int i in arrayList) // unboxing Ref Type => Value Type , 1 , 2 ,3 ,4 , 5 ,6 ,100
            //{
            //    Console.WriteLine(i);
            //}

            //arrayList.Remove(1); // Remove First Occurrence Of Value
            //arrayList.RemoveAt(5); // Remove Element At Index
            //arrayList.RemoveRange(0, 2); // Remove Range Of Elements From Index , Count
            ////arrayList[0] = 100;
            ////Console.WriteLine(arrayList[0]);

            //Console.WriteLine("///////////////////");

            //foreach (int i in arrayList) // unboxing Ref Type => Value Type , 1 , 2 ,3 ,4 , 5 ,6 ,100
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Contains
            ////int? FirstElement = (int?)arrayList[0];

            //bool flag = arrayList.Contains(1000);
            //Console.WriteLine(flag);        

            #endregion

            #region 3 Constructors

            //arrayList = new ArrayList() { 1, 2, 3, 4, 5 };

            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 8 , 5

            //arrayList = new ArrayList(10) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 10 , 5

            //arrayList = new ArrayList(new int[] { 1, 2, 3 });
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 3 , 3





            #endregion

            //arrayList = new ArrayList(5);
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);
            //arrayList.Add("Route"); // InvalidCastException

            ////Console.WriteLine(SumArrayList(arrayList));

            //foreach (int item in arrayList)
            //    Console.WriteLine(item);



            #endregion

            #region List

            //List<int> list =  new List<int>();
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 0 , 0

            #region Add Element

            //list.Add(1);
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 4 , 1

            ////list.AddRange(new int[] { 2, 3, 4 });
            ////Console.WriteLine($"{list.Capacity} , {list.Count}"); // 4 , 4

            //list.AddRange(2, 3, 4);
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 4 , 4

            //list.AddRange(5);
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 8 , 5


            #endregion

            #region Insert
            //list.InsertRange(1, new int[] {20,30,40});


            //foreach (int item in list)
            //    Console.WriteLine(item);

            #endregion

            #region Trim
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 8 , 5

            //list.TrimExcess();

            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 5 , 5

            //list.Add(10);
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 10 , 6 
            #endregion

            #region Remove
            //Console.WriteLine($"{list.Capacity} , {list.Count}");
            //foreach (int item in list)
            //    Console.WriteLine(item);

            //Console.WriteLine("//////////////////");


            ////list.Remove(1); // Remove First Occurrence Of Value
            ////list.RemoveAt(4); // Remove Element At Index
            ////list.RemoveRange(0, 2); // Remove Range Of Elements From Index , Count


            //foreach (int item in list)
            //    Console.WriteLine(item); 
            #endregion

            #region Contains
            //int FirstElement = list[0];

            //bool flag = list.Contains(111);
            //Console.WriteLine(flag); 
            #endregion

            #region 3 Constructors

            //list = new List<int>() { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 8 , 5

            //list = new List<int>(10) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 10 , 5

            //list = new List<int>(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 5 , 5

            #endregion

            //foreach (int item in list)
            //    Console.WriteLine(item);

            //list[0] = 100;

            //Console.WriteLine(list[0]);

            //list[10] = 200; // ArgumentOutOfRangeException

            //list = new List<int>() { 1, 2, 3, 4, 5 };

            //Console.WriteLine(list.Capacity); // 5

            //list.EnsureCapacity(10);

            //Console.WriteLine(list.Capacity); // 10

            //list.EnsureCapacity(11);

            //Console.WriteLine(list.Capacity); // 20
            //Console.WriteLine(SumList(list));

            //list = new List<int>(10) { 3, 5, 1, 6, 8, 2};
            // 1, 2, 3, 5, 6, 8
            // 1 2 3            5 6 8
            //list.Add(10);
            //list.AddRange(20,30,40,50,60);

            //ReadOnlyCollection<int> ReadOnlyNumbers = list.AsReadOnly<int>();

            //ReadOnlyNumbers[0] = 100; // Not Allowed , Compile Time Error   

            //int index = list.BinarySearch(100);
            //Console.WriteLine(index);

            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 10 , 6

            //list.Clear();

            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 10 , 0


            //list = new List<int>(10) { 1, 2, 3, 4, 5 };
            //List<int> List02 = list.GetRange(0, 3);

            //foreach (int item in List02)
            //{
            //    Console.WriteLine(item);
            //}

            //int index = list.LastIndexOf(10);
            //Console.WriteLine(index);

            //int[] arr = new int[5];
            //list.CopyTo(arr);

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Linked List

            //LinkedList<int> linkedList = new LinkedList<int>();
            //LinkedListNode<int> FirstNode = linkedList.AddFirst(10);
            //LinkedListNode<int> SecondNode = linkedList.AddFirst(20);
            //LinkedListNode<int> Node = new LinkedListNode<int>(30);
            //linkedList.AddFirst(Node);

            //// prev  | Data | Next
            //// Ref() |  10  | Ref()

            ////foreach(int item in linkedList)
            ////    Console.WriteLine(item);

            //LinkedListNode<int> Node02 = new LinkedListNode<int>(100);

            //linkedList.AddAfter(SecondNode,Node02);

            //foreach (int item in linkedList)
            //    Console.WriteLine(item);

            //Console.WriteLine(linkedList.Count());

            //LinkedListNode<int>? FNode = linkedList?.First;
            //LinkedListNode<int>? LNode = linkedList?.Last;

            ////Console.WriteLine(FNode?.Value);
            ////Console.WriteLine(FNode?.ValueRef);

            ////LinkedListNode<int>? PrevNode = FNode?.Previous;
            ////Console.WriteLine(PrevNode.Value);

            //LinkedList<int>? NewList = Node.List;

            //foreach (int item in NewList)
            //    Console.WriteLine(item);



            #endregion
        }
    }
}
