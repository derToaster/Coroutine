using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }



    private void Gamestop()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Countdown(int seconds)
    {
        int counter = seconds;
        while (counter > 0)
        {
            yield return new WaitForSeconds(1);
            print(counter + " seconds remaining");
            counter--;
        }
        Gamestop();
    }


    private void OnTriggerEnter(Collider col)
    
    { 
        StopCoroutine(Countdown(5));
    }

    private void OnTriggerExit(Collider col)
    {
        StartCoroutine(Countdown(5));
    }
}
