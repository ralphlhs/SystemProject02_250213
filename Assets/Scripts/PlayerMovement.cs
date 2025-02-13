using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Quest quest;
    public GameObject Obj_Panel;
    public GameObject Obj_present;
    public GameObject Obj_enemy;
    public GameObject Obj_player_talk;
    public GameObject Obj_enemy_talk;

    public Text reward;
    public Text monster;

    public Text player_talk;
    public Text enemy_talk;

    public Queue<string> stringQueue_player = new Queue<string>();
    public Queue<string> stringQueue_enemy = new Queue<string>();

    private int kill;
    [SerializeField]
    private float walkSpeed;

    [SerializeField]
    private float applySpeed = 30;

    [SerializeField]
    private float crouchPosY;

    [SerializeField]
    private Rigidbody myRigid;


    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        //capsuleCollider = GetComponent<CapsuleCollider>();
        stringQueue_enemy.Enqueue("뭐야?");
        stringQueue_enemy.Enqueue("나가!");
        stringQueue_enemy.Enqueue("대신 돈줄께!");
        stringQueue_player.Enqueue("미안해요.");
        stringQueue_player.Enqueue("배가 고파요.");
        stringQueue_player.Enqueue("땡큐~!");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy1")
        {
            Obj_Panel.SetActive(true);
            kill++;
        }

    }
    public void OnButtonClick()
    {
        StartCoroutine(MyCoroutine());
        
    }

    IEnumerator MyCoroutine()
    {
        for (int i = 0; i < 3; i++)
        {
            Obj_enemy_talk.SetActive(true);
            enemy_talk.text = stringQueue_enemy.Dequeue();
            yield return new WaitForSeconds(1.0f);
            Obj_enemy_talk.SetActive(false);

            Obj_player_talk.SetActive(true);
            player_talk.text = stringQueue_player.Dequeue();
            yield return new WaitForSeconds(1.0f);
            Obj_player_talk.SetActive(false);
        }
        Obj_Panel.SetActive(false);
        AfterTalking();
    }

    public void AfterTalking()
    {
        reward.text = "경험치 : +" + quest.보상.경험치.ToString();
        //monster.text = $"몬스터 {kill}마리 잡았다!";
        monster.text = $"잡은 몬스터 : {kill}마리";
        Instantiate(Obj_present, transform.position, Quaternion.identity);
        Destroy(Obj_enemy.gameObject);
    }
























    void Update()
    {
        Move();
    }

    private void Move()
    {
        float _moveDirX = Input.GetAxisRaw("Horizontal");
        float _moveDirZ = Input.GetAxisRaw("Vertical");

        Vector3 _moveHorizontal = transform.right * _moveDirX;
        Vector3 _moveVertical = transform.forward * _moveDirZ;

        Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * applySpeed;
        myRigid.MovePosition(transform.position + _velocity * Time.deltaTime);
    }
}
