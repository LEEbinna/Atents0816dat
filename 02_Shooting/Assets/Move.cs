using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.0f; //public을 붙이면 유니티에서 값을 변경할 수 있다.
    //유니티 이벤트 함수 : 유니티가 특정 타이밍에 실행 시키는 함수

    //Start 함수. 게임이 시작될 때 (첫번째 Update 함수가 호출되기 직전에 호출되는 함수) 호출함수
    private void Start()
    {
        Debug.Log("Hello Unity");
    }

    //Update 함수. 매 프레임마다 호출되는 함수
    //지속되는 것으로 변경되는 것이 있을 때 사용하는 함수
    private void Update()
    {
        // 벡터를 표현하기 위한 구조체, 위치를 표현할때도 쓰임.
        //벡터 : 힘의 방향과 크기를 나타내는 단위

        //transform.position += new Vector3(1, 0, 0); //x방향으로 1


        //new Vector3(1, 0, 0); //오른쪽 Vector3.right;
        //new Vector3(-1, 0, 0); //왼쪽 Vector3.left;
        //new Vector3(0, 1, 0); //위쪽 Vector3.up;
        //new Vector3(0, -1, 0); //아래쪽 Vector3.down;

        //transform.position += (Vector3.left * speed); //왼쪽으로 speed만큼 움직여라(매 프레임마다) 용량을 개많이 차지함

        //Time.deltaTime : 이전 프레임에서 지금 프레임까지 걸린 시간
        //transform.position += (Vector3.left * speed * Time.deltaTime); //타임을 걸면서 매 프레임이 아닌 매초마다로 갱신
        transform.position += (speed * Time.deltaTime * Vector3.down);  //순서는 이게 렉 덜걸림(업데이트량)



    }
}
