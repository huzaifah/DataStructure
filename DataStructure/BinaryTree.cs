using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class BinaryTree<T>
    {
        private Node<T> root;

        public BinaryTree()
        {
            root = null;
        }

        #region Public Methods
        public virtual void Clear()
        {
            root = null;
        }
        #endregion

        #region Public Properties
        public Node<T> Root
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }
        }
        #endregion
    }
}
