using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class BinaryTreeService
        {
            public BinaryTreeService()
            {
                BinaryTree b = new BinaryTree();

                b.insert(1);
                b.insert(6);
                b.insert(2);
                b.insert(4);
                b.insert(5);
                b.insert(3);
                b.insert(12);

                b.display();

                var found = b.search(3);
                var notFound = b.search(33);

                Console.WriteLine($"found 3 : {found} didnt find 33 {notFound}");

                var rand = new Random();
                BinaryTree a = new BinaryTree();
                int i;
                for (i = 0; i < 10; i = i + 1)
                {

                    var val = rand.Next(0, 9);
                    Console.WriteLine(val.ToString());
                    a.insert(val);
                }


                a.display();

                found = a.search(3);
                notFound = a.search(33);

                Console.WriteLine($"found 3 : {found} didnt find 33 {notFound}, count: {a.Count()}");

            }
            class BinaryTree
            {
                private Node root;
                private int count;

                public BinaryTree()
                {
                    root = null;
                    count = 0;
                }



                public void DoWork()
                {
                    root = null;
                    count = 0;
                }

                public bool isEmpty()
                {
                    return root == null;
                }

                public void insert(int d)
                {
                    if (isEmpty())
                    {
                        root = new Node(d);
                    }
                    else
                    {
                        root.insertData(ref root, d);
                    }

                    count++;
                }

                public bool search(int s)
                {
                    return root.search(root, s);
                }

                public bool isLeaf()
                {
                    if (!isEmpty())
                        return root.isLeaf(ref root);

                    return true;
                }

                public void display()
                {
                    if (!isEmpty())
                        root.display(root);
                }

                public int Count()
                {
                    return count;
                }
            }
        }
    }
}