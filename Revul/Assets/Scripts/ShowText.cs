using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowText : MonoBehaviour
{
    public GameObject textInf;
    public Text txt;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            textInf.SetActive(true);
            txt.text = " Нажмите F, что бы подобрать предмет ";
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            textInf.SetActive(false);
    }

    private void OnDisable()
    {
        if (textInf != null)
            textInf.SetActive(false);
    }
}
