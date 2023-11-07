using DoublyLinkedListWithErrors;
using System.Collections.Generic;
using System.Xml.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectFixed
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_IsPrime()
        {
            DLLNode node = new DLLNode(-3);
            Assert.IsFalse(node.isPrime(-3));
        }
        [TestMethod]
        public void TestMethod2_IsPrimeZero()
        //Test if the number 0 is correctly identified as non-prime.
        {
            DLLNode node = new DLLNode(0);
            Assert.IsFalse(node.isPrime(0));
        }

        [TestMethod]
        public void TestMethod3_IsPrimeOne()
        //Test if the number 1 is correctly identified as non-prime.
        {
            DLLNode node = new DLLNode(1);
            Assert.IsFalse(node.isPrime(1));
        }
        [TestMethod]
        public void TestMethod4_IsPrimeTwo()
        //Test if the number 2 is correctly identified as prime.
        {
            DLLNode node = new DLLNode(2);
            Assert.IsTrue(node.isPrime(2));
        }

        [TestMethod]
        public void TestMethod5_IsPrimeThree()
        //Test if the number 3 is correctly identified as prime.
        {
            DLLNode node = new DLLNode(3);
            Assert.IsTrue(node.isPrime(3));
        }

        [TestMethod]
        public void TestMethod6_IsPrimeFour()
        //Test if the number 4 is correctly identified as non-prime.
        {
            DLLNode node = new DLLNode(4);
            Assert.IsFalse(node.isPrime(4));
        }

        [TestMethod]
        public void TestMethod7_AddToTailEmptyList()
        // Test Add a node to the tail of an empty doubly linked list.
        {
            DLList list = new DLList();
            DLLNode node = new DLLNode(5);
            list.addToTail(node);
            Assert.AreEqual(list.head, node);
            Assert.AreEqual(list.tail, node);
        }

        [TestMethod]
        public void TestMethod8_AddToHeadEmptyList()
        //Test Add a node to the head of an empty doubly linked list.
        {
            DLList list = new DLList();
            DLLNode node = new DLLNode(5);
            list.addToHead(node);
            Assert.AreEqual(list.head, node);
            Assert.AreEqual(list.tail, node);
        }

        [TestMethod]
        public void TestMethod9_AddToTail()
        //Test Add a node to the tail of a non-empty doubly linked list.
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(5);
            DLLNode node2 = new DLLNode(10);
            list.addToTail(node1);
            list.addToTail(node2);
            Assert.AreEqual(list.tail, node2);
            Assert.AreEqual(node1.next, node2);
        }

        [TestMethod]
        public void TestMethod10_AddToHead()
        // Test Add a node to the head of a non-empty doubly linked list.
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(5);
            DLLNode node2 = new DLLNode(10);
            list.addToHead(node1);
            list.addToHead(node2);
            Assert.AreEqual(list.head, node2);
            Assert.AreEqual(node2.next, node1);
        }

        [TestMethod]
        public void TestMethod11_RemoveHeadEmptyList()
        // Test removal of the head node from an empty list.
        {
            DLList list = new DLList();
            list.removeHead();
            Assert.IsNull(list.head);
        }

        [TestMethod]
        public void TestMethod12_RemoveTailEmptyList()
        // Test removal of the tail node from an empty list.
        {
            DLList list = new DLList();
            list.removeTail();
            Assert.IsNull(list.tail);
        }

        [TestMethod]
        public void TestMethod13_RemoveHead()
        // Test removal of the head node from a non-empty list.
        {
            DLList list = new DLList();
            DLLNode node = new DLLNode(5);
            list.addToHead(node);
            list.removeHead();
            Assert.IsNull(list.head);
        }

        [TestMethod]
        public void TestMethod14_RemoveTail()
        // Test removal of the tail node from a non-empty list.
        {
            DLList list = new DLList();
            DLLNode node = new DLLNode(5);
            list.addToTail(node);
            list.removeTail();
            Assert.IsNull(list.tail);
        }

        [TestMethod]
        public void TestMethod15_SearchForNode()
        // Test to Search for a node with a specific value in the list.
        {
            DLList list = new DLList();
            DLLNode node = new DLLNode(5);
            list.addToTail(node);
            DLLNode foundNode = list.search(5);
            Assert.AreEqual(foundNode, node);
        }

        [TestMethod]
        public void TestMethod16_SearchForNonExistentNode()
        // Test to Search for a node with a value that does not exist in the list.
        {
            DLList list = new DLList();
            list.addToTail(new DLLNode(5));
            DLLNode foundNode = list.search(10);
            Assert.IsNull(foundNode);
        }

        [TestMethod]
        public void TestMethod17_RemoveNode()
        // Test to Remove a specific node from the middle of the list.
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(5);
            DLLNode node2 = new DLLNode(10);
            list.addToTail(node1);
            list.addToTail(node2);
            list.removeNode(node1);
            Assert.AreEqual(list.head, node2);
        }

        /*[TestMethod]
        public void TestMethod18_RemoveHeadNode()
        // Test to Remove the head node using removeNode method.
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(5);
            list.addToHead(node1);
            list.removeNode(node1);
            Assert.IsNull(list.head);
        } */

        [TestMethod]
        public void TestMethod19_RemoveTailNode()
        // Test to Remove the tail node using removeNode method.
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(5);
            list.addToTail(node1);
            list.removeNode(node1);
            Assert.IsNull(list.tail);
        }

        [TestMethod]
        public void TestMethod20_TotalValue()
        // Test to Calculate the total value of all nodes in the list.
        {
            DLList list = new DLList();
            list.addToTail(new DLLNode(5));
            list.addToTail(new DLLNode(10));
            list.addToTail(new DLLNode(15));
            Assert.AreEqual(30, list.total());  // This assumes the total() method works correctly. If not, the assertion might fail.
        }
        [TestMethod]
        public void TestMethod21_AddMultipleNodes()
        // Test by adding multiple nodes to the list and ensure they are placed in the right order.
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            DLLNode node2 = new DLLNode(2);
            DLLNode node3 = new DLLNode(3);

            list.addToTail(node1);
            list.addToTail(node2);
            list.addToTail(node3);

            Assert.AreEqual(list.head, node1);
            Assert.AreEqual(list.tail, node3);
            Assert.AreEqual(node1.next, node2);
            Assert.AreEqual(node2.next, node3);
        }

        /*[TestMethod]
        public void TestMethod22_RemoveMultipleNodes()
        // After adding multiple nodes, test by removing some nodes and ensure the list structure remains intact.
        {
            DLList list = new DLList();
            DLLNode node1 = new DLLNode(1);
            DLLNode node2 = new DLLNode(2);
            DLLNode node3 = new DLLNode(3);

            list.addToTail(node1);
            list.addToTail(node2);
            list.addToTail(node3);

            list.removeNode(node2);

            Assert.AreEqual(list.head, node1);
            Assert.AreEqual(list.tail, node3);
            Assert.IsNull(node1.next.previous);
            Assert.AreEqual(node1.next, node3);
        } */

        [TestMethod]
        public void TestMethod23_TotalForEmptyList()
        // Test to Ensure that calculating the total value of nodes in an empty list returns 0.
        {
            DLList list = new DLList();
            int total = list.total();
            Assert.AreEqual(0, total);
        }

        [TestMethod]
        public void TestMethod24_SearchInEmptyList()
        // Test if the search method handles an empty list gracefully without any exceptions.
        {
            DLList list = new DLList();
            DLLNode result = list.search(10);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestMethod25_IsPrimeForLargeNumber()
        // Test if the method isPrime correctly identifies a large prime number.
        {
            DLLNode node = new DLLNode(104729);
            Assert.IsTrue(node.isPrime(104729));
        }
    }
}
