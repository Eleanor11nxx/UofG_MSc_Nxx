using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using Zinnia.Tracking.Collision;
using Zinnia.Pointer;
public class OnShot : MonoBehaviour
{
   
   
    public void selected_event(ObjectPointer.EventData val)
    {
        // Debug.Log("selected_event" + val);
        if (val is null){
            return;
        }
        // Debug.Log("CollisionData" + val.CollisionData);
        //RaycastHit
        Transform transform = val.CollisionData.transform;
        Debug.Log(transform.gameObject.name);
        if (transform.gameObject.name == "Joint"){
            for (int i = 1;i <= 6;i ++){
                transform = transform.parent;
                if (transform is null){
                    return;
                }
            }
            GameObject obj = transform.gameObject;
            Debug.Log(obj.name);
            Npc npc = obj.GetComponent<Npc>();
            if (npc is null){
                return;
            }
            npc.banit();
        }
        if (transform.gameObject.name == "arrow1"){
            GameObject parentObject = GameObject.Find("SceneManager");
            parentObject.GetComponent<SceneManager>().nextPage();
        }
        if (transform.gameObject.name == "arrow2"){
            GameObject parentObject = GameObject.Find("SceneManager");
            parentObject.GetComponent<SceneManager>().lastPage();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // public virtual void Add(CollisionNotifier.EventData collisionData)
    // {
    //     Debug.Log("selected_event" + collisionData);
    // }

    // public virtual void Add(ObjectPointer.UnityEvent collisionData)
    // {
    //     Debug.Log("selected_event" + collisionData);
    // }
}
