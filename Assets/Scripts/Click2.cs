using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Copyright (C) Xenfinity LLC - All Rights Reserved
 * Unauthorized copying of this file, via any medium is strictly prohibited
 * Proprietary and confidential
 * Written by Bilal Itani <bilalitani1@gmail.com>, June 2017
 */

public class Click2 : MonoBehaviour {

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
                if (hit.transform.name == "Button4" ){
                    print("ok");
                    if(cam.GetComponent<Resource>().money > 500){
                        cam.GetComponent<Resource>().subtractmoney (500); 
                        Instantiate(spawnee, spawnpos.position, spawnpos.rotation);

                    }
                        
                }else if(hit.transform.name == "PRNT"){
                    print("Hit");
                }
            }
        }
    }
}
