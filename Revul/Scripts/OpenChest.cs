using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChest : MonoBehaviour
{
    public GameObject inftext;    
    public GameObject contains;

    public ShowText showtext;


    public Text text;

    

    public bool isOpen;




    private void OnTriggerEnter(Collider other)
    {
        if (isOpen == false)
        {
            text.text = "Нажмите F, что бы открыть сундук";
        }
        inftext.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F) & other.tag == "Player")
        {
            this.GetComponent<Renderer>().material.color = Color.white;
            this.GetComponent<Collider>().enabled = false;
            contains.SetActive(true);
            isOpen = true;
            inftext.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inftext.SetActive(false);
    }
}
