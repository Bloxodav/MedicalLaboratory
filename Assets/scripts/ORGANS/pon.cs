using UnityEngine;

public class pon : MonoBehaviour
{
    public GameObject objectToActivate; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("heart"))
        {
            objectToActivate.SetActive(true);

            Destroy(other.gameObject); 
           
        }
    }
}
