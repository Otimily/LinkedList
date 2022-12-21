public class MyNode
{
    public int value;

    public MyNode next;
}

public class MyLinkedList
{
    public MyNode head; // 헤드와 테일 모두 null인 상태이다.
    public MyNode tail;

    MyNode CreatNode(int value)
    {
        MyNode node = new MyNode();
        node.value = value;

        return node;
    }

    void AddNodeToTail(int value)
    {
        // 우리가 만든 노드 대로 값을 넣어줄 것이다.
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
        // 이것이 몇번재 노드 뒤에 있는지 알려면 어떻게 해야 할까

        int count = 0;

        MyNode curNode = head;
        while (head.next != null)
        {
            //cur이라는 애를 써서 깔끔하게 보이게 만드는 것이다
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
        return -1;//찾지 못했다
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


