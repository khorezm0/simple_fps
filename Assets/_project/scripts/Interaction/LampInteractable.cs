using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampInteractable : Interactable
{
    public Light light;

    public override void Interact(Transform interactorTransform)
    {
        light.gameObject.SetActive(true);
        light.enabled = true;
    }
}