using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshMonsterController : MonoBehaviour
{
    public float speed = 7f;// monster�� �̵� �ӵ�
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(�̵� ���� * �̵� �ӵ� * Time.deltaTime);
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        // monster�� ���� �������� speed�� �ӵ���ŭ �̵�
        // Time.deltaTime�� PC�� ���ɿ� ���� �ӵ�(speed)�� �ٸ� �� �����Ƿ� ��� PC�� �ӵ��� ���� ������ֱ� ����
    }

    private void OnCollisionEnter2D(Collision2D collision) // collision: �浹�� ��ü
     // ���Ϳ� ���Ⱑ �浹�ϸ�, ���Ϳ� ���� ��ü ��θ� ����
    {
        if (collision.gameObject.tag == "Weapon")
        // �浹�� object�� ������ �ִ� �±װ� Weapon�̶�� 
        {
            Destroy(collision.gameObject); // �浹�� object(Weapon)�� destroy
            Destroy(gameObject); // �ڱ� �ڽŵ� destroy 
        }


    }

}