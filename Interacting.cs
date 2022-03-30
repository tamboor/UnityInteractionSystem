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


    private void InteractWith(Interactable interactable)
    {
        interactable.Interact(this);
    }

    public void FoundTarget(Transform target)
    {
        if(target.TryGetComponent(out Interactable interactable))
        {
            targetedInteractable = interactable;
        }
    }
    protected virtual void OnTarget()
    { }

    public void LostTarget()
    {
        throw new NotImplementedException();
    }


    private void OnEnable() { targeter.listeners.Add(this); }

    private void OnDisable() { targeter.listeners.Remove(this); }

}
