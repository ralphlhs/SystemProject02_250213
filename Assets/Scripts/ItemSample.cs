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
        Debug.Log(item.name); //스크립터블 오브젝트 만들때 붙여준 이름
        Debug.Log(item.id); //스크립터블 오브젝트에서 설정한 값들
        Debug.Log(item.description); 
        Debug.Log(item.price);
    }
}
