using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShowPlace : MonoBehaviour
{
   [SerializeField] public GameObject objectToShow;
   

    public void Pick()
    {
        if (!objectToShow.activeSelf)
        {
            objectToShow.SetActive(true);
        }
    }

    public void Detach()
    {
        if (objectToShow.activeSelf)
        {
            objectToShow.SetActive(false);
            Debug.Log("Toshi");
        }
       
    }
}
