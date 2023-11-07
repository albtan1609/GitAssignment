using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
    public class DLLNode
    {
        public int num;
        public DLLNode next;
        public DLLNode previous;

        public DLLNode(int num)
        {
            this.num = num;
            next = null;
            previous = null;
        }

        public Boolean isPrime(int n)
        {
            Boolean b = true;

            if (n < 2)
            {
                return false;
            }
            else
            {
                // CORRECTION: Using <= to include square root value in check
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        b = false;
                        break;
                    }
                }
            }
            return b;
        }
    }
}
