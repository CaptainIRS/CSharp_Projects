using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class TreeEnumerator<TItem> : IEnumerator<TItem> where TItem : IComparable<TItem>
    {
        private Tree<TItem> currentData = null;
        private TItem currentItem = default;
        private Queue<TItem> enumData = null;

        public TreeEnumerator(Tree<TItem> data)
        {
            this.currentData = data;
        }

        private void populate(Queue<TItem> enumQueue, Tree<TItem> tree)
        {
            if(tree.LeftTree != null)
            {
                populate(enumQueue, tree.LeftTree);
            }

            enumQueue.Enqueue(tree.NodeData);

            if(tree.RightTree != null)
            {
                populate(enumQueue, tree.RightTree);
            }
        }

        TItem IEnumerator<TItem>.Current
        {
            get
            {
                if(this.enumData == null)
                {
                    throw new InvalidOperationException("Use MoveNext before calling Current");
                }

                return this.currentItem;
            }
        }

        public object Current => throw new NotImplementedException();

        void IDisposable.Dispose() { }

        bool IEnumerator.MoveNext()
        {
            if(this.enumData == null)
            {
                this.enumData = new Queue<TItem>();
                populate(this.enumData, this.currentData);
            }

            if(this.enumData.Count > 0)
            {
                this.currentItem = this.enumData.Dequeue();
                return true;
            }

            return false;
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
