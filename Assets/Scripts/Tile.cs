using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{


    //Base Tile, No Buffs or Boons
    public Transform Square;
    public GameObject cam;

    public GameObject obj;



    public int ye;

    public bool forest;
    public bool metals;



    




    

    

    void Start(){
        int ye = 0;
        int numtile = Random.Range(1, 5);
        string nametile = numtile.ToString();
        //string swap = "";
        print(nametile);

        switch(numtile){
            case 1:
                forest = true;
                break;
            case 2:
                metals = true;
                break;
        }

        //0 means the tile is not Occupied
    }
    


    IEnumerator Test(){
        yield return new WaitForSeconds (5);
    }

    private void OnTriggerEnter2D (Collider2D collider){
        string val = (collider.gameObject.name);
        obj = GameObject.Find(val);

        if(val.Contains("Solar") || (val.Contains("City"))){
            if(ye == 0){
                print("Tile Is Ocp'd");
                ye = 1;
            }else if(ye == 1){
                print("bad get fucked");
                Destroy(obj);
                ye = 1;

            }
        }
    }

    void OnMouseOver(){
        if(ye == 0){
        this.GetComponent<SpriteRenderer>().color = Color.blue;;
        }
    }
    
    void OnMouseExit(){
        this.GetComponent<SpriteRenderer>().color = Color.gray;;
        //Outline.SetActive(false);

    }

    private void OnTriggerStay2D(Collider2D collider){
        string val = (collider.gameObject.name);
        obj = GameObject.Find(val);
        string tile_type = (this.name);
        if(forest == true){
            cam.GetComponent<Resource>().addmoney (500);
        }else if(metals == true){
            cam.GetComponent<Resource>().addmoney (500);
        }
        
    }
    private void OnTriggerExit2D(Collider2D collider){
        if(ye == 1){
            ye = 0;
        }
    }
    
}
