using UnityEngine;


[CreateAssetMenu]
public class Item : ScriptableObject //������Ʈ ������ �Ұ����ϴ�.
{
    public GameObject gameObject; //�������� ������ �ִ� ���� ������Ʈ
    public int id;
    public int price;
    public string description;
}
