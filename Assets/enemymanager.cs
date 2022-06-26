using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime);
        
    }
  
    float currenTime;
    public float createTime = 1;
    public GameObject EnemyFactory;
    float minTime = 1;
    float maxTime = 5;

    // Update is called once per frame
    void Update()
    {
        currenTime += Time.deltaTime;

        if (currenTime>createTime)
        {
            GameObject enemy = Instantiate(EnemyFactory);
            enemy.transform.position = transform.position;
            currenTime = 0;

            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}
