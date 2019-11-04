using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SteamVRActionTest : MonoBehaviour
{
    [SerializeField]
    private SteamVR_Input_Sources m_controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SteamVR_Actions._default.GrabPinch.GetStateDown(m_controller))
        {
            Debug.Log("Trigger Pressed Down.");
            this.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
        }
        else if(SteamVR_Actions._default.GrabPinch.GetStateUp(m_controller))
        {
            Debug.Log("Trigger Released.");
            this.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
        }
    }
}
