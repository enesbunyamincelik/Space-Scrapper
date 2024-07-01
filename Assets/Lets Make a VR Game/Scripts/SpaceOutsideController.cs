using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class SpaceOutsideController : MonoBehaviour
{
    public XRLever lever; 
    public XRKnob knob;

    public float forwardSpeed;
    public float sideSpeed;

    private bool wasOn;

    // Update is called once per frame
    void Update()
    {
        float forwardVelocity = forwardSpeed * (lever.value ? 1 : 0); // if the lever is on we are setting the lever to 1 if it is not the case, off, we are setting the value to 0.
        float sideVelocity = sideSpeed * (lever.value ? 1 : 0) * Mathf.Lerp(-1, 1, knob.value);

        Vector3 velocity = new Vector3(sideVelocity, 0, forwardVelocity);
        transform.position += velocity * Time.deltaTime;

        if(lever.value != wasOn)
        {
            if (lever.value)
            {
                AudioManager.instance.Play("Engine");
            }
            else
            {
                AudioManager.instance.Stop("Engine");
            }
        }

        wasOn = lever.value;
    }
}
