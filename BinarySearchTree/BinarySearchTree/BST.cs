using System;

namespace BinarySearchTree
{
    internal class BST<TKey, TValue> where TKey : IComparable<TKey>
    {
        private Node root;
        private class Node
        {
            private TKey key;
            private TValue value;
            Node left = null, right = null;


            public Node(TKey key, TValue value)
            {
                this.key = key;
                this.value = value;
            }
            public TKey Key
            {
                get
                {
                    return key;
                }
            }
            public TValue Value
            {
                get
                {
                    return value;
                }
                set
                {
                    this.value = value;
                }
            }
            public Node Left
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
            public Node Right
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

        }

        public void Inorder()
        {
            Inorder(root);
        }

        private void Inorder(Node p)
        {
            if (p !=null)
            {
                Inorder(p.Left);

                Console.WriteLine("[{0}, {1}]", p.Key, p.Value);

                Inorder(p.Right);
            }
        }

        public void Add(TKey key, TValue value)
        {
            // root = AddRecursiv(root, key, value);
            root = AddNerecursiv(root, key, value);
        }

        private Node AddNerecursiv(Node root, TKey key, TValue value)
        {
            if (root == null)
            {
                root = new Node(key, value);
                return root;
            }

            bool inserat = false;
            Node p = root;
            while (!inserat)
            {
                if (p.Key.CompareTo(key) == 0)
                {
                    p.Value = value;
                    inserat = true;
                }
                else if (p.Key.CompareTo(key) > 0)
                {
                    if (p.Left != null)
                    {
                        p = p.Left;
                    }
                    else
                    {
                        p.Left = new Node(key, value);
                        inserat = true;
                    }
                }
                else
                {
                    if (p.Right != null)
                    {
                        p = p.Right;
                    }
                    else
                    {
                        p.Right = new Node(key, value);
                        inserat = true;
                    }
                }
                
            }

            return root;
        }

        private Node AddRecursiv(Node p, TKey key, TValue value)
        {
            if (p == null)
            {
                return new Node(key, value);
            }
            else if (p.Key.CompareTo(key) > 0)
            {
                p.Left = AddRecursiv(p.Left, key, value);
            }
            else if (p.Key.CompareTo(key) < 0)
            {
                p.Right = AddRecursiv(p.Right, key, value);
            }
            else
            {
                p.Value = value;
            }

            return p;
        }

        public TValue this[TKey index]
        {
            get
            {
                Node p = root;
                bool gasit = false;
                while (!gasit && p != null)
                {
                    if (p.Key.CompareTo(index) == 0)
                    {
                        gasit = true;
                    }
                    else if(p.Key.CompareTo(index) > 0)
                    {
                        p = p.Left;
                    }
                    else
                    {
                        p = p.Right;
                    }
                }

                if (p != null)
                {
                    return p.Value;
                }
                else
                    return default(TValue);
            }
        }
        public BST()
        {
            root = null;
        }
    }
}