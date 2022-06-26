using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //current score값을 넣고 화면에 표시하기
    public void Setscore(int value)
    {
        //3.ScoreManager 클래스의 속송에 값을 할당한다.
        currentScore = value;
        //4.화면에 현재 점수 표시하기
        currentScoreUI.text = "현재 점수:" + currentScore;
        //목표:최고 점수를 표시하고 싶다
        //1.현재 점수가 최고 점수보다 크니까
        // -> 만약 현재 점수가 최고 점수를 초과했다면
        if (currentScore > bestScore)
        {
            //2.최고 점수를 갱신시킨다
            bestScore = currentScore;

            //3.최고 점수 UI에 표시
            bestScoreUI.text = "최고점수 : " + bestScore;
            // 목표: 최고 점수를 자랑하고 싶다.
            PlayerPrefs.SetInt("Best Score", bestScore);
        }

    }
    //current 값 가져오기
    public int GetScore()
    {
        return currentScore;
    }

    //현재점수UI
    public Text currentScoreUI;
    //현재점수
    public int currentScore;
    //최고점수 UI
    public Text bestScoreUI;
    //최고점수
    public int bestScore;
    // Start is called before the first frame update
    void Start()
    {
        //목표 : 최고점수를 불러와ㅣ bet와score 변수에 할당하고 화면에 표시한다
        //순서:1.최고점수를 불러와 bestScore에 넣어주기
        bestScore = PlayerPrefs.GetInt("bestscore", 0);
        //2.최고 점수를 화면에 표시하기
        bestScoreUI.text = "최고 점수:" + bestScore;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
