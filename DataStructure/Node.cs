using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class Node<T>
    {
        private T data;
        private Node<T> left, right;

        //public Node() : this(null) { }
        public Node(T data) : this(data, null, null) { }
        public Node(T data, Node<T> left, Node<T> right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        #region Public Properties
        public T Value
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public Node<T> Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }

        public Node<T> Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }
        #endregion

    }
}
