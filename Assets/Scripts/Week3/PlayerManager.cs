//Ignore the first three lines for now and don't change them!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//We are going to engage with the code that is just inside the class. From line 7 onwards.
public class PlayerManager : MonoBehaviour
{ //curly brackets are used to tell the compiler where things start and end. They should always have a matching closing curly bracket.
    public float myHealth = 100.0f;
    int myStrength = 1000;



    // Start is called before the first frame update
    // The start function is where you initialise values and settings for different objects.
    void Start()
    {
        myHealth = 100.0f;
        myStrength = 1000;

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, 1, 0);
        }
        CheckHealth();

        Debug.Log(myHealth + " ");

    }

 

    public void IncreaseHealth(float amount)
    {
      
          myHealth += amount; //same as saying myHealth = myHealth + amount;

        //When health is above 70, increase health by half the amount
        if(myHealth >= 70.0f)
        {
            myHealth += (amount / 2.0f); //same as saying myHealth + amount;
        }
        else if (myHealth <=50)
        {
            myHealth += ( amount * 2.0f );
        }
        else
        {
            myHealth += amount;
        }
        }


    //Controlling the maximum and minimum of player health
   
    void CheckHealth()
    {
        if (myHealth > 100.0f)
        {
            myHealth = 100.0f;
        }
        if (myHealth < 0f)
        {
            myHealth = 0f;
        }
    }
    public void ReduceHealth(float amount)
    {
        myHealth -= amount;

        if (myHealth > 100) {
            myHealth = 100;
        }
        if (myHealth < 0)
        {
            myHealth = 0;
        }

        print(myHealth +" ");
    }
    public void IncreaseStrength(int amount)
    {
        myStrength += amount;
        if (myStrength > 100) {
            myStrength = 100;
        }
        if (myStrength < 0)
        {
            myStrength = 0;
        }

        print(myStrength +" ");

    }
    public void ReduceStrength(int amount)
    {
        myStrength -= amount;
        if (myStrength > 100) {
            myStrength = 100;
        }
        if (myStrength < 0)
        {
            myStrength = 0;
        }

        print(myStrength +" ");
    }


}
