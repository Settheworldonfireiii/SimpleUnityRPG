using System;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest001Take : MonoBehaviour {

    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject uIQuest;
    
    public GameObject noticeCam;
    public GameObject thePlayer;
    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;

    }


    private void OnMouseOver()
    {

        if (theDistance <= 3.0)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);


        }
        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 3.0)
            {
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                uIQuest.SetActive(true);
                noticeCam.SetActive(true);
                thePlayer.SetActive(false);
                /*WaitNSeconds(15);
                uIQuest.SetActive(false);
                noticeCam.SetActive(false);
                thePlayer.SetActive(true); */
            }

        }

    }
    private void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

    private void WaitNSeconds(int segundos)
    {
        if (segundos < 1) return;
        System.DateTime _desired = DateTime.Now.AddSeconds(segundos);
        while (DateTime.Now < _desired)
        {
            
        }
    }

}
