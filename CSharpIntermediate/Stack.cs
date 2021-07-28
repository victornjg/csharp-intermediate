using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    partial class Program
    {
        public class Stack
        {
            private readonly List<object> _list = new List<object>();

            public void Push(object obj)
            {
                if (obj == null)
                    throw new InvalidOperationException("Provide a object that is not null.");
                _list.Add(obj);
            }

            public object Pop()
            {
                if (_list.Count <= 0)
                    throw new InvalidOperationException("There is no objects in the stack.");
                var lastIndex = _list.Count - 1;
                var lastItem = _list[lastIndex];
                _list.RemoveAt(lastIndex);
                return lastItem;
            }

            public void Clear()
            {
                _list.Clear();
            }
        }
    }
}
