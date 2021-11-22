using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionBehaviour : MonoBehaviour
{
    public InputsController inputs;
    public Transform sourceTransform;
    public float delay = 0.2f;

    private Interactor _interactor;

    private float _lastInteraction;

    private void Awake()
    {
        _interactor = GetComponent<Interactor>();
    }

    private void Update()
    {
        if (inputs.interact > 0.1f && Time.time - _lastInteraction > delay)
        {
            _lastInteraction = Time.time;
            _interactor.Interact(sourceTransform);
        }
    }
}