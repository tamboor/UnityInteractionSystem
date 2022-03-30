using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public delegate void InteractionDelegate(Interacting interacting);
    public event InteractionDelegate InteractionEvent;



    public void Interact(Interacting interacting)
    {
        InteractionEvent.Invoke(interacting);
    }
}
