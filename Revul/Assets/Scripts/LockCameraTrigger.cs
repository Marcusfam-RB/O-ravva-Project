using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCameraTrigger : MonoBehaviour
{
    public bool near;

    public GameObject cam;
    public bool cameraIsActive;
    public bool playerIsActive = true; 
    public Lock lockPuzzle;
    public GameObject prompt;
    public GameObject player;
    public int frame = 0;
    public bool cursorIsVisible;

    void Start()
    {
        prompt.SetActive(false);
        cam.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (lockPuzzle.wasSolved)
        {
            frame += 1;
            if (frame == 1)
            {
                prompt.SetActive(false);
                cam.SetActive(false);
                player.SetActive(true);
                GetComponent<BoxCollider>().enabled = false;
            }
        }
        else if (near && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Escape)))
        {
            cameraIsActive = !cameraIsActive;
            cursorIsVisible = cameraIsActive;
            if (lockPuzzle.wasSolved)
            {
                cursorIsVisible = false;
            }
            cam.SetActive(cameraIsActive);

            playerIsActive = !playerIsActive;
            player.SetActive(playerIsActive);
            
            prompt.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        near = true;
        prompt.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        near = false;
        prompt.SetActive(false);
    }
}