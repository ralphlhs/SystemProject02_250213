using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu]
public class AudioEvent : ScriptableObject
{
    public event Action<string> OnPlay;

    public void Play(string name)
    {
        if(OnPlay != null) OnPlay.Invoke(name);
        //Invoke�� �̺�Ʈ ����� �Լ��Դϴ�. 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
