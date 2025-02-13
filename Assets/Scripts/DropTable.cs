using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;


//CreateAssetMenu�� ����
//()�ȿ� fileName, menuName, order�� ������ �� �ֽ��ϴ�.
//fileName : �����Ǵ� ������ �̸�
//menuName : Create�� ���� ��������� �޴��� �̸��� �����մϴ�. /�� ���� ��� ��ΰ� �߰��˴ϴ�.
//order : �޴� �߿��� ���° ��ġ�� ������ �� ǥ���Ҷ� �����ϴ°�. ���� Ŭ���� �������� ǥ�� ��.

[CreateAssetMenu(fileName = "DropTable", menuName = "DripTable/drop table", order = 0)]
public class DropTable : ScriptableObject
{
    public List<GameObject> drop_table;
}
