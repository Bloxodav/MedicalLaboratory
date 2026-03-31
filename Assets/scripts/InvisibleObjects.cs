using System.Collections.Generic;
using UnityEngine;

public class InvisibleObjects : MonoBehaviour
{
    public GameObject manPrefab; 
    public List<GameObject> objectsToDelete; 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("man"))
        {
            foreach (GameObject go in objectsToDelete)
            {
                Destroy(go);
            }
        }
    }
}
