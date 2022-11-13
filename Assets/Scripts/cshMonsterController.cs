using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshMonsterController : MonoBehaviour
{
    public float speed = 7f;// monster의 이동 속도
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(이동 방향 * 이동 속도 * Time.deltaTime);
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        // monster를 좌측 방향으로 speed의 속도만큼 이동
        // Time.deltaTime은 PC의 성능에 따라 속도(speed)가 다를 수 있으므로 어느 PC든 속도를 같게 만들어주기 위함
    }

    private void OnCollisionEnter2D(Collision2D collision) // collision: 충돌된 물체
     // 몬스터와 무기가 충돌하면, 몬스터와 무기 객체 모두를 제거
    {
        if (collision.gameObject.tag == "Weapon")
        // 충돌된 object가 가지고 있는 태그가 Weapon이라면 
        {
            Destroy(collision.gameObject); // 충돌된 object(Weapon)를 destroy
            Destroy(gameObject); // 자기 자신도 destroy 
        }


    }

}