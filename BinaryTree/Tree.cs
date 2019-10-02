using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree<TItem> : IEnumerable<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { get; set; }
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RightTree { get; set; }

        public Tree(TItem nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }

        public void Insert(TItem newItem)
        {
            if (this.NodeData.CompareTo(newItem) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.LeftTree.Insert(newItem);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.RightTree.Insert(newItem);
                }
            }
        }
        public string WalkTree()
        {
            string result = "";

            if (this.LeftTree != null)
            {
                result = this.LeftTree.WalkTree();
            }

            result += $" {this.NodeData.ToString()}";

            if (this.RightTree != null)
            {
                result += this.RightTree.WalkTree();
            }

            return result;
        }

        IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
        {
            return new TreeEnumerator<TItem>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
