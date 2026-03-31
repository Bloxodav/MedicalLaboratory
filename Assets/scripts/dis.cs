using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dis : MonoBehaviour
   
{   public GameObject gameObject;
    public Collision collision;
    // Start is called before the first frame update
    void Start()
    {
        gameObject= GetComponent<GameObject>();
        collision = gameObject.GetComponent<Collision>();   
        OnCollisionEnter(collision);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "pencil")
        {
            this.gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
