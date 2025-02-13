using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����Ƽ���� Ư�� ������ �Ǵ� ����� �����ϱ� ���� ������ �ڷ����� ���°� �ʼ��Դϴ�. 
//�⺻ �ڷ��� �̿ܿ� Ư�� ���, �۾��� ������ �� �ִ�
//������ ����ü�� �ڷᱸ���� �θ��ڽ��ϴ�.(������ ���� ����)

//���� Ȱ��Ǵ� �ڷᱸ��
//1. ����Ʈ(List) : ������� ������ �� �ְ�, ���� �����͸� �߰�, ����, �˻��Ҽ� �ִ� ������ ������ �迭
//2. ��ųʸ�(dictionary) : Ű : ������ ��� ������ �� �ִ� ����(json)
//3. ť(Queue) : �ڷḦ ���Լ���(FIFO)�� ���� �� �� ����� �ڷᱸ��
//4. ����(Stack) : �ڷḦ ���Լ���(LIFO)�� ������ �� ����� �ڷᱸ��
//5. �ؽü�(HashSet) : �������� �ߺ��� ���� ������� �ʴ°��, ���� ������ �ʿ� ���� ���.


public class DataStructureSample : MonoBehaviour
{
    //ť(Queue) 
    //������ �ִ� ��� : ����, ����, ù��° �� ��ȸ ���.
    // ���� : �߰��� �ִ� �����͸� �����ϴ� �κп��� �ſ� ��ȿ�����Դϴ�.

    //string ������ ���� ������ �� �ִ� ť
    public Queue<string> stringQueue = new Queue<string>();

    void Start()
    {
        stringQueue.Enqueue("���� �����ּ���.");
        stringQueue.Enqueue("���� ������?");
        stringQueue.Enqueue("�ٳ��� ���� 20���� �ʿ��ؿ�.");
        stringQueue.Enqueue("���͵帮�ڽ��ϴ�.");
        stringQueue.Enqueue("�����մϴ�.");

        foreach (string dialog in stringQueue)
        {
            Debug.Log(stringQueue.Peek()); //ť�� ����� ���� �� ���� ���� return�մϴ�.
        }

        Debug.Log(stringQueue.Dequeue());
        Debug.Log(stringQueue.Dequeue());
        Debug.Log(stringQueue.Dequeue());
        Debug.Log(stringQueue.Dequeue());
        Debug.Log(stringQueue.Dequeue());
        //ť�� ����� ���� �� ���� ���� return�մϴ�.
        //�߰������� �Ǿ��� ���� �����մϴ�.

    }
}
