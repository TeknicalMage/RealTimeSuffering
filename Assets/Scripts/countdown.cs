using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
    
{

    public float timeStart = 0;
    public Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();
    }

    public void showtime(){

        print(timeStart);


    }



}
