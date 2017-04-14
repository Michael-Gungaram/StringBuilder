using System;
using System.Collections.Generic;
using System.Text;

namespace IntechCode.IntechCollection
{
    interface IMyHashSet<T>
    {
        void Add(T item);

        void Clear();

        void Remove(T item);

        bool Contains(T value);
    }
}
