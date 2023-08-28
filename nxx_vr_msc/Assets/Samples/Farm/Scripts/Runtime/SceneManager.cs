using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public int myScore = 100;
    public bool withoutScore = false;
    private int sceneNum = 0;
    private int pageNum = 1;
    public GameObject nextPageBtn;
    public GameObject lastPageBtn;
    int[] pageArr = {2,1,1,3};
    // Start is called before the first frame update
    void Start()
    {
        refreshNps(1);
        refreshPageShow();
        refreshHelpTipShow();
    }

    public void nextPage()
    {
        pageNum = pageNum + 1;
        refreshPageShow();
    }

    public void lastPage()
    {
        pageNum = pageNum - 1;
        refreshPageShow();
    }

    public void refreshPageShow()
    {
        if(pageNum <= 1){
            lastPageBtn.SetActive(false);
        }else{
            lastPageBtn.SetActive(true);
        }
        if(pageNum >= pageArr[sceneNum]){
            nextPageBtn.SetActive(false);
        }else{
            nextPageBtn.SetActive(true);
        }
        refreshHelpTipShow();
    }
    //刷新NPC
    public void refreshSingleNpc(int index,int newScore ,string newSpeaking,bool newIsGood){
        GameObject ParentObject = GameObject.Find("SceneManager");
        ParentObject.transform.Find("Scarecrow" + index.ToString()).gameObject.GetComponent<Npc>().resetInfo(newScore,newSpeaking,newIsGood,withoutScore,myScore);
    }

    // 刷新提示信息
    public void refreshHelpTipShow(){
        GameObject ParentObject = GameObject.Find("SceneManager");
        GameObject lectern = ParentObject.transform.Find("Lectern").gameObject;

        TextMesh title = lectern.transform.Find("Title").gameObject.GetComponent<TextMesh>();
        TextMesh text = lectern.transform.Find("text").gameObject.GetComponent<TextMesh>();;
        title.text = "Mission " + sceneNum.ToString();
        if(sceneNum == 0){
            if(pageNum == 1){
                title.text = "Welcome to my VR farm!";
                text.text = "This project aims to explore the impact of the user behaviour point system on the game experience.\n"+
                            "This research will last about 20 minutes. Since you meet the conditions of the subjects,\n"+
                            "you are invited to participate in this experiment.If you decide to participate in this experiment,\n"+
                            "your personal data and information during the experiment and the experiment will be kept strictly confidential,\n"+
                            "and will not be disclosed to third parties unless you have your permission.\n"+
                            "So to ensure the authenticity of the experiment,.\n"+
                            "please be sure to provide your real information and record your real feelings.\n"+
                            "<color=#00ff00ff>If you already know about this experiment and volunteer to participate in this experiment.</color>\n"+
                            "<color=#00ff00ff>Now you can activate the laser ray by pressing the left shift key.</color>\n"+
                            "<color=#00ff00ff>Use it against the NextPage button and clicking on the left mouse button to turn the page.</color>\n";
            }else if(pageNum == 2){
                title.text = "Intruduction";
                text.text = "Behind you are talking NPCs who will simulate other players you'll meet in a VR social game.\n"+
                            "The behaviour point system sets a behaviour point with a maximum value of 100 for each NPC. \n"+
                            "When the point system is enabled, players with behaviour points lower than 90 will not be visible to other players,\n"+
                            "to ensure that high-quality players play as much as possible experience,\n"+
                            "Players can report other users' unfriendly speeches, and if the report is successful, part of their points will be deducted.\n"+
                            "<color=#00ff00ff>You can explore the map initially, if you are familiar with the rules,</color>\n"+
                            "<color=#00ff00ff>press N to start the first mission.</color>\n";
            }
        }else if(sceneNum == 1){
            text.text = "In this task, you can experience the role of the user behaviour scoring system.\n"+
                        "Above the head of each NPC are his speech and his points.\n"+
                        "<color=#00ff00ff>Press X to apply the system, and press Z to cancel the application system.</color>\n"+
                        "<color=#00ff00ff>Please try to experience the function of the system and record your experience in the questionnaire.</color>\n"+
                        "<color=#00ff00ff>If you complete this quest, press N to go to the next one.</color>\n";
        }else if(sceneNum == 2){
            text.text = "In this mission, the scenario simulates how other players affect your experience after applying the points system.\n"+
                        "In the last mission, you can notice that some players made bad comments even though they had high points.\n"+
                        "In this mission, the scenario simulates the outcome of other players reporting such speeches.\n"+
                        "<color=#00ff00ff>Press X to apply the system, and press Z to cancel the application system.</color>\n"+
                        "<color=#00ff00ff>Please try to experience the function of the system and record your experience in the questionnaire.</color>\n"+
                        "<color=#00ff00ff>If you complete this quest, press N to go to the next one.</color>\n";
        }else if(sceneNum == 3){
            if(pageNum == 1){
                text.text = "In this mission, your character is a player whose points have been deducted below 90 due to bad behaviour.\n"+
                            "In the scenario, due to your low score, other players and you have become invisible to each other, \n"+
                            "and for your complete gaming experience, you need to perform the next actions to improve your behavioral score. \n"+
                            "First of all you need to read the ethics manual of this game in detail.\n"+
                            "<color=#00ff00ff>Use laser ray against the NextPage button to turn the page.</color>\n";
            }else if(pageNum == 2){
                title.text = "Ethics manual";
                text.text = "Dont displaying offensive or offending behaviour, including:\n"+
                            "Molesting another person through touch or making sexually suggestive gestures.\n"+
                            "Using symbols to support or represent hateful ideologies or groups that disseminate hateful content, \n"+
                            "or attack others because of their race, ethnicity,place of origin, religious beliefs, \n"+
                            "sexual orientation, caste, biological sex, gender, gender identity, and serious illness or disability.\n"+
                            "<color=#00ff00ff>Use laser ray against the NextPage button to turn the page.</color>\n";
            }else if(pageNum == 3){
                title.text = "Mandatory task";
                text.text = "I believe you already know the moral code of this game.\n"+
                            "Now you need to go to the apple orchard next to the rice field.\n"+
                            "<color=#00ff00ff>You need help the workers pick 15 apples as your punishment.</color>\n"+
                            "We hope that your labor will improve your understanding of our game.\n"+
                            "And hope that you can help us maintain a better gaming environment in the future.\n"+
                            "You will be able to continue playing the game normally after it is over.\n"+
                            "<color=#00ff00ff>Please try to experience the function of the system and record your experience in the questionnaire.</color>\n";
            }
        }
    }
    
    //隐藏提示面板
    public void hideHelp(){
        GameObject ParentObject = GameObject.Find("SceneManager");
        ParentObject.transform.Find("Lectern").gameObject.SetActive(false);
    }
    
    //刷新提示面板位置
    public void refreshHelpPosition(){
        GameObject ParentObject = GameObject.Find("SceneManager");
        GameObject lectern = ParentObject.transform.Find("Lectern").gameObject;
        lectern.SetActive(true);
        GameObject myHead = GameObject.Find("AvatarObjects");
        lectern.transform.position = new Vector3(myHead.transform.position.x, 0, myHead.transform.position.z + 2);
        refreshHelpTipShow();
    }
    
    //整体刷新NPC
    public void refreshNps(int type)
    {
        if(sceneNum <= 1){
            if(type == 1){
                withoutScore = true;
            }else if(type == 2){
                withoutScore = false;
            }
            refreshSingleNpc(1,100,"Hello!",true);
            refreshSingleNpc(2,80,"¥……&*@……&*！@？？？!",false);
            refreshSingleNpc(3,95,"Hey girl!I think we can be good friends!",true);
            refreshSingleNpc(4,95,"Hello!!",true);
            refreshSingleNpc(5,100,"You are so pretty!",true);
            refreshSingleNpc(6,88,"*****************",false);
            refreshSingleNpc(7,100,"What a shame!",true);
            refreshSingleNpc(8,100,"Could you be my friend?",true);
            refreshSingleNpc(9,100,"I have lots of girlFriend",false);
            refreshSingleNpc(10,94,"You are stupid!",false);
            refreshSingleNpc(11,95,"¥……&*@……&*！@？？",false);
            refreshSingleNpc(12,100,"What?",true);
        }else if(sceneNum == 2){
            if(type == 1){
                withoutScore = true;
            }else if(type == 2){
                withoutScore = false;
            }
            refreshSingleNpc(1,100,"Hello!",true);
            refreshSingleNpc(2,80,"¥……&*@……&*！@？？？!",false);
            refreshSingleNpc(3,95,"Hey girl!I think we can be good friends!",true);
            refreshSingleNpc(4,95,"Hello!!",true);
            refreshSingleNpc(5,100,"You are so pretty!",true);
            refreshSingleNpc(6,70,"*****************",false);
            refreshSingleNpc(7,100,"What a shame!",true);
            refreshSingleNpc(8,100,"Could you be my friend?",true);
            refreshSingleNpc(9,85,"I have lots of girlFriend",false);
            refreshSingleNpc(10,84,"You are stupid!",false);
            refreshSingleNpc(11,82,"¥……&*@……&*！@？？",false);
            refreshSingleNpc(12,100,"What?",true);
        }else if(sceneNum == 3){
            withoutScore = false;
            if(type == 1){
                myScore = 70;
            }else if(type == 2){
                myScore = 100;
            }
            refreshSingleNpc(1,100,"Hello!",true);
            refreshSingleNpc(2,80,"¥……&*@……&*！@？？？!",false);
            refreshSingleNpc(3,95,"Hey girl!I think we can be good friends!",true);
            refreshSingleNpc(4,95,"Hello!!",true);
            refreshSingleNpc(5,100,"You are so pretty!",true);
            refreshSingleNpc(6,70,"*****************",false);
            refreshSingleNpc(7,100,"What a shame!",true);
            refreshSingleNpc(8,100,"Could you be my friend?",true);
            refreshSingleNpc(9,85,"I have lots of girlFriend",false);
            refreshSingleNpc(10,84,"You are stupid!",false);
            refreshSingleNpc(11,82,"¥……&*@……&*！@？？",false);
            refreshSingleNpc(12,100,"What?",true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Z 初始模式
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if(sceneNum == 3){
                return;
            }
            refreshNps(1);
        }
        // X 应用了积分系统后的模式
        if (Input.GetKeyDown(KeyCode.X))
        {
            if(sceneNum == 3){
                return;
            }
            refreshNps(2);
        }
        // N 进入下一场景
        if (Input.GetKeyDown(KeyCode.N))
        {
            if(sceneNum < 3){
                sceneNum = sceneNum + 1;
            }
            pageNum = 1;
            refreshPageShow();
            refreshHelpPosition();
            refreshNps(1);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            hideHelp();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            refreshHelpPosition();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
