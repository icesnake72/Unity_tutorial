using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Pop();
    }

    void Pop()
    {
        Rigidbody2D rigBody = GetComponent<Rigidbody2D>();
        float force = Random.Range(4f, 8f);
        Vector2 velocity = Vector2.up * force;
        velocity.x = Random.Range(-2f, 2f);
        rigBody.AddForce(velocity, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
