﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdvertisingScreen : MonoBehaviour {

    public int nextSceneIndex;
	// Use this for initialization
	void Start () {
        Invoke("LoadScene", 3.5f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnLevelWasLoaded(int level)
    {
        //Invoke("LoadScene", 2.0f);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(nextSceneIndex);
    }
}