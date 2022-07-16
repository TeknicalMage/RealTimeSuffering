using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarField : MonoBehaviour
{

    public GameObject cam;
    public GameObject obj;
    public GameObject notobj;

    public bool solar;

    
   

    void Start(){
        //this.GetComponent<Collider2D>().enabled = true;
        solar = false;
        StartCoroutine("i2");
    }

  
    private void OnTriggerEnter2D (Collider2D collider){
        if (collider.gameObject.name == "Tile"){
        }
        
    }

    void OnMouseDrag(){
        print("DRAG");
        this.GetComponent<Collider2D>().enabled = false;
        
        
    }

    void OnMouseUp(){
        this.GetComponent<Collider2D>().enabled = true;


    }   

  

    private void OnTriggerStay2D(Collider2D collider){
        this.GetComponent<Collider2D>().enabled = true;
        
        
        string hitlocation = (collider.gameObject.name);
        string iam = (this.gameObject.name);

        Vector3 linePos = GameObject.Find(hitlocation).transform.position;
        obj = GameObject.Find(iam);
        


        if ((collider.gameObject.name == hitlocation) && (hitlocation.Contains("Square") != true)){
            obj.transform.position = linePos;
            solar = true;         
        }
    }

    private void OnTriggerExit2D(Collider2D collider){
        solar = false;
    }

    private IEnumerator i2(){
        print("ok");

        while(true){
            if(solar){
                yield return new WaitForSeconds(1);
                print("WaitAndPrint " + Time.time);
                cam.GetComponent<Resource>().addpower (100);
            }
            else if (!solar){
                //cam.GetComponent<Resource>().addpower (0);
                yield return new WaitForSeconds(1);
                print(Time.time);
            }
        }

        

        

    }



    void Update()
    {
        if (solar == true){
            //print("On");
            
        }
        else if(solar == false){
            //print("Off"); 
        }
        
        
    }
    


}
