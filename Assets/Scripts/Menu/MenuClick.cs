using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Copyright (C) Xenfinity LLC - All Rights Reserved
 * Unauthorized copying of this file, via any medium is strictly prohibited
 * Proprietary and confidential
 * Written by Bilal Itani <bilalitani1@gmail.com>, June 2017
 */

public class MenuClick : MonoBehaviour {

    public Transform spawnpos;
    public GameObject spawnee;
    public GameObject cam;

    
    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            
            if (Physics.Raycast(ray, out hit)) {
                if (hit.transform.name == "PRNT" ){
                    print("ok");
                    //SceneManager.LoadScene("MapFull");
                    
                }else if(hit.transform.name == "x4"){
                    print("Hit");
                }
            }
        }
    }
    void OnMouseOver(){
        this.GetComponent<SpriteRenderer>().color = Color.blue;;
    }
    
    void OnMouseExit(){
        this.GetComponent<SpriteRenderer>().color = Color.red;;
        //Outline.SetActive(false);

    }

    



}
