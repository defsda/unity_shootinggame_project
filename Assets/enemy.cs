using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Vector3 dir;
   

    // Start is called before the first frame update
    void Start()
    {
      
        
        
       
        int randvalue = UnityEngine.Random.Range(0, 10);
        if (randvalue < 3)
        {
           
            GameObject target = GameObject.Find("player");

            dir = target.transform.position - transform.position;
            dir.Normalize();

        }
        else
        {
            dir = Vector3.down;
        }
    }
    //목표 적이 다른 물체와 충돌했을때 폭팔 효과를 발생시키고 싶다
    //순서:1.적이 다른 물체와 충돌 했으니까
    
        //2 폭팔효과 공장에서 폭팔효과를 하나 만들어야 한다
       
    //3폭팔효과를 발생(위치)시키고 싶다
    // 필요 속성 폭팔 공중 주소 (외부에서 값을 넣어준다)
    public float speed = 5;
    GameObject player;
  
    //폭팔 공중 주소(외부에서 값을 넣어준다)
    public GameObject explosionFactory;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        Destroy(collision.gameObject);
        Destroy(gameObject);
        //에너미를 잡을 떄마다 현재 점수를 표시하고 싶다.
        //1.씬에서 ScoreManger 객체를 가져오자.
        GameObject smObject = GameObject.Find("ScoreManager");
        //2.ScoreManager를 게임 오브젝트에서 얻어온多.
        ScoreManager sm = smObject.GetComponent<ScoreManager>();
        //3.ScoreManager 클래스의 속송에 값을 할당한다.
        sm.Setscore(sm.GetScore() + 1);
        //4.화면에 현재 점수 표시하기
        sm.currentScoreUI.text = "현재 점수:" + sm.currentScore;
        //목표:최고 점수를 표시하고 싶다
        //1.현재 점수가 최고 점수보다 크니까
        // -> 만약 현재 점수가 최고 점수를 초과했다면
        if(sm.currentScore >sm.bestScore)
        {
            //2.최고 점수를 갱신시킨다
            sm.bestScore = sm.currentScore;

            //3.최고 점수 UI에 표시
            sm.bestScoreUI.text = "최고점수 : " + sm.bestScore;
            // 목표: 최고 점수를 자랑하고 싶다.
            PlayerPrefs.SetInt("Best Score", sm.bestScore);
        }
        
    }

    private void OnCollisionStay(Collision other)
    {
        
    }
    private void OnCollisionExit(Collision other)
    {
        
    }
   
    void Update()
    {
        // Vector3 dir = Vector3.down;
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
}
