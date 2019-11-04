using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveInput : MonoBehaviour
{
    public SteamVR_ActionSet m_ActionSet;

    public SteamVR_Action_Boolean m_BooleanAction;
    public SteamVR_Action_Vector2 m_ToughPosition;


    void Awake()
    {
        m_BooleanAction = SteamVR_Actions._default.GrabPinch;

        //#region Events
        //m_BooleanAction[SteamVR_Input_Sources.Any]onStateDown += BoolTest;

    }
    // Update is called once per frame
    void Update()
    {
    }

    private void BoolTest(SteamVR_Action_Boolean action, SteamVR_Input_Sources source)
    {

    }
}
