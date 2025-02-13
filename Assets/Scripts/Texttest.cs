using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("LHS/Texttest")]
public class Texttest : MonoBehaviour
{
    public Quest quest;
    public Text reward;
    public Text monster;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        reward.text = "현재 경험치 : " + quest.보상.경험치.ToString();
        monster.text = quest.요구조건.현재잡은몬스터수.ToString();
    }
}
