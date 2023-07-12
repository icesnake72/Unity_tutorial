using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    public float speed = 0.1f;

    // 해당 스크립트의 인스턴스가 생성될 때 호출
    private void Awake()
    {
        /// 게임 오브젝트가 활성화되기 전에 실행됨
        ///
        Debug.Log("Awake() 호출됨");
    }


    private void OnEnable()
    {
        // 게임 오브젝트가 활성화될때 호출됨 
        Debug.Log("OnEnable() 호출됨");
    }

    // Start is called before the first frame update
    // update 영역으로 들어가기전에 딱 한번만 호출됨 
    void Start()
    {
        Debug.Log("Start() 호출됨");
    }

    private void FixedUpdate()
    {
        // 고정된 실행 주기로 cpu를 사용 (cpu부하가 많음)
        // 보통 물리연산과 관련된 기능을 구현할때 사용함

        Debug.Log("FixedUpdate() 호출됨");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update() 호출됨");

        // 아무키나 눌렀을때 한번만 true
        // 눌려진 키를 체크하는 방법 
        //if (Input.anyKeyDown)
        //{
        //    foreach (KeyCode keyCode in System.Enum.GetValues(typeof(KeyCode)))
        //    {
        //        if (Input.GetKeyDown(keyCode))
        //        {
        //            Debug.Log("눌린 키: " + keyCode.ToString());
        //            break;
        //        }
        //    }
        //}

        //// 키를 눌렀을때 한번만 true
        //if (Input.GetKeyDown(KeyCode.Return))
        //    Debug.Log("엔터키가 눌렸습니다");

        //// 키를 누르고 있는동안 계속 true
        //if (Input.GetKey(KeyCode.LeftArrow))
        //    Debug.Log("왼쪽방향키가 눌렸습니다");

        //// 눌려진 키에서 손가락을 뗄때 한번만 true
        //if (Input.GetKeyUp(KeyCode.LeftArrow))
        //    Debug.Log("눌려진 왼쪽방향키를 놨습니다");

        //// Left Mouse button
        //if (Input.GetKey(KeyCode.Mouse0))
        //    Debug.Log("마우스 0키가 눌렸습니다");

        //// Right Mouse button
        //if (Input.GetKey(KeyCode.Mouse1))
        //    Debug.Log("마우스 0키가 눌렸습니다");


        // Input Manager의 정의된 사항을 이용하는 방법
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프");

        if (Input.GetButton("Jump"))
            Debug.Log("점프를 누르고 있음 ");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("점프 끝");

        if (Input.GetButtonDown("Skill_Q"))
            Debug.Log("Q Skill을 사용함");

        // 물리 엔진을 적용한 자연스러운 움직임 
        //float x_pos = Input.GetAxis("Horizontal");
        //Debug.Log(x_pos);

        // 일반적인 딱딱한 움직임(컨트롤이 편함)
        //float offset_x = Input.GetAxisRaw("Horizontal");
        float offset_x = Input.GetAxis("Horizontal");
        Debug.Log(offset_x);

        float offset_y = Input.GetAxis("Vertical");
        //float offset_y = Input.GetAxisRaw("Vertical");
        Debug.Log(offset_y);

        // 이동해야되는 Offset( 이동 거리 )
        Vector3 moveOffset = new Vector3(offset_x, offset_y, 0f);

        Vector3 new_position = new Vector3();
        new_position = transform.position;   // 현재 좌표 
        new_position += moveOffset * speed * Time.deltaTime; // offset을 더한 새로운 좌표

        Debug.Log(new_position);

        new_position.x = Mathf.Clamp(new_position.x, -8.3f, 8.3f);
        new_position.y = Mathf.Clamp(new_position.y, -4.46f, 4.46f);

        transform.position = new_position;
    }

    private void LateUpdate()
    {
        // 후처리
        //Debug.Log("LateUpdate() 호출됨");
    }

    private void OnDisable()
    {
        // 게임 오브젝트가 비활성화될때 호출됨 
        Debug.Log("OnDisable() 호출됨");
    }

    private void OnDestroy()
    {
        // 오브젝트가 해제될때 호출됨
        Debug.Log("OnDestroy() 호출됨");
    }
}
