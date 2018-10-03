using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class BinaryTreeService
        {
            private class Node
            {
                private int number;
                public Node rightLeaf;
                public Node leftLeaf;

                public Node(int value)
                {
                    number = value;
                    rightLeaf = null;
                    leftLeaf = null;
                }

                public bool isLeaf(ref Node node)
                {
                    return (node.rightLeaf == null && node.leftLeaf == null);

                }

                public void insertData(ref Node node, int data)
                {
                    if (node == null)
                    {
                        node = new Node(data);

                    }
                    else if (node.number < data)
                    {
                        insertData(ref node.rightLeaf, data);
                    }

                    else if (node.number > data)
                    {
                        insertData(ref node.leftLeaf, data);
                    }
                }

                public bool search(Node node, int s)
                {
                    if (node == null)
                        return false;

                    if (node.number == s)
                    {
                        return true;
                    }
                    else if (node.number < s)
                    {
                        return search(node.rightLeaf, s);
                    }
                    else if (node.number > s)
                    {
                        return search(node.leftLeaf, s);
                    }

                    return false;
                }

                public void display(Node n)
                {
                    if (n == null)
                        return;

                    display(n.leftLeaf);
                    Console.Write(" " + n.number);
                    display(n.rightLeaf);
                }

            }
        }
    }
}