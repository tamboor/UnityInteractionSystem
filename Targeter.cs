using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Targeter : MonoBehaviour
{
    public List<ITargeterListener> listeners = new List<ITargeterListener>();

    private Transform _target;
    protected Transform target
    {
        get => _target;
        set
        {
            if (value != _target)
            {
                if (value == null)
                {
                    _target = null;
                    listeners.ForEach(l => l.LostTarget());
                    return;
                }
                _target = value;
                listeners.ForEach(l => l.FoundTarget(_target));
            }
        }
    }



}
