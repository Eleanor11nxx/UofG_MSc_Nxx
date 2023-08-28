using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Npc : MonoBehaviour
{

    public int score = 10;
    public string speak = "hello";
    public bool isGood = true;
    private bool hasBeen = false;
    public GameObject scoreObj;
    public GameObject speakObj;
    // Start is called before the first frame update


    
    // //初始位置
    // float InitialPosition;
    // //目标位置
    // float TargetPosition;
 
    // //每次转速
    // int sky = -150;
 
    // //上次移动是否完成
    // bool StateMotion = true;
    // //上次旋转是否完成
    // bool AngleMotion = true;
 
    // //是否休息
    // bool WhetherRest = false;
    // //行走速度
    // private float MoveSpeed = 0.5f;
    // //奔跑速度
    // private float RunSpeed = 0.75f;
    // //确定移动次数
    // int Distance;
    // //确定移动状态：1/走 0/跑
    // int c = 1;
    void Start()
    {
        // Text scoreTxt = scoreObj.GetComponent<Text>();
        Text speakTxt = speakObj.GetComponent<Text>();
        speakTxt.fontSize = 100;
        // scoreTxt.text = "score:" + score.ToString();
        // speakTxt.text = speak;
        // refreshShow(false,100);
         //获取物体的初始位置
        // InitialPosition = transform.position;
    }

    public void resetInfo(int newScore ,string newSpeaking,bool newIsGood,bool newWithouScore,int myScore)
    {
        // Debug.Log("重置位置");
        score = newScore;
        speak = newSpeaking;
        isGood = newIsGood;
        Text scoreTxt = scoreObj.GetComponent<Text>();
        Text speakTxt = speakObj.GetComponent<Text>();
        scoreTxt.text = "score:" + newScore.ToString();
        speakTxt.text = newSpeaking;
        isGood = newIsGood;
        if(myScore != 0){
            refreshShow(newWithouScore,myScore);
        }else{
            refreshShow(false,100);
        }
    }

    public void refreshShow(bool withoutScore ,int myScore)
    {
        if (myScore > 90)
        {
            if (withoutScore || score >= 90)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    //�ٱ��û�
    public void banit()
    {
        Debug.Log("banit");
        if (isGood)
        {
           
        }
        else
        {
            if (!hasBeen)// ÿ��npcֻ�ܾٱ�һ��
            {
                score = score - 10;
                hasBeen = true;
                refreshShow(false,100);

            }
        }
    }

    // public float GetDistance(Vector3 startPoint, Vector3 endPoint)
    //     {
    //         float distance = (startPoint - endPoint).magnitude;
    //         return distance;
    //     }
    // }

    // Update is called once per frame
    void Update()
    {
        // //确定转头方向
        // int d = Random.Range(0, 2);
 
        // float Statu = c == 1 ? MoveSpeed : RunSpeed;
        // if (StateMotion)
        // {
        //     Distance = Random.Range(20, 30);
        //     StateMotion = false;
        // }
 
        // //生成随机数(0-15);确定旋转次数。
        // int RotateAngle = Random.Range(0, 15);
        // if (!WhetherRest)
        // {
        //     if (AngleMotion)
        //     {
        //         if (d == 1)
        //         {
        //             sky = -sky;
        //         }
        //         AngleMotion = false;
        //         for (int i = 0; i < RotateAngle; i++)
        //         {
        //             transform.Rotate(0, sky * Time.deltaTime, 0, Space.Self);
        //         }
 
        //     }
 
        //     if ((Distance--) != 0)
        //     {
        //         transform.Translate(0, 0, Statu * Time.deltaTime, Space.Self);
        //     }
        //     else
        //     {
        //         StateMotion = true;
        //         AngleMotion = true;
        //         c = Random.Range(0, 2);
        //     }
        // }
        // else
        // {

        // }
    }
}
