using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.0f; //public�� ���̸� ����Ƽ���� ���� ������ �� �ִ�.
    //����Ƽ �̺�Ʈ �Լ� : ����Ƽ�� Ư�� Ÿ�ֿ̹� ���� ��Ű�� �Լ�

    //Start �Լ�. ������ ���۵� �� (ù��° Update �Լ��� ȣ��Ǳ� ������ ȣ��Ǵ� �Լ�) ȣ���Լ�
    private void Start()
    {
        Debug.Log("Hello Unity");
    }

    //Update �Լ�. �� �����Ӹ��� ȣ��Ǵ� �Լ�
    //���ӵǴ� ������ ����Ǵ� ���� ���� �� ����ϴ� �Լ�
    private void Update()
    {
        // ���͸� ǥ���ϱ� ���� ����ü, ��ġ�� ǥ���Ҷ��� ����.
        //���� : ���� ����� ũ�⸦ ��Ÿ���� ����

        //transform.position += new Vector3(1, 0, 0); //x�������� 1


        //new Vector3(1, 0, 0); //������ Vector3.right;
        //new Vector3(-1, 0, 0); //���� Vector3.left;
        //new Vector3(0, 1, 0); //���� Vector3.up;
        //new Vector3(0, -1, 0); //�Ʒ��� Vector3.down;

        //transform.position += (Vector3.left * speed); //�������� speed��ŭ ��������(�� �����Ӹ���) �뷮�� ������ ������

        //Time.deltaTime : ���� �����ӿ��� ���� �����ӱ��� �ɸ� �ð�
        //transform.position += (Vector3.left * speed * Time.deltaTime); //Ÿ���� �ɸ鼭 �� �������� �ƴ� ���ʸ��ٷ� ����
        transform.position += (speed * Time.deltaTime * Vector3.down);  //������ �̰� �� ���ɸ�(������Ʈ��)



    }
}
