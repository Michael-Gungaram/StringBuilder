using System;
using System.Collections.Generic;
using System.Text;

namespace IntechCode.IntechCollection
{
    public class MyHashSet<T> : IMyHashSet<T>
    {
        T[] _items;
        int _count;

        const int DefaultCapacity = 16;

        public MyHashSet()
        {
            _count = 0;
            _items = new T[DefaultCapacity];
        }

        public int Count => _count;

        public bool Add(T item)
        {
            if( _count == _items.Length )
            {
                T[] newItems = new T[ _items.Length * 2 ];
                Array.Copy( _items, 0, newItems, 0, _count );
                _items = newItems;
            }
            else
            {
                _items[ _count ] = item;
            }
            ++_count;
            return true;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }
    }
}
