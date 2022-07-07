using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AddToInventory : MonoBehaviour
{
    public GameObject button;
    public Sprite spr;
    public bool isInCollider = false;
    

    private void Update()
    {
        OnTriggerStay(this.GetComponent<Collider>());
    }

    private void OnTriggerEnter(Collider other)
    {
        isInCollider = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isInCollider = false;
    }

    private void OnTriggerStay(Collider other )
    {
        if (Input.GetKeyDown(KeyCode.F) &  isInCollider == true)
        {
            this.gameObject.SetActive(false);
            button.GetComponent<Image>().sprite = spr;          
            
        }
    }
    


}
