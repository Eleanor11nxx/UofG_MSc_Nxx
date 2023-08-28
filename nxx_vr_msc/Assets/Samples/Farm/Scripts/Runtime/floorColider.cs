using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorColider : MonoBehaviour
{
    private int score = 0;
    public GameObject scoreManager;
    Dictionary<int, bool> dict = new Dictionary<int, bool>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // 碰撞开始
    private void OnCollisionEnter(Collision collision) {
        // Debug.Log("开始碰撞" + collision.gameObject.name);
        int id = collision.gameObject.transform.GetInstanceID();
        if(collision.gameObject.tag =="AppleStem"){
            if(dict.ContainsKey(id))
            {

            }else{
                dict.Add(id, true);
                score = score + 1;
                if(score >= 15){
                    GameObject obj = GameObject.Find("SceneManager");
                    obj.GetComponent<SceneManager>().refreshNps(2);
                }
                Debug.Log("当前积分" + score);
            }
        }
    }
 
     // 碰撞结束
    private void OnCollisionExit(Collision collision) {

    }
 
     // 碰撞持续中
    private void OnCollisionStay(Collision collision) {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
