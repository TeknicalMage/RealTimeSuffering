using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Copyright (C) Xenfinity LLC - All Rights Reserved
 * Unauthorized copying of this file, via any medium is strictly prohibited
 * Proprietary and confidential
 * Written by Bilal Itani <bilalitani1@gmail.com>, June 2017
 */

public class ObjectResource : MonoBehaviour {

    [SerializeField] private float _speed = 0;
    public GameObject cam;
    public Camera wewow;

    public float wt;

    void Start(){
        wewow = Camera.main;
        wt = 20;
    }

    void Update()
    {
        Camera.main.orthographicSize = wt;
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            
            if (Physics.Raycast(ray, out hit)) {
                if (hit.transform.name == "PowerButton" ){
                    cam.GetComponent<Resource>().addpower (5);
                }
            }
        }
        
        //Movement Moment
 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cam.transform.position += new Vector3(0, 1, 0) * _speed * Time.deltaTime; 
        }else if(Input.GetKey(KeyCode.DownArrow)){
            cam.transform.position += new Vector3(0, -1, 0) * _speed * Time.deltaTime; ;
        }else if(Input.GetKey(KeyCode.LeftArrow)){
            cam.transform.position += new Vector3(-1, 0, 0) * _speed * Time.deltaTime; ;
        }else if(Input.GetKey(KeyCode.RightArrow)){
            cam.transform.position += new Vector3(1, 0, 0) * _speed * Time.deltaTime; ;
        }else if(Input.GetKey(KeyCode.X)){
            wt += 1;
        }else if (Input.GetAxis("Mouse ScrollWheel") > 0f ){
            wt--;
        }else if (Input.GetAxis("Mouse ScrollWheel") < 0f ){
            wt++;
        }

    }
    
}
