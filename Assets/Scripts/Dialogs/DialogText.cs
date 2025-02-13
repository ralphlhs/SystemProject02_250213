using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Dialog", menuName = "Dialog/Talking", order = 0)]
public class DialogText : ScriptableObject
{

    public Text text;
    public Queue<string> stringQueue = new Queue<string>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stringQueue.Enqueue("���߰�!!");
        stringQueue.Enqueue("���⸦ �����϶�!");
        stringQueue.Enqueue("��ɷ� �ұ��?");
        stringQueue.Enqueue("���͸� ���!");
        stringQueue.Enqueue("����~~!");
    }
}
