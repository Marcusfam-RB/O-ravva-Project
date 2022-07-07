using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StopUsing : MonoBehaviour
{
    public Action3 action;

    


    private void OnTriggerStay(Collider other)
    {
        if (action.isUsedAgain == true)
        {
            action.infText.SetActive(false);
            Action3.Destroy(action);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        action.actionText.SetActive(false);
    }

}
