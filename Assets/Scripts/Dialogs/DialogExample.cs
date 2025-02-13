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
        stringQueue.Enqueue("적발견!!");
        stringQueue.Enqueue("무기를 장착하라!");
        stringQueue.Enqueue("어떤걸로 할까요?");
        stringQueue.Enqueue("랩터를 띄워!");
        stringQueue.Enqueue("옛썰~~!");
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




