using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Action3 : MonoBehaviour
{
    public GameObject infText;
    public GameObject actionText;
    public GameObject button;


    public Sprite spr;

    
    public Text inf;

    public bool isUsed;
    public bool isUsedAgain;

    


    private void Update()
    {
        OnTriggerStay(GetComponent<Collider>());
    }

    private void OnTriggerEnter(Collider other)
    {
        
        inf.text = "Я могу применить предмет ";
        if (other.tag == "Player")
            infText.SetActive(true);
        isUsed = true;


        
    }

    private void OnTriggerStay(Collider other)
    {

        if ((Input.GetKeyDown(KeyCode.Alpha3) & isUsed == true) & button.GetComponent<Image>().sprite == spr )
        {
            actionText.SetActive(true);
            isUsedAgain = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        infText.SetActive(false);
        actionText.SetActive(false);
        isUsed = false;
        
    }




}
