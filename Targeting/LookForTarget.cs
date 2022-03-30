using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookForTarget : Targeter
{
    [HideInInspector]
    public bool shouldSearch = true;

    [SerializeField]
    [Tooltip("Set to the transform looking towards target.")]
    Transform looker;

    [SerializeField]
    LayerMask interactableLayers;

    [SerializeField]
    float castDistance;


    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(looker.position, looker.forward, out hit, castDistance, interactableLayers))
        {
            target = hit.transform;
            return;
        }
        target = null;
    }

    private void OnDisable()
    {
        target = null;
    }
}
