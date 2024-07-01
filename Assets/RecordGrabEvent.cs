using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Cognitive3D;
using System;

public class RecordGrabEvent : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    private DynamicObject dynamicObject;

    // Start is called before the first frame update
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        dynamicObject = GetComponent<DynamicObject>();

        grabInteractable.selectEntered.AddListener(RecordGrab);
        grabInteractable.selectExited.AddListener(RecordRelease);
    }

    private void RecordGrab(BaseInteractionEventArgs args)
    {
        dynamicObject.BeginEngagement("Grabbing");
    }
    
    private void RecordRelease(BaseInteractionEventArgs args)
    {
        dynamicObject.EndEngagement("Grabbing");
    }
}
