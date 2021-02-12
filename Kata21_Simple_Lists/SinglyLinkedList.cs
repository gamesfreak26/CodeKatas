using System;
using System.Collections.Generic;
using System.Text;

namespace Kata21_Simple_Lists {
    public class SinglyLinkedList {

        public class Node {

            public string data { get; set; }
            public Node next { get; set; }

            public Node() {
                data = null;
                next = null;
            }

            public Node(string d) {
                data = d;
                next = null;
            }
        }

        private Node head = null;

        public void Add(string s) {
            if (head == null) {
                head = new Node(s);
            }
            else {
                //// Inserts into the start of the array.  
                //Node newNode = new Node(s);
                //newNode.next = head; 
                //head = newNode;

                // Inserts at the end of the array.  

                // Create a new node and make it equal to the head node.  
                Node temp = head;

                // Iterate through the node
                while (temp.next != null) {
                    temp = temp.next;
                }
                temp.next = new Node(s);
            }
        }

        public string ToString() {

            var currentNode = head;
            var outputString = head.data; 
            
            while (currentNode != null) { 
                currentNode = currentNode.next;
                
                if (currentNode == null) return outputString;

                outputString += $"\n{currentNode.data}";
            }

            return outputString;
        }

        public bool Contains(string stringToFind) {

            Node currentNode = head;
            while (currentNode != null) {
                if (currentNode.data == stringToFind) {
                    return true;
                }
                currentNode = currentNode.next;
            }

            return false;

        }

        public void Delete(string s) {
            Node currentNode = head;

            if (currentNode == null) return;

            while (currentNode != null) {
                if (currentNode.data == s) {
                    
                }
            }
        }

        public string Find(string stringToFind) {
            Node currentNode = head;
            while (currentNode != null) {
                if (currentNode.data == stringToFind) {
                    return currentNode.data;
                }
                currentNode = currentNode.next;
            }

            return null;

        }

        public int Count() {
            Node currentNode = head;
            var count = 0;

            while (currentNode != null) {
                count += 1;
                currentNode = currentNode.next;
            }

            return count;
        }

        public void Clear() {
            head = null;
        }
    }
}
