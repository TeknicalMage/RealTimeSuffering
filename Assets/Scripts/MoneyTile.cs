using System.Collections;
using System.Collections.Generic;   
using UnityEngine;

public class MoneyTile : MonoBehaviour
{



    public Transform Square;
    public GameObject cam;

    public GameObject obj;

    void Start(){
        
       
    }


    private void OnTriggerEnter2D (Collider2D collider){
        print("Drop");

    }

    private void OnTriggerStay2D(Collider2D collider){
        
        string val = (collider.gameObject.name);
        obj = GameObject.Find(val);
        if (collider.gameObject.name == val){
            if(cam.GetComponent<Resource>().power > 0){ 
                cam.GetComponent<Resource>().addmoney (1);
                cam.GetComponent<Resource>().subtractpower (100);
            }
                       
        }
    }

    


}
