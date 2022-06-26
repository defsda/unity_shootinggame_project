using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 5;
    // Update is called once per frame
    void Update()
    {
        //1.방향을 구한다
        Vector3 dir = Vector3.up;
        //2.이동하고 싶다
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
}
