using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resource : MonoBehaviour
{
    
    public double power;
    public Text powerText;


    public double money;
    public Text moneyText;

    int time;

    void Start()
    {
        power = 10000;
        money = 1000;
        powerText.text = power.ToString ();
        moneyText.text = money.ToString ();
        
    }

    
    // Update is called once per frame
    void Update()
    {
        time+=1;
        powerText.text = power.ToString ();
        moneyText.text = money.ToString ();
        
    }


    public void addpower(double powertoAdd){
        power += powertoAdd;
        powerText.text = power.ToString ();

    }

    public void subtractpower(double powertoSubtract){
        power -= powertoSubtract;
    }

    public void addmoney(double moneytoAdd){
        money += moneytoAdd;
        moneyText.text = money.ToString ();

    }

    public void subtractmoney(double moneytoSubtract){
        money -= moneytoSubtract;
    }

}
