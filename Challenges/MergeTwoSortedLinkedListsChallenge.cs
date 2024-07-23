using System;

namespace APT1030C_Coding_Challenge
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class MergeTwoSortedLinkedListsChallenge
    {
        public static void Run()
        {
            Console.WriteLine("Welcome to the Merge Two Sorted Linked Lists Challenge!");

            // Input for the first linked list
            Console.WriteLine("Enter values for the first sorted linked list separated by spaces:");
            ListNode list1 = CreateLinkedListFromInput();

            // Input for the second linked list
            Console.WriteLine("Enter values for the second sorted linked list separated by spaces:");
            ListNode list2 = CreateLinkedListFromInput();

            // Merge the two sorted linked lists
            ListNode mergedList = MergeTwoLists(list1, list2);

            // Output the merged list
            Console.WriteLine("Merged sorted linked list:");
            PrintLinkedList(mergedList);

            Console.ReadKey();
        }

        public static ListNode CreateLinkedListFromInput()
        {
            string input = Console.ReadLine();
            string[] values = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            ListNode head = null;
            ListNode current = null;

            foreach (string value in values)
            {
                if (int.TryParse(value, out int num))
                {
                    ListNode newNode = new ListNode(num);
                    if (head == null)
                    {
                        head = newNode;
                        current = head;
                    }
                    else
                    {
                        current.next = newNode;
                        current = newNode;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter integer values.");
                    return null;
                }
            }

            return head;
        }

        public static void PrintLinkedList(ListNode head)
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Create a dummy node to simplify the merge logic
            ListNode dummyList = new ListNode();
            ListNode current = dummyList;

            // Traverse both lists and merge them
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            // Attach the remaining elements of the non-empty list
            if (list1 != null)
            {
                current.next = list1;
            }
            else if (list2 != null)
            {
                current.next = list2;
            }

            return dummyList.next; // Return the merged list
        }
    }
}
