using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlenderSound : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
	}

    void OnBecameVisible()
    {
        GetComponent<AudioSource>().Play();
    }

    void OnBecameInvisible()
    {
        GetComponent<AudioSource>().Stop();
    }
}
