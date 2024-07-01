using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cognitive3D;
public class RecordCustomEvent : MonoBehaviour
{
    public string eventName;

    public void WriteEvent()
    {
        CustomEvent customEvent = new CustomEvent(eventName);
        customEvent.Send();
    }
}
