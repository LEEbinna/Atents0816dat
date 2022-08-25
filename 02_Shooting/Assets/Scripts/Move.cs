using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public float speed = 1.0f; //public을 붙이면 유니티에서 값을 변경할 수 있다.
    //유니티 이벤트 함수 : 유니티가 특정 타이밍에 실행 시키는 함수

    Vector3 dir;
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
        //transform.position += (speed * Time.deltaTime * Vector3.down);  //순서는 이게 렉 덜걸림(업데이트량)

        transform.position += (speed * Time.deltaTime * dir);

        //Input System 사용하기( 세팅 : Package manage > Unity registry > input system 다운)
        //Event-driven(이벤트 드리븐 형식) -> 일이 있을 때만 동작.(전력아낌)
    }

    public void MoveInput(InputAction.CallbackContext context)
    {
        if (context.started)   //매핑된 키가 누른 직후
        {
            Debug.Log("입력들어옴 - started");
        }

        if (context.performed) //매핑된 키가 확실하게 눌려졌다
        {
            Debug.Log("입력들어옴 - performed");
        }
        if (context.canceled)  //매핑된 키가 떨어졌을 때.
        {
            Debug.Log("입력들어옴 - canceled");
        }
        Vector2 inputDir = context.ReadValue<Vector2>();
        Debug.Log(inputDir);
    }

    public void FireInput(InputAction.CallbackContext context)
    {
        if( context.performed)
        {
            Debug.Log("발사!");
        }
    }

    private void Test_OldInputManager()
    {
        //Input Manager를 이용한 입력 처리 (요즘은 다른걸 씀) -눌려질때까지 입력입력입력
        //하는 일이 없는데 배터리를 잡아먹는 사용상태 >> Big - Little 구조로 바뀜(저,고 배터리 sleep모드 활성화)

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W가 눌러졌다.");
            dir = Vector3.up;
            //dir = Vector3.(0,1,0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A가 눌러졌다.");
            dir = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S가 눌러졌다.");
            dir = Vector3.down;

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D가 눌러졌다.");
            dir = Vector3.right;
        }
    }




   







}
