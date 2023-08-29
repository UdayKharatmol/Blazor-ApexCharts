using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ApexCharts
{

#pragma warning disable CS1591 // Primarily for internal use

    public class ValueOrList<T> : IList<T>
    {
        private List<T> values = new();

        public static implicit operator List<T>(ValueOrList<T> source)
        {
            return new List<T>(source);
        }

        public static explicit operator ValueOrList<T>(List<T> source)
        {
            return new ValueOrList<T>(source);
        }


        public ValueOrList()
        {}

        public ValueOrList(T value)
        {
            values.Add(value);
        }

        public ValueOrList(IEnumerable<T> list)
        {
            if (list != null)
            {
                values.AddRange(list);
            }
        }

        public T this[int index] { get => values[index]; set => values[index] = value; }

        public int Count => values.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            values.Add(item);
        }

        public void Clear()
        {
            values.Clear();
        }

        public bool Contains(T item)
        {
            return values.Contains(item) == true;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return values.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return values.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            values.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return values.Remove(item);
        }

        public void RemoveAt(int index)
        {
            values.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return values.GetEnumerator();
        }
    }
#pragma warning restore CS1591
}