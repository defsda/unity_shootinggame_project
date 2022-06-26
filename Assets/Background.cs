using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //��� ��Ƽ����
    public Material bgMaterial;
    //��ũ�� �ӵ�
    public float scrollSpeed = 0.2f;
    //1,��� �ִ� ���� ��� �ϰ� �ʹ�.
    void Update()
    {
        //2.������ �ʿ��ϴ�
        Vector2 direction = Vector2.up;
        //3.��ũ���ϰ� �ʹ� p=p0+vt
        bgMaterial.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;

        
    }
}
