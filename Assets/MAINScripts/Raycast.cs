using UnityEngine;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;

public class Raycast : MonoBehaviour
{
    public GameObject lastHit;
    private GameObject changed;
    private XRGrabInteractable lastGrabbed;
    private XRGrabInteractable currentGrabbed;
    private XRGrabInteractable wasGrabbed;
    public XRGrabInteractable[] grabbedThings;
    private int sequenceNum;

    private void Start()
    {
        changed = this.gameObject;
        lastGrabbed = new XRGrabInteractable();
        currentGrabbed = new XRGrabInteractable();
    }

    public bool TouchingTravel()
    {
        RaycastHit hit;
        var ray = new Ray(this.transform.position, this.transform.forward);
        if (Physics.Raycast(ray, out hit, 50))
        {
            lastHit = hit.transform.gameObject;
        }
        return lastHit.gameObject.tag == "Travel";
    }

    void Update()
    {

        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;

        var ray = new Ray(this.transform.position, this.transform.forward);
        currentGrabbed = new XRGrabInteractable();

        foreach (XRGrabInteractable grabbedThing in grabbedThings)
        {
            if (grabbedThing.isSelected)
            {
                currentGrabbed = grabbedThing;
            }
        }


        if (Physics.Raycast(ray, out hit, 50))
        {
            lastHit = hit.transform.gameObject;
            //if (lastGrabbed != currentGrabbed && lastHit.tag == "SequencePad")
            //if (lastHit.tag == "SequencePad")
            //{
            // lastGrabbed.gameObject.transform.SetParent(lastHit.gameObject.transform, true);
            // sequenceNum = int.Parse(lastHit.gameObject.name);
            //   PlaySoundsOnBeat._strum[sequenceNum%4] = lastGrabbed.gameObject.GetComponent<AudioSource>().clip;
            //}


            if (lastHit.gameObject.tag == "SequencePad") //if (lastHit.tag == "SequencePad")
            {
                lastHit.GetComponent<Renderer>().material.SetColor("_Color", Color.magenta);
                //if (currentGrabbed != wasGrabbed)
                //{
                ////     // currentGrabbed.gameObject.transform.SetParent(lastHit.gameObject.transform);
                //    wasGrabbed.gameObject.transform.position = lastHit.gameObject.transform.position;

                //}
            }


            if (changed.tag == "SequencePad" && lastHit != changed)
            {
                changed.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
            }
            changed = hit.transform.gameObject;
            //  lastGrabbed = currentGrabbed;
        }

        Debug.DrawRay(transform.position, fwd, Color.green);

        foreach (XRGrabInteractable grabbedThing in grabbedThings)
        {
            if (grabbedThing.isSelected)
            {
                wasGrabbed = grabbedThing;
            }
        }


        //if (controller.Controller)
        //if (lastHit.tag=="SequencePad")
        //    lastHit.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        //else
        //    lastHit.GetComponent<Renderer>().material.SetColor("_Color", lastOrigColor);


    }
}
