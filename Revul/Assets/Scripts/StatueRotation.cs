using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using UnityEngine;

public class StatueRotation : MonoBehaviour
{

    public float smooth = 95.0f;
    [SerializeField]
    private float rotationStep = 90.0f;

    [SerializeField] private float properAngle;
    
    public bool isRotated;

    private Vector3 newRot;
    private Vector3 currentRot;
    private Quaternion targetRot;

    public bool properPos;

    private AudioSource audio;

    void Start()
    {
        currentRot = transform.eulerAngles;
        targetRot = transform.rotation;

        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        currentRot = transform.eulerAngles;

        if (Quaternion.Angle(transform.rotation, Quaternion.Euler(0f, properAngle, 0f)) < 1f)
        {
            properPos = true;
        }
        else
        {
            properPos = false;
        }

        if (isRotated && Input.GetKeyDown(KeyCode.F))
        {
            audio.Play();

            targetRot = Quaternion.Euler(0f, rotationStep, 0f) * targetRot;
        }
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, smooth * Time.deltaTime);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        isRotated = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isRotated = false;
    }
}
