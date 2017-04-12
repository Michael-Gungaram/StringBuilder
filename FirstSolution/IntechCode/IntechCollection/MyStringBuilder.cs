using System;

namespace IntechCode.IntechCollection
{
    public class MyStringBuilder
    {
        char[] _chunks;
        int _capacity;
        int _chunkLength;

        const int DefaultCapacity = 16;

        public MyStringBuilder(int capacity)
        {
            _capacity = capacity;
            _chunks = new char[_capacity];
            _chunkLength = 0;
        }

        public MyStringBuilder(string value)
            : this(DefaultCapacity)
        {
            Append(value);
        }

        public int Length => _chunkLength;

        public char this[int index]
        {
            get
            {
                if (index > _capacity || index < 0) throw new IndexOutOfRangeException();
                return _chunks[index];
            }

            set
            {
                if (index > _capacity || index < 0) throw new IndexOutOfRangeException();
                _chunks[index] = value;
            }
        }

        public override string ToString()
        {
            string stringifiedChunks = String.Empty;
            for(int i = 0; i < _chunkLength; i++)
            {
                stringifiedChunks = String.Concat(stringifiedChunks, _chunks[i]);
            }
            return stringifiedChunks;
        }

        public void Append(char toAppend)
        { 
            _chunks[_chunkLength] = toAppend;
            _chunkLength++;
        }

        public void Append(string toAppend)
        {
            int i;
            for(i = _chunkLength; i < toAppend.Length; i++)
            {
                _chunks[i] = toAppend[i];
                _chunkLength++;
            }
        }

        public void Clear()
        {
            _chunkLength = 0;
            _capacity = 0;
            _chunks = null;
        }
    }
}