using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatuePuzzle : MonoBehaviour
{
    public StatueRotation foxScript;
    public StatueRotation rabbitScript;
    public StatueRotation bearScript;
    public StatueRotation wolfScript;
    

    public CapsuleCollider foxCollider;
    public CapsuleCollider rabbitCollider;
    public CapsuleCollider bearCollider;
    public CapsuleCollider wolfCollider;

    public GameObject door;
    // public Transform startMarker;
    // public Transform endMarker;
    public Animator animCup;
    public float speed = 0.001f;
    public float startTime;
    public float journeyLength;

    public float distCovered;
    public int frame = 0;

    private AudioSource audio;

    public bool wasSolved;

    void Start()
    {
        //journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
        audio = door.GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (wolfScript.properPos && bearScript.properPos && rabbitScript.properPos && foxScript.properPos)
        {
            wasSolved = true;
            frame += 1;
            if (frame == 1)
            {
                startTime = Time.time;
                
                audio.Play();
            }
            LiftDoor();
            ForbidRotating();
        }
    }

    void LiftDoor()
    {
        animCup.SetBool("cup", true);
       // distCovered = (Time.time - startTime) * speed;
       // if (door.transform.position.y < endMarker.position.y)
        //{
            //float fractionOfJourney = distCovered / journeyLength;
            //door.transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);
       // }
    }

    void ForbidRotating()
    {
        wolfCollider.enabled = false;
        rabbitCollider.enabled = false;
        foxCollider.enabled = false;
        bearCollider.enabled = false;
        wolfScript.isRotated = false;
        rabbitScript.isRotated = false;
        foxScript.isRotated = false;
        bearScript.isRotated = false;
    }
}