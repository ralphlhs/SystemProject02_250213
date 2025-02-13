using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public AudioEvent audioEvent;
    public Item item;

    void Start()
    {
        audioEvent.OnPlay += PlaySound;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            audioEvent.Play("등장배경음악");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            DropItem();
        }
    }

    private void DropItem()
    {
        var item_Object = item.gameObject;
        Instantiate(item_Object, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void PlaySound(string soundName)
    {
        Debug.Log(soundName + "플레이중입니다.");
    }
}
