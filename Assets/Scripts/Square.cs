using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{

    public GameObject cam;
    public GameObject obj;
    public GameObject notobj;


  
    private void OnTriggerEnter2D (Collider2D collider){
        if (collider.gameObject.name == "Tile"){
        }
        
    }

    private void OnTriggerStay2D(Collider2D collider){
        
        
        string hitlocation = (collider.gameObject.name);
        string iam = (this.gameObject.name);

        Vector3 linePos = GameObject.Find(hitlocation).transform.position;
        obj = GameObject.Find(iam);
        


        if ((collider.gameObject.name == hitlocation) && (hitlocation.Contains("Square") != true)){
            obj.transform.position = linePos;          
        }
    }
    


}
