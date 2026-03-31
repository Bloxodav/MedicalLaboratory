using UnityEngine;

public class lung : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject objectToHide;
    public bool activated = false;
    public string objectTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(objectTag))
        {
           
            objectToActivate.SetActive(true);
            Destroy(other.gameObject);
            objectToHide.SetActive(false);
            
        }
    }
}
