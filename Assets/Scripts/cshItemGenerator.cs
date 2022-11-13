using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshItemGenerator : MonoBehaviour
{
    public GameObject obj1; //Item Prefab1 설정
    public GameObject obj2; //Item Prefab2 설정
    public GameObject obj3; //Item Prefab3 설정
    public float interval = 3.0f; //다음에 함수가 호출될 인터벌

    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", 0.5f, interval);
        // 시작 0.5초이후부터 3초 간격으로 SpawnObj 함수 실행 
    }

    void SpawnObj()
    { // 아이템은 생성 위치, 종류 모두 랜덤
        float rndx = Random.Range(-5.0f, 5.0f); // -5.0에서 5.0사이의 랜덤값을 생성
        float rndy = Random.Range(-2.0f, 2.0f); // -2.0에서 2.0사이의 랜덤값을 생성
 
        Vector2 pos = new Vector2(rndx, rndy); // 아이템의 생성 위치는 x는 -5~5, y는 -2~2 사이로 랜덤 생성

        int rnd = Random.Range(0, 3); //rnd는 0~(3-1) 사이의 정수를 생성

        if(rnd == 0) // 랜덤으로 생성된 rnd 가 0이라면 
        {
            Instantiate(obj1, pos, transform.rotation); // obj1를 랜덤으로 지정된 위치, 방향에다 복제
        }
        else if(rnd == 1) // 랜덤으로 생성된 rnd 가 1이라면 

        {
            Instantiate(obj2, pos, transform.rotation); // obj2를 랜덤으로 지정된 위치, 방향에다 복제
        }
        else // 랜덤으로 생성된 rnd 가 2라면 
        {
            Instantiate(obj3, pos, transform.rotation); // obj3를 랜덤으로  위치, 방향에다 복제
        }

       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
