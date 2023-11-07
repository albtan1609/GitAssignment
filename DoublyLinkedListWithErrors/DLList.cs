using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
    public class DLList
    {
        public DLLNode head;
        public DLLNode tail;

        public DLList()
        {
            head = null;
            tail = null;
        }

        public void addToTail(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                // CORRECTION: Adjusted the order of assignments
                p.previous = tail;
                tail.next = p;
                tail = p;
            }
        }

        public void addToHead(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.next = this.head;
                this.head.previous = p;
                head = p;
            }
        }

        public void removeHead() // Corrected the typo from 'removHead' to 'removeHead'
        {
            if (this.head == null) return;

            this.head = this.head.next;

            if (this.head != null)
                this.head.previous = null; // Added check to prevent NullReferenceException
        }

        public void removeTail()
        {
            if (this.tail == null) return;

            if (this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                // CORRECTION: Handling the removal of the tail node when it's not the only node
                this.tail = this.tail.previous;
                this.tail.next = null;
            }
        }

        public DLLNode search(int num)
        {
            DLLNode p = head;

            // CORRECTION: Moved the search check before updating 'p'
            while (p != null)
            {
                if (p.num == num) break;

                p = p.next;
            }
            return p;
        }

        public void removeNode(DLLNode p)
        {
            if (p.next == null)
            {
                this.tail = this.tail.previous;
                if (this.tail != null)
                    this.tail.next = null; // Added check to prevent NullReferenceException
                return;
            }
            if (p.previous == null)
            {
                this.head = this.head.next;
                this.head.previous = null;
                return;
            }

            p.next.previous = p.previous;
            p.previous.next = p.next;
            p.next = null;
            p.previous = null;
        }

        public int total()
        {
            DLLNode p = head;
            int tot = 0;

            // CORRECTION: We don't skip alternate nodes
            while (p != null)
            {
                tot += p.num;
                p = p.next;
            }
            return tot;
        }
    }
}
