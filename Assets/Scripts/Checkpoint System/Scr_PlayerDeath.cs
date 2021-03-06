﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Scr_PlayerDeath : MonoBehaviour
{
    GameObject Aura;
    GameObject camara;

    Vector3 checkpoint;
    string checkpointName;

    private void Start()
    {
        Aura = GameObject.Find("Aura");
        camara = GameObject.Find("Main Camera");

        DontDestroyOnLoad(Aura);
        DontDestroyOnLoad(camara);
    }

    private void Update()
    {
        checkpoint = Scr_PlayerCheckpoint.checkpoint;
        checkpointName = Scr_PlayerCheckpoint.checkpointName;

        //Debug.Log("Last checkpoint (" + checkpointName + ") position: " + checkpoint); // NO BORRAR
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Death();
        }
    }

    void Death()
    {
        SceneManager.LoadScene("Playtest", LoadSceneMode.Single);

        Aura.transform.position = checkpoint;
    }
}