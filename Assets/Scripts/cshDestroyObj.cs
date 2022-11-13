using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshDestroyObj : MonoBehaviour
{
    
    public float deleteTime = 3.0f;
    // 오브젝트를 제거하는 인터벌
    // 기본적으로 무기와 몬스터는 3초
    // 아이템은 5초로 Inspector 창에서 변경

    void Start()
    {
        // 오브젝트를 생성한 후 deleteTime 만큼 시간이 경과하면 제거
        Destroy(gameObject, deleteTime);
        // 여기서 gameObject는 스크립트를 가지고 있는 나 자신 오브젝트(무기, 몬스터, 아이템 프리팹)
     }

    
}
