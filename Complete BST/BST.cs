using System;
using System.Collections.Generic;
using System.Text;

namespace Complete_BST
{
    public class BST<T>
    {
        BST<T> Root;
        T Value { get; }
        
        BST<T> Left { get; set; }
        BST<T> Right { get; set; }

        public int Count { get; private set; }
        BST(T val)
        {
            Value = val;
        }
        BST(BST<T> values)
        {
            Root = values;
        }
        BST(T[] values)
        {
            foreach(var val in values)
            {
                Insert(val);
            }
        }
        public BST<T> Insert(T value)
        {
            if(Root == null)
            {
                Root = new BST<T>(value);
            }
            return add(Root, value);
        }
        public BST<T> add(BST<T> curr, T value)
        {
            if (curr.Left == null)
            {
                curr.Left = new BST<T>(value);
                return curr;
            }
            if (curr.Right == null)
            {
                curr.Right = new BST<T>(value);
                return curr;
            }
            return add(curr.Left, value);
        }
    }

}
