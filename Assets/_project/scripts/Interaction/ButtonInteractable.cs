using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteractable : Interactable
{
    public bool once;
    public bool indicatorState;
    public Interactable[] NextInteractables;
    public GameObject IndicatorOn;
    public GameObject IndicatorOff;

    private bool _isInteracted;

    public override void Interact(Transform interactorTransform)
    {
        if (_isInteracted && once) return;

        _isInteracted = true;
        indicatorState = !indicatorState;

        if (IndicatorOn)
        {
            IndicatorOn.SetActive(indicatorState);
        }
        if (IndicatorOff)
        {
            IndicatorOff.SetActive(!indicatorState);
        }

        foreach (var interactable in NextInteractables)
        {
            interactable.Interact(transform);
        }
    }
}