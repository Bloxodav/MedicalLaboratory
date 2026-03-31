using UnityEngine;

public class PrinterTrigger : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject buttons;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("heart") || other.CompareTag("lung") || other.CompareTag("brain") ||
            other.CompareTag("glaz") || other.CompareTag("lungs") || other.CompareTag("man") ||
            other.CompareTag("penis") || other.CompareTag("pechen") || other.CompareTag("kid") ||
            other.CompareTag("st"))
        {
            buttons.SetActive(false);
            targetObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("heart") || other.CompareTag("lung") || other.CompareTag("brain") ||
            other.CompareTag("glaz") || other.CompareTag("lungs") || other.CompareTag("man") ||
            other.CompareTag("penis") || other.CompareTag("pechen") || other.CompareTag("kid") ||
            other.CompareTag("st"))
        {
            buttons.SetActive(true);
            targetObject.SetActive(false);
        }
    }
}