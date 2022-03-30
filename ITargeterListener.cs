using System;
using UnityEngine;
public interface ITargeterListener
{
    void FoundTarget(Transform target);
    void LostTarget();
}
