using System;
using UnityEngine;

public class ItemSample : MonoBehaviour
{
    public Item item;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ItemInfor();
        }
    }

    private void ItemInfor()
    {
        Debug.Log(item.name); //��ũ���ͺ� ������Ʈ ���鶧 �ٿ��� �̸�
        Debug.Log(item.id); //��ũ���ͺ� ������Ʈ���� ������ ����
        Debug.Log(item.description); 
        Debug.Log(item.price);
    }
}
