using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class organAnim : MonoBehaviour
{
    public string boolNameSpawn;
    [SerializeField] private Animator animator;
    public GameObject organF;
    public GameObject prefab;
    public GameObject prefabNew;
    public Transform spawnPoint;
    public bool spawned = false;
    public Sad buttonScript;
    
    public void Spawn()
    {
        Instantiate(prefabNew, spawnPoint.position, spawnPoint.rotation);
    }
    public void ChangeBool()
    {
       buttonScript.spawned = true;
        spawned = true;
    }
    public void ActivateOrgan()
    {
        organF.SetActive(true);
    }
    public void CangeBoolAnim()
    {
        animator.SetBool(boolNameSpawn, false);
    }
    public void Hide()
    {
        prefab.SetActive(false);
    }
}
