using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class DialogExample : MonoBehaviour
{
    public Text text;
    public Queue<string> stringQueue = new Queue<string>();
    public GameObject gameO;
    void Start()
    {
        stringQueue.Enqueue("���߰�!!");
        stringQueue.Enqueue("���⸦ �����϶�!");
        stringQueue.Enqueue("��ɷ� �ұ��?");
        stringQueue.Enqueue("���͸� ���!");
        stringQueue.Enqueue("����~~!");
    }
     

    public void OnButtonClick()
    {
        gameO.SetActive(true);
        StartCoroutine(MyCoroutine());
    }


    IEnumerator MyCoroutine()
    {
        for (int i = 0; i < 5; i++)
        {
            text.text = stringQueue.Dequeue();
            yield return new WaitForSeconds(1.0f);
        }
        gameO.SetActive(false);
    }

}




