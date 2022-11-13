using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshMonsterGenerator : MonoBehaviour
{


    public GameObject obj; // Monster Prefab 설정
    public float interval = 4.0f; //다음에 함수가 호출될 인터벌


    // Start is called before the first frame update
    void Start()
    {

        
        InvokeRepeating("SpawnObj", 0.5f, interval);
        // SpawnObj함수를 게임이 실행된 0.5초 후에 호출, 이후 interval(4초) 마다 호출 됨
    }

    void SpawnObj()
    {
        float rnd = Random.Range(-2.0f, 2.0f); // -2.0에서 2.0사이의 실수 랜덤 값을 생성
        Vector2 pos = new Vector2(transform.position.x, transform.position.y+rnd); // 현재 위치를 기준으로 y만 rnd만큼 조절 
        // 몬스터 생성 위치로부터 y축 –2~ +2 사이의 랜덤 위치에 몬스터 생성
        Instantiate(obj, pos, transform.rotation); 
        // obj(monster)를 이 스크립트가 들어가는 오브젝트의 위치, 방향에다 복제
    }


}
