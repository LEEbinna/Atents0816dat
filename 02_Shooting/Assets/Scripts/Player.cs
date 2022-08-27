using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerInputAction inputActions;
    //Awake -> OnEnable -> Start : 대체적인 순서

    //이 스크립트가 들어있는 게임 오브젝트가 생성된 직후에 호출하는 함수 1
    private void Awake()
    {
        inputActions = new PlayerInputAction();
    }

    //이 스크립트가 들어있는 게임 오브젝트가 활성화 되었을 때 호출 2
    private void OnEnable()
    {
        inputActions.Player.Enable();   //생성된 오브젝트가 입력을 받을 수 있게
        inputActions.Player.Move.performed += OnMove;   //performed 일 때 Onmove 함수 실행
        inputActions.Player.Move.canceled += OnMove;    //canceled 일 때 Onmove "
    }


    //이 스크립트가 들어있는 게임 오브젝트가 비활성화 되었을 때 호출
    private void OnDisable()
    {
        inputActions.Player.Move.canceled -= OnMove;    //연결한 함수 해제 
        inputActions.Player.Move.performed -= OnMove;
        inputActions.Player.Disable();  //비활성화한 오브젝트가 입력을 더 이상 받지 않게
    }

    //시작할때. 1번째 업데이트 함수 나오기 직전에 호출하는 함수 3
    private void Start()
    {
        
    }
    //매 프레임마다 호출하는 업데이트 함수
    private void Update()
    {
         
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        // Exception 뜻
        // 보통 프로그램은 실행할 것이 없으면 자동으로 종료하는데
        // 익셉션이 발생하면 코드 실행 할 것이 없어지는 상황이 되어 실행 종료가 되는 예외 상황
        //throw new NotImplementedException();    //코드 구현을 하지 않았을 경우 강제로 종료하는 코드 자동생성

        Debug.Log("이동 입력");
    }
}
