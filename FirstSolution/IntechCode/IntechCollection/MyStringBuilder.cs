using System;

namespace IntechCode.IntechCollection
{
    public class MyStringBuilder
    {
        char[] _chunks;
        int _capacity;
        int _chunkLength;

        const int DefaultCapacity = 16;

        public MyStringBuilder()
            :this(DefaultCapacity)
        {
            _chunks = new char[DefaultCapacity];
            _chunkLength = 0;
        }

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

            if (toAppend.Length > _capacity) CleanAndReallocate();
            for(i = _chunkLength; i < toAppend.Length; i++)
            {
                if (i > _capacity) CleanAndReallocate();
                _chunks[i] = toAppend[i];
                _chunkLength++;
            }
        }

        private void CleanAndReallocate()
        {
            int i;
            _capacity *= 2;
            char[] buffer = new char[_capacity];

            if(_chunks.Length > 0)
            {
                for(i = 0; i < _chunks.Length; i++) buffer[i] = _chunks[i];
                _chunks = buffer;
            }
            _chunks = buffer;
        }

        public void Clear()
        {
            _chunkLength = 0;
            _capacity = 0;
            _chunks = null;
        }
    }
}