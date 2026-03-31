using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Da : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    Gameobject presser;
    private bool isPressed;
    private GameObject pressed;

    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            Debug.Log("worked");
            pressed = other.gameObject;
            onPress.Invoke();
            isPressed = true;
        }
    }
    private void OnTriggerExit(UnityEngine.Collider other)
    {
        if (other == pressed)
        {
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void SpawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sphere.transform.localPosition = new Vector3(0, 1, 2);
        sphere.AddComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {

    }

    private void OnTrigerEnter(Collider other)
    {
        Debug.Log("worked");
    }
    
}

internal class Gameobject
{
}