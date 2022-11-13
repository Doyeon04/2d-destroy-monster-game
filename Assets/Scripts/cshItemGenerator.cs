using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshItemGenerator : MonoBehaviour
{
    public GameObject obj1; //Item Prefab1 ����
    public GameObject obj2; //Item Prefab2 ����
    public GameObject obj3; //Item Prefab3 ����
    public float interval = 3.0f; //������ �Լ��� ȣ��� ���͹�

    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", 0.5f, interval);
        // ���� 0.5�����ĺ��� 3�� �������� SpawnObj �Լ� ���� 
    }

    void SpawnObj()
    { // �������� ���� ��ġ, ���� ��� ����
        float rndx = Random.Range(-5.0f, 5.0f); // -5.0���� 5.0������ �������� ����
        float rndy = Random.Range(-2.0f, 2.0f); // -2.0���� 2.0������ �������� ����
 
        Vector2 pos = new Vector2(rndx, rndy); // �������� ���� ��ġ�� x�� -5~5, y�� -2~2 ���̷� ���� ����

        int rnd = Random.Range(0, 3); //rnd�� 0~(3-1) ������ ������ ����

        if(rnd == 0) // �������� ������ rnd �� 0�̶�� 
        {
            Instantiate(obj1, pos, transform.rotation); // obj1�� �������� ������ ��ġ, ���⿡�� ����
        }
        else if(rnd == 1) // �������� ������ rnd �� 1�̶�� 

        {
            Instantiate(obj2, pos, transform.rotation); // obj2�� �������� ������ ��ġ, ���⿡�� ����
        }
        else // �������� ������ rnd �� 2��� 
        {
            Instantiate(obj3, pos, transform.rotation); // obj3�� ��������  ��ġ, ���⿡�� ����
        }

       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
