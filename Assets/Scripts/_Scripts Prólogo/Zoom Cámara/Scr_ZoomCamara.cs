﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ZoomCamara : MonoBehaviour
{
    GameObject camara;

    private void Start()
    {
        camara = GameObject.Find("Main Camera");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            camara.GetComponent<Camera>().orthographicSize = 10;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            camara.GetComponent<Camera>().orthographicSize = 8;
        }
    }
}