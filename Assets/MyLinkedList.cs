public class MyNode
{
    public int value;

    public MyNode next;
}

public class MyLinkedList
{
    public MyNode head; // ���� ���� ��� null�� �����̴�.
    public MyNode tail;

    MyNode CreatNode(int value)
    {
        MyNode node = new MyNode();
        node.value = value;

        return node;
    }

    void AddNodeToTail(int value)
    {
        // �츮�� ���� ��� ��� ���� �־��� ���̴�.
        MyNode node = CreatNode(value);


        tail.next = node;
        tail = node;
    }
    void AddNodeToFront(int value)
    {
        MyNode node = CreatNode(value);

        node.next = head;
        head = node;
    }

    void AddNodeAt(int value, int index)
    {
        MyNode node = CreatNode(value);
        // �̰��� ����� ��� �ڿ� �ִ��� �˷��� ��� �ؾ� �ұ�

        int count = 0;

        MyNode curNode = head;
        while (head.next != null)
        {
            //cur�̶�� �ָ� �Ἥ ����ϰ� ���̰� ����� ���̴�
            curNode = curNode.next;
            count++;
        }

        if (curNode.next != null)
        {
            node.next = curNode.next;
            curNode.next = node;
        }
        else
        {
            curNode.next = node;
            tail = node;
        }
    }

    int FindNode(int value)
    {
        int count = 0;

        MyNode curNode = head;

        while (curNode.next != null)
        {
            curNode = curNode.next;
            count++;

            if (curNode.value == value)
                return count;
        }
        return -1;//ã�� ���ߴ�
    }

    MyNode GetNode(int value)
    {
        MyNode curNode = head;
        while (curNode.next != null)
        {
            curNode = curNode.next;

            if (curNode.value == value)
                return curNode;
        }

        return null;
    }

    MyNode GetNodeAt(int index)
    {
        int count = 0;

        MyNode curNode = head;
        while (curNode.next != null)
        {
            curNode = curNode.next;
            count++;

            if(count == index)
                return curNode;
        }

        
        return null;
    }

    void RemoveNode(int value)
    {
        MyNode curNode = head;
        MyNode prevNode = head;

        while (curNode.next != null)
        {
            prevNode = curNode;
            curNode = curNode.next;
        }
    }
}


