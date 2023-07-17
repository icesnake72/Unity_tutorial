using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;

    [SerializeField]
    private float hp = 10;

    [SerializeField]
    private GameObject coin;

    private bool dead = false;

    protected float HP
    {
        get
        {
            return HP;
        }

        set
        {
            hp = value;    
        }
    }

    protected float Speed
    {
        get
        {
            return speed;
        }
    }

    protected virtual void CollisionProc(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Bullet bullet = collision.gameObject.GetComponent<Bullet>();
            float damage = bullet.Damage;

            hp -= damage;
            if (hp <= 0)
            {
                Animator anim = GetComponent<Animator>();
                anim.SetTrigger("Dead");

                if ( !dead )
                {
                    CreateCoin();
                    dead = true;
                }

                Invoke("Dead", 0.5f);
            }
        }
    }

    private void CreateCoin()
    {
        if (Random.Range(0f, 1f) < 0.5f)
        {
            Instantiate(coin, transform.position, Quaternion.identity);
        }
    }

    protected virtual void Dead()
    {
        Destroy(gameObject);
    }
}
