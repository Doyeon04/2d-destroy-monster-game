using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshDestroyObj : MonoBehaviour
{
    
    public float deleteTime = 3.0f;
    // ������Ʈ�� �����ϴ� ���͹�
    // �⺻������ ����� ���ʹ� 3��
    // �������� 5�ʷ� Inspector â���� ����

    void Start()
    {
        // ������Ʈ�� ������ �� deleteTime ��ŭ �ð��� ����ϸ� ����
        Destroy(gameObject, deleteTime);
        // ���⼭ gameObject�� ��ũ��Ʈ�� ������ �ִ� �� �ڽ� ������Ʈ(����, ����, ������ ������)
     }

    
}
