using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshChracterController : MonoBehaviour
{
    public float speed = 7f; //Player의 이동 속도

    public GameObject sword; // Player로부터 처음으로 생성될 무기 sword
    public GameObject bomb; // 아이템 3개를 먹을 시 Player로부터 생성될 무기 bomb
    public Transform spawnPoint; // 무기가 생성될 시작 포인트
    public float power = 1000f; // 무기가 발사될 힘
    public int item; // 획득한 아이템의 수를 count 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
        // 키보드의 좌/우 키 입력에 따라 –1~1 값 발생
        // x축(horizontal) 방향으로 speed의 이동속도 만큼 움직임
        // y축, z축은 모두 0
      
        transform.Translate(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);
        // 키보드의 상/하 키 입력에 따라 –1~1 값 발생
        // y축(Vertical) 방향으로 speed의 이동속도 만큼 움직임
        // x축, z축은 모두 0 

        // Horizontal은 x축, Vertical은 y축으로 활용하여 이동 방향 벡터(Vector2)를 계산
        // Time.deltaTime은 PC의 성능에 따라 속도(speed)가 다를 수 있으므로 어느 PC든 속도를 같게 만들어주기 위함

        transform.position
           = new Vector2(Mathf.Clamp(transform.position.x, -7, 7), Mathf.Clamp(transform.position.y, -2, 2));
        // 플레이어의 이동 범위는 x축 (-7 ~ +7), y축(-2 ~ +2)로 고정 
        // transform.position.x 값이 -7보다 작아지면 -7으로,  7보다 커지면 7으로 
        // transform.position.y 값이 -2보다 작아지면 -2로, 2보다 커지면 2로


        if (Input.GetKeyDown(KeyCode.Space))  //스페이스키 버튼 이벤트 처리
            // 스페이스키가 눌리면
        {
            Shoot(); //Shoot함수 호출
        }


    }
    void Shoot()
    {

        if (item <3) { // 획득한 아이템의 숫자가 3보다 작을 때 
            //복제된 새 sword을 생성하여 newSword에 할당
            GameObject newSword = Instantiate(sword, spawnPoint.position, Quaternion.identity) as GameObject;
            // sword을 지정된 위치(발사 지점)에 지정된 방향으로 복제 
            // Quaternion.identity: 회전 성분 (0, 0, 0)

            newSword.GetComponent<Rigidbody2D>().AddForce(Vector2.right * power);
            // newSword의 Rigidbody2D를 참조하여 AddForce 함수로 오른쪽으로 power만큼 물리적으로 발사
        }

        if (item >= 3)
        { // 획득한 아이템의 숫자가 3보다 같거나 클 때 무기 변화
            //복제된 새 bomb을 생성하여 newBomb 할당
            GameObject newBomb = Instantiate(bomb, spawnPoint.position, Quaternion.identity) as GameObject;
            // bomb을 지정된 위치(발사 지점)에 지정된 방향으로 복제 
            // Quaternion.identity: 회전 성분 (0, 0, 0)

            newBomb.GetComponent<Rigidbody2D>().AddForce(Vector3.right * power);
            // newBomb의 Rigidbody2D를 참조하여 AddForce 함수로 오른쪽으로 power만큼 물리적으로 발사
        }


    }
    
    private void OnTriggerEnter2D(Collider2D collision) // collision: 충돌된 물체
    {
        // Item들 Collider에 isTrigger 체크를 했기 때문에 onTriggerEnter2D 활용
        if (collision.gameObject.tag == "Item")
        // 충돌된 object가 가지고 있는 태그가  "Item" 이라면 
        {
            item++; // 획득한 아이템의 count를 1증가 
            Destroy(collision.gameObject); // 충돌된 object(item)를 사라지게
           
        }


    }

}
