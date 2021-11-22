using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastInteractor : Interactor
{
    public LayerMask LayerMask;
    public float MaxDistance = 4;
    public QueryTriggerInteraction TriggerInteractionMode = QueryTriggerInteraction.Ignore;

    public override Interactable[] GetInteractions(Transform interactionSource)
    {
        if (Physics.Raycast(interactionSource.position, interactionSource.forward, out RaycastHit hit, MaxDistance, LayerMask, TriggerInteractionMode))
        {
            return hit.collider.GetComponentsInParent<Interactable>();
        }

        return null;
    }
}