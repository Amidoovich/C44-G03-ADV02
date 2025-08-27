using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace S2
{
    internal class MyQueue 
    {

        #region Attributes

        private int _count; 
        const int defaultCapacity = 4;
        private object[] items;

        #endregion

        #region Proerty

        public int Count
        {
            get { return _count; }
        } 

        public int Capacity { get; set; }

        #endregion

        
        #region Constructor
        public MyQueue()
        {
            items = new object[0];
            Capacity = 0;
            _count = 0;

        }

        #endregion

        #region Methods

        public void MyEnqueue(object item)
        {
            if(items is not null)
            {
                if (_count == 0)
                {
                    items = new object[defaultCapacity];
                    Capacity = defaultCapacity;
                    items[0] = item;
                    _count++;
                }
                else if (_count == Capacity)
                {
                      
                    object[] newItems = new object[Capacity * 2];
                    
                    
                    for (int i = 0; i < _count; i++)
                    {
                        newItems[i] = items[i];
                    }
                    
                    items = newItems;
                    
                    Capacity *= 2;
                      
                    items[_count] = item;
                    _count++;
                }
                else
                {
                    items[_count] = item;
                    _count++;
                }

            }
        }

        #endregion

        #region Methods

        public void Traverse()
        {
            if(items is not null && _count > 0)
                for(int i = 0; i < _count; i++)
                    Console.WriteLine(items[i]);

        }

        #endregion
    }
}
