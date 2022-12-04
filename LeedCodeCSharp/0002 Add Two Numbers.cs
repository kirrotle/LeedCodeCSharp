using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCSharp
{
    internal class AddTwoNumbers
    {
     
        //Definition for singly-linked list.
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) 
            {
                this.val = val;
                this.next = next;
            }
        }
     
        public AddTwoNumbers()
        {
            ListNode x = new ListNode(9, new ListNode(9, new ListNode(9)));
            ListNode y = new ListNode(9);
            //ListNode x = new ListNode(0);
            //ListNode y = new ListNode(0);
            ListNode z = Add_Two_Numbers_1(x, y);
            while ( z.next != null )
            {
                Console.WriteLine(z.val);
                z = z.next;
            }
            Console.WriteLine(z.val);
        }

        public ListNode Add_Two_Numbers_1(ListNode l1, ListNode l2)
        {
            ListNode answer = new ListNode();
            ListNode currend_node = answer;
            while ( true )
            {
                int carry = ( currend_node.val + l1.val + l2.val ) / 10;
                currend_node.val = ( currend_node.val + l1.val + l2.val ) % 10;

                if ( carry != 0 )
                    currend_node.next = new ListNode(carry);
                if ( l1.next == null && l2.next == null )
                    return answer;
                else
                    currend_node.next = new ListNode(carry);

                if ( l1.next == null )
                    l1.next = new ListNode();
                if ( l2.next == null )
                    l2.next = new ListNode();

                l1 = l1.next;
                l2 = l2.next;
                currend_node = currend_node.next;
            }
        }
        
        public ListNode Add_Two_Numbers_2(ListNode l1, ListNode l2)
        {
            List<int> list_Num1 = new List<int>();
            while ( l1.next != null )
            {
                list_Num1.Add(l1.val);
                l1 = l1.next;
            }
            list_Num1.Add(l1.val);

            List<int> list_Num2 = new List<int>();
            while ( l2.next != null )
            {
                list_Num2.Add(l2.val);
                l2 = l2.next;
            }
            list_Num2.Add(l2.val);

            ListNode answer = new ListNode();
            ListNode current_Node = answer;
            int max_Length = list_Num1.Count >= list_Num2.Count ? list_Num1.Count : list_Num2.Count;
            for ( int length = 1; length <= max_Length; length++ )
            {
                if ( list_Num1.Count < length )
                    list_Num1.Add(0);
                if ( list_Num2.Count < length )
                    list_Num2.Add(0);
            }

            int carry = 0;
            for ( int index = 0; index < max_Length; index++ )
            {
                current_Node.val = ( carry + list_Num1[index]+list_Num2[index]) % 10;
                if ( ( ( carry + list_Num1[index] + list_Num2[index] ) / 10 ) == 1 )
                {
                    current_Node.next = new ListNode();
                    current_Node = current_Node.next;
                    current_Node.val = 1;
                    carry = 1;
                    continue;
                }
                else
                {
                    carry = 0;
                }

                if ( index < max_Length - 1 )
                {
                    current_Node.next = new ListNode();
                    current_Node = current_Node.next;
                }
            }
            return answer;
        }

    }
}
