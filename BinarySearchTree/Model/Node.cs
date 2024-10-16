using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree.Model
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Left { get; set; } = null;
        public Node? Right { get; set; } = null;

        public Node(int value)
        {
            Value = value;
        }

        public void Add(int newValue)
        {
            if (newValue < Value)
            {
                if (Left == null)
                {
                    Left = new Node(newValue);
                }
                else
                {
                    Left.Add(newValue);
                }
            }
            else if (newValue > Value)
            {
                if (Right == null)
                {
                    Right = new Node(newValue);
                }
                else
                {
                    Right.Add(newValue);
                }
            }
        }

    }
}
