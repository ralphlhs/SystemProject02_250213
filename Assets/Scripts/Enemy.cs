using UnityEngine;
using Random = UnityEngine.Random;
//using System�� ����ϸ鼭 ����Ƽ�� ������ ����ϰ� �������.

public class Enemy : MonoBehaviour
{
    //������ ��� ���̺�
    public DropTable DropTable;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Dead();
        }
    }

    private void Dead()
    {
        GameObject dropItemPrefab = DropTable.drop_table[Random.Range(0, DropTable.drop_table.Count)];
        //Random.Range(�ּ�, �ִ�)�� ����Ƽ���� �������ִ� ���� ����
        //�ּҰ����� �ִ� -1������ ������ �� �� �ϳ��� �������� �����մϴ�.

        Instantiate(dropItemPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
