using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //current score���� �ְ� ȭ�鿡 ǥ���ϱ�
    public void Setscore(int value)
    {
        //3.ScoreManager Ŭ������ �Ӽۿ� ���� �Ҵ��Ѵ�.
        currentScore = value;
        //4.ȭ�鿡 ���� ���� ǥ���ϱ�
        currentScoreUI.text = "���� ����:" + currentScore;
        //��ǥ:�ְ� ������ ǥ���ϰ� �ʹ�
        //1.���� ������ �ְ� �������� ũ�ϱ�
        // -> ���� ���� ������ �ְ� ������ �ʰ��ߴٸ�
        if (currentScore > bestScore)
        {
            //2.�ְ� ������ ���Ž�Ų��
            bestScore = currentScore;

            //3.�ְ� ���� UI�� ǥ��
            bestScoreUI.text = "�ְ����� : " + bestScore;
            // ��ǥ: �ְ� ������ �ڶ��ϰ� �ʹ�.
            PlayerPrefs.SetInt("Best Score", bestScore);
        }

    }
    //current �� ��������
    public int GetScore()
    {
        return currentScore;
    }

    //��������UI
    public Text currentScoreUI;
    //��������
    public int currentScore;
    //�ְ����� UI
    public Text bestScoreUI;
    //�ְ�����
    public int bestScore;
    // Start is called before the first frame update
    void Start()
    {
        //��ǥ : �ְ������� �ҷ��ͤ� bet��score ������ �Ҵ��ϰ� ȭ�鿡 ǥ���Ѵ�
        //����:1.�ְ������� �ҷ��� bestScore�� �־��ֱ�
        bestScore = PlayerPrefs.GetInt("bestscore", 0);
        //2.�ְ� ������ ȭ�鿡 ǥ���ϱ�
        bestScoreUI.text = "�ְ� ����:" + bestScore;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
