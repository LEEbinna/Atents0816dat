using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    //public delegate void DelegateName();    //이런 종류의 델리게이트(리턴없고=void ,파라메터 없는 함수 저장)
    //public DelegateName del;    //Delegate타입의 del 생성
    //Action del2;    //액션타입의 delegate del2 생성 (리턴타입x 파라메터x)
    //Action<int> del3;   //액션타입의 delegate del3 생성(리턴타입x 파라메터 int  하나)
    //Func<int, float> del4;  //펑션타입의 delegate del4 생성(리턴타입int,파라메터 float 하나)

    public float speed = 1.0f;
    Vector3 dir;    //입력에 따라 바뀌는 이동 방향 
    float boost = 1.0f;

    Rigidbody2D rigid;

    PlayerInputAction inputActions;
    //Awake -> OnEnable -> Start : 대체적인 순서

    //이 스크립트가 들어있는 게임 오브젝트가 생성된 직후에 호출하는 함수 1
    private void Awake()
    {
        inputActions = new PlayerInputAction();

        //한번만 찾고 저장해서 계속 쓸수 있는 awake 위치 (메모리더 쓰고 성능 아끼기)
        rigid = GetComponent<Rigidbody2D>();
        
    }

    //이 스크립트가 들어있는 게임 오브젝트가 활성화 되었을 때 호출 2
    private void OnEnable()
    {
        inputActions.Player.Enable();   //생성된 오브젝트가 입력을 받을 수 있게
        inputActions.Player.Move.performed += OnMove;   //performed 일 때 Onmove 함수 실행
        inputActions.Player.Move.canceled += OnMove;    //canceled 일 때 Onmove "
        inputActions.Player.Fire.performed += OnFire;
        inputActions.Player.Boost.performed += OnBoostOn;
        inputActions.Player.Boost.canceled += OnBoostOff;
    }


    //이 스크립트가 들어있는 게임 오브젝트가 비활성화 되었을 때 호출
    private void OnDisable()
    {
        inputActions.Player.Move.canceled -= OnMove;    //연결한 함수 해제 
        inputActions.Player.Move.performed -= OnMove;
        inputActions.Player.Disable();  //비활성화한 오브젝트가 입력을 더 이상 받지 않게
        inputActions.Player.Fire.performed -= OnFire;
    }

    //시작할때. 1번째 업데이트 함수 나오기 직전에 호출하는 함수 3
    private void Start()
    {
        
    }
    //매 프레임마다 호출하는 업데이트 함수

    //private void Update() //fixupdate보다 상시 업데이트
    //{
    //    // transform.position += (speed * Time.deltaTime * dir);   //dir 입력 방향으로 움직여라
    //    //transform.Translate(speed * Time.deltaTime * dir);
    //    //충돌 - position이 순간이동형이라 덜덜거리며 밀리는 현상생김
    //}

    //일정시간 간격(물리 업데이트 시간 간격)으로 호출
    private void FixedUpdate()
    {
        //transform.Translate(speed * Time.fixedDeltaTime * dir); //이동형이라 덜덜 거리지는 않지만 밀리는 현상
        //이 스크립트 파일이 들어 있는 게임 오브젝트에서 rigidbody2d 컴포넌트 찾아 리턴
        //getcomponent는 무거운 함수
        //Rigidbody2D rigid = GetComponent<Rigidbody2D>(); <- 무거워서 update같은 함수 안에서는 쓰면 안좋음

        //rigid.AddForce(speed * Time.fixedDeltaTime * dir);  //힘 더하는 함수 - 관성있는 움직임쓸때 유용
        rigid.MovePosition(transform.position + boost * speed * Time.fixedDeltaTime * dir);  //관성x움직임
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        // Exception 뜻
        // 보통 프로그램은 실행할 것이 없으면 자동으로 종료하는데
        // 익셉션이 발생하면 코드 실행 할 것이 없어지는 상황이 되어 실행 종료가 되는 예외 상황
        //throw new NotImplementedException();    //코드 구현을 하지 않았을 경우 강제로 종료하는 코드 자동생성

        dir = context.ReadValue<Vector2>(); //방향을 입력받겠다

    }

    private void OnFire(InputAction.CallbackContext context)
    {
        Debug.Log("발사!");
    }

    private void OnBoostOn(InputAction.CallbackContext context)
    {
        boost *= 2.00f;
    }
    private void OnBoostOff(InputAction.CallbackContext context)
    {
        boost = 1.00f;
    }
}
