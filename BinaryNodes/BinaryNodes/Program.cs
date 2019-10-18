using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> s1 = new Dictionary<string, int>();
            s1.Add("Luke", 17557);
            s1.Add("Abi", 257);
            s1.Add("the", 366);
            s1.Add("hacker", 49797);
            s1.Add("Jacob", 79795);
            s1.Add("Kenu", 69898);

            BinSearchTree numbers = new BinSearchTree();
            foreach (KeyValuePair<string, int>  item in s1)
            {
                numbers.insert(item.Key, item.Value);
                Console.WriteLine($"key: {item.Key}\t value: {item.Value}");
            }

            Console.WriteLine(numbers.counter);
            Console.ReadLine();
        }

    }
    class Node
    {
        //node name:
        public string name;

        //node value:
        public double value;

        public Node left, right;

        //Constructor:
        public Node(string _name, double _val)
        {
            name = _name;
            value = _val;
            left = null;
            right = null;
        }
    }
    class BinSearchTree
    {   
        //create base of tree:
        public Node root;
        //Counter to track nodes:
        public int counter;

        //Constructor:
        public BinSearchTree()
        {
            root = null;
            counter = 0;
        }

        //Insert and add:
        private void add(Node node, ref Node tree)
        {
            if(tree == null)
            {
                tree = node;
            }
            else
            {
                int comparison = string.Compare(node.name, tree.name);
                if (comparison.Equals(0))
                {
                    throw new Exception();
                }
                if (comparison < 0)
                {
                    add(node, ref tree.left);
                }

                else
                {
                    add(node, ref tree.right);
                }

               

            }
        }
        public Node insert(string name, double d)
        {
            Node node = new Node(name, 10);
            try
            {
                if (root == null)
                    root = node;

                else
                    add(node, ref root);

                counter++;
                return node;

            }
            catch (Exception)
            {

                //throw;
                return null;
            }
        } 
    }
}
