using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Action4 : MonoBehaviour
{
    public GameObject infText;
    public GameObject actionText;
    public GameObject button;


    public Sprite spr;

    
    public Text infText1;

    public bool isUsed;

    


    private void Update()
    {
        OnTriggerStay(GetComponent<Collider>());
    }

    private void OnTriggerEnter(Collider other)
    {
        
        infText1.text = "Я могу применить предмет ";
        if (other.tag == "Player")
            infText.SetActive(true);
        isUsed = true;

        
    }

    private void OnTriggerStay(Collider other)
    {

        if ((Input.GetKeyDown(KeyCode.Alpha4) & isUsed == true) & button.GetComponent<Image>().sprite == spr )
        {
            actionText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        infText.SetActive(false);
        actionText.SetActive(false);
        isUsed = false;
        
    }




}
