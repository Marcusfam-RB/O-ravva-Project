using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowText : MonoBehaviour
{
    public GameObject text;
    public Text txt;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            text.SetActive(true);
            txt.text = " Нажмите F, что бы подобрать предмет ";
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            text.SetActive(false);
    }

    private void OnDisable()
    {
        if (text != null)
            text.SetActive(false);
    }
}
