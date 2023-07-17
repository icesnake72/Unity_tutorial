using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBird : Enemy
{   
    // Start is called before the first frame update
    void Start()
    {
        HP = 10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;

        if (transform.position.x < -10)
            Destroy(gameObject, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CollisionProc(collision);
    }
}
