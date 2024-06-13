using System;

namespace MyProgram {
  class Node {
    public int data;
    public Node next;
    public Node (int data){
      this.data = data;
      this.next = null;
    }
  }
  class LinkedList{
    public Node head;

    public LinkedList() {
      this.head = null;
    }
    public void Add(int data) {
      Node newNode = new Node(data);
      if (head == null) {
        head = newNode;
      } else {
        Node current = head;
        while (current.next != null) {
          current = current.next;
        }
        current.next = newNode;
      }
    }

    // 1- Display The linked list
    public void Display() {
      Node cureent = head;
      while (cureent != null) {
        Console.Write(cureent.data + " ->");
        cureent = cureent.next;
      }
      Console.Write("null");
    }

    // 2- Display Linked list in reverse
    public void DipslayReverse(Node node) {
      if (node == null) {
        return;
      }
      DipslayReverse(node.next);
      Console.Write(node.data + " -> ");
    }

    // 3- Count the Nodes in linked list
    public int CountNodes() {
      Node current = head;
      int counter = 0;
      while (current != null) {
        counter++;
        current = current.next;
      }
      return counter;
    }

    // 4- Insert node at any position 

    // 5- Insert node at the beginning of linked list
    public void InsertAtBeinning(int data) {
      Node newNode = new Node(data);
      newNode.next = head;
      head = newNode;
    }
    
    // 6- Insert at the end of Linked list
    public void InsertAtTheEnd(int data) {
      Add(data);
    }

    // 7- Get A node in Linked List
    public int GetNode(int index) {
      if (index > CountNodes() || index < 0)
        return -1;

      int counter = 0;
      Node current = head;
      while (counter < index) {
        counter++;
        current = current.next;
      }
      return current.data;
    }

    // 8- Return index for given element
    public int GetElementIndex(int element) {
      Node current = head;
      int index = 0;
      while (current != null) {
        if (current.data == element)
          return index;
        index++;
        current = current.next;
      }
      return -1;
    }

    // 9- Linked list is empty or not
    public bool IsEmpty() {
      if (head == null)
        return true;

      return false;
    }

    // 10- Empty the linked list
    public void EmptyLinkedList() {
      head = null;
    }

    // 11- Remove node from specific index

    // 12- Calculate the size of the Linked list
    public int LinkedListSize() {
      return CountNodes();
    }

    // 13- Remove first element from linked list
    public void RemoveFirstElement() {
      if (head == null)
        return;
      
      head = head.next;
    }

    // 14- Remove the Tail element from linked list
    public void RemoveTailElement() {
      Node current = head;
      while (current.next.next != null) {
        current = current.next;
      }
      current.next = null;
    }

    // 15- Convert linked list to array
    public void ConvertToArray(int[] arr) {
      Node current = head;
      for (int i = 0; current != null; i++) {
        arr[i] = current.data;
        current = current.next;
      }
    }

    // 16- Convert Linked list to string
    public string ConvertToString() {
      if (head == null) return "";

      Node current = head;
      string listNodesAsString = "";
      while (current != null) {
        listNodesAsString += Convert.ToString(current.data) + " ";
        current = current.next;
      }
      return listNodesAsString;
    }

    // 17- Get index of an element
    // The answer is the same as question 8

    // 18- Check if element is present in linked list
    public bool ElementIsPresent(int element) {
      if (GetElementIndex(element) != -1) 
        return true;
      
      return false;
    }

  }
  class Program {
    public static void Main(string[] args) {
    LinkedList list = new LinkedList();
    list.Add(1);
    list.Add(2);
    list.Add(3);
    list.Add(4);
    list.Add(5);
    Console.Write(list.ConvertToString());
    // int[] arr = new int[list.CountNodes()];
    
    // Console.Write(list.IsEmpty());
    // list.EmptyLinkedList();
    // Console.Write(list.IsEmpty());
    // list.DipslayReverse(list.head);
    // Console.Write(list.CountNodes());
    }

  }
}




