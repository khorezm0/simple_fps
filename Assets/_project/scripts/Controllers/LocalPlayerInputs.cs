using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Works with CharacterMovementController
public class LocalPlayerInputs : MonoBehaviour
{
    public InputsController inputs;
    private CharacterMovementController _movementController;

    private void Awake()
    {
        _movementController = GetComponent<CharacterMovementController>();
    }

    private void LateUpdate()
    {
        _movementController.UpdateMovement(new Vector2(inputs.look.x, -1 * inputs.look.y), inputs.move, inputs.jump, inputs.strafe > 0.1f, Time.deltaTime);
    }
}