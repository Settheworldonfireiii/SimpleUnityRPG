using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollect : MonoBehaviour {
    public int rotationSpeed;
    public AudioSource collectSound;
    public GameObject thatsHeart;
	// Use this for initialization
	void Start () {
        rotationSpeed = 2;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
		
	}


    private void OnTriggerEnter()
    {
        collectSound.Play();
        thatsHeart.SetActive (false);
        HealthMonitor.healthValue += 1;
    }
}
