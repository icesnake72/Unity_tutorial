using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;

    //[SerializeField]
    //private float startOfBg = 19.12f;
    [SerializeField]
    private float multiple = 2f;

    [SerializeField]
    private float endOfBg = -18.6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform : MonoBehaviour 클래스에 기본으로 제공되는 Transform 객체이다
        // Transform : 객체의 Position, Rotation, Scale을 설정하도록 구현된 클래스이다

        //
        // Vector3.left == Vector3(-1f, 0f, 0f)
        // Vector3.right == Vector3(1f, 0f, 0f)
        // Vector3.up == Vector3(0f, 1f, 0f)
        // Vector3.down == Vector3(0f, -1f, 0f)

        

        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < endOfBg)
            transform.position += new Vector3(Mathf.Abs(endOfBg)*multiple, 0f, 0f);
    }
}
