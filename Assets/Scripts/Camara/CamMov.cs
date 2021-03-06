﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMov : MonoBehaviour {

    public Transform Target;
    public float OffsetX;
    public float OffsetY;
    public float FollowSpeed;

    private void Awake()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Target = GameObject.Find("Aura").transform;
    }

    void LateUpdate () {
        transform.position = Vector3.Lerp(transform.position, new Vector3(Target.position.x + OffsetX, Target.position.y + OffsetY, transform.position.z), Time.deltaTime * FollowSpeed);
    }
}