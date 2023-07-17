using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private float interval = 2f;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("GenerateEnemies");
    }

    IEnumerator GenerateEnemies()
    {
        yield return new WaitForSeconds(3f);

        while( true )
        {
            CreateEnemy();
            yield return new WaitForSeconds(interval);
        }        
    }

    void CreateEnemy()
    {
        Instantiate(enemies[0], new Vector3(10f, Random.Range(-4,4), 0f), Quaternion.identity);
    }



    // Update is called once per frame
    void Update()
    {      
    }
}
