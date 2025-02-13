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
        stringQueue.Enqueue("적발견!!");
        stringQueue.Enqueue("무기를 장착하라!");
        stringQueue.Enqueue("어떤걸로 할까요?");
        stringQueue.Enqueue("랩터를 띄워!");
        stringQueue.Enqueue("옛썰~~!");
    }
}
