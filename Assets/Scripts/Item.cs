using UnityEngine;


[CreateAssetMenu]
public class Item : ScriptableObject //오브젝트 연결은 불가능하다.
{
    public GameObject gameObject; //아이템이 가지고 있는 게임 오브젝트
    public int id;
    public int price;
    public string description;
}
