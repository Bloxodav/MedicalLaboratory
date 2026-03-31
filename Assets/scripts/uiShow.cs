using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class uiShow : MonoBehaviour
{
    public SteamVR_Action_Boolean ShowAction;
    public GameObject Ui;
    private Interactable interactable;
  
    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    
    void Update()
    {
        if(interactable.attachedToHand != null)
        {
            SteamVR_Input_Sources source = interactable.attachedToHand.handType;
            if (ShowAction[source].stateDown)
            {
                ShowUI();
            }
        }
    }
    private void ShowUI()
    {
        Ui.SetActive(!Ui.activeSelf);
    }
}
