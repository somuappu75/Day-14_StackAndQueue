﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DS_Stack_And_Queue
{
    class Queue
    {
        Node head;
        public void Enqueue(int item)
        {
            Node new_node = new Node(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("Inserted into queue : " + new_node.data);
        }

        public void Display()
        {
            Node temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("No element present in the Queue");
                return;
            }
            Console.WriteLine("The nodes are : ");
            while (temp != null)
            {

                Console.Write(temp.data + " ");
                temp = temp.next;
            }

        }
    }
}