using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactor : MonoBehaviour
{
    public virtual void Interact(Transform interactionSource)
    {
        var interactions = GetInteractions(interactionSource);

        if (interactions != null)
        {
            foreach (var interaction in interactions)
            {
                interaction.Interact(interactionSource);
            }
        }
    }

    public abstract Interactable[] GetInteractions(Transform interactionSource);
}