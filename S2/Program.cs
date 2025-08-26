using System.Collections;

namespace S2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Array List

            ArrayList arrayList = new ArrayList(); // Capacity = 0 , Count = 0

            Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}");

            #region Add Elements

            arrayList.Add( 1 ); // Boxing type value => Ref Type 
                                // Add new Element using Add() , Adding At End Of The ArrayList 

            Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 4 , 1
            arrayList.AddRange(new int[] { 2, 3, 4 });

            Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 4 , 4

            arrayList.Add(5);
            Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 8 , 5

            arrayList.AddRange(new int[] { 6, 7, 8, 9 });
            Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 16 , 9

            foreach (int i in arrayList)
            {
                Console.WriteLine(i);
            }


            #endregion

            #endregion
        }
    }
}
