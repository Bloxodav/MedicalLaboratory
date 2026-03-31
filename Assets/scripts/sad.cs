using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sad : MonoBehaviour
{
    public GameObject prefab;
    public GameObject organF;
    public GameObject prefabNew; 
    public Transform spawnPoint; 
    public bool spawned = false;
    public string boolName;
    public string boolNameOrgan;
    public string boolNameSpawn;
    [SerializeField] private Animator animator;
    [SerializeField] private Animator animatorSpawn;
    
    [SerializeField] private Animator animatorOrgan;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pencil") && spawned == false)
        {
            prefab.SetActive(true);
            animator.SetBool(boolName, true);
            animatorOrgan.SetBool(boolNameOrgan, true);
        }
        if(other.gameObject.CompareTag("pencil") && spawned == true)
        {
            prefab.SetActive(true);
            animator.SetBool(boolName, true);
            animatorSpawn.SetBool(boolNameSpawn, true);
        }
    }
    public void Spawn()
    {
        Instantiate(prefabNew, spawnPoint.position, spawnPoint.rotation);
    }
    public void ChangeBool()
    {
        spawned = true;
    }
    public void ActivateOrgan()
    {
        organF.SetActive(true);
    }
}
