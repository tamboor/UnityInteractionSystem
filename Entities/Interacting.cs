using System;
using System.Collections.Generic;
using UnityEngine;
public class Interacting : MonoBehaviour , ITargeterListener
{
    //TODO: find a way to apply materials on found target.
    //TODO: create a script to taise InteractWith
    //[HideInInspector]
    [SerializeField]
    private Interactable targetedInteractable;

    Targeter targeter;

    public void InteractWithTargeted()
    {
        InteractWith(targetedInteractable);
    }


    public void InteractWith(Interactable interactable)
    {
        //TODO: change to custom condition
        if (interactable.enabled)
        {
            interactable.Interact(this);
        }
    }

    public void FoundTarget(Transform target)
    {
        if(target.TryGetComponent(out Interactable interactable))
        {
            targetedInteractable = interactable;
        }
    }
    protected virtual void OnTarget()
    {
        //TODO: Apply shader
    }

    public void LostTarget()
    {
        //TODO: remove applied shader
    }


    private void OnEnable() { targeter.listeners.Add(this); }

    private void OnDisable() { targeter.listeners.Remove(this); }

}
