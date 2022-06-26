 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject bulletFactory;
    public GameObject firePosition;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletFactory);

            bullet.transform.position = firePosition.transform.position;
        }
    }
}
