using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace LeetCode.Medium;

public class FrontMiddleBackQueueNode
{
    public int Data;
    public FrontMiddleBackQueueNode Left;
    public FrontMiddleBackQueueNode Right;
    public FrontMiddleBackQueueNode(int data, FrontMiddleBackQueueNode left = null, FrontMiddleBackQueueNode right = null)
    {
        Data = data;
        Left = left;
        Right = right;

        if (left != null)
            left.Right = this;

        if (right != null)
            right.Left = this;
    }
}
public class FrontMiddleBackQueue
{
    int count = 0;
    private FrontMiddleBackQueueNode Left;
    private FrontMiddleBackQueueNode Right;

    public FrontMiddleBackQueue()
    {

    }

    public void PushFront(int val)
    {
        count++;
        if(Left == null)
        {
            Left = new FrontMiddleBackQueueNode(val);
            Right = Left;
        } else
        {
            var newNode = new FrontMiddleBackQueueNode(val, Left, Right);
            Left = newNode;
        }
    }

    public void PushMiddle(int val)
    {

    }

    public void PushBack(int val)
    {
        count++;
        if (Right == null)
        {
            Right = new FrontMiddleBackQueueNode(val);
            Left = Right;
        }
        else
        {
            var newNode = new FrontMiddleBackQueueNode(val, Left, Right);
            Left = newNode;
        }
    }

    public int PopFront()
    {
        if (Left == null)
        {
            return -1;
        }


        if (count == 1)
        {
            Left = null;
            Right = null;

            return -1;
        }
        else
        {
            var tempL = Left.Left;
            var tempR = Left.Right;
            tempL.Right = tempR;
            tempR.Left = tempL;
            Left = tempL;
        }

        count--;

        return count;
    }

    public int PopMiddle()
    {

    }

    public int PopBack()
    {

    }
}
