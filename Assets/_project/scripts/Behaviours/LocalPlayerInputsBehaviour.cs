using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalPlayerInputsBehaviour : MonoBehaviour
{
    public InputsController inputs;
    private CharacterMovementController _movementController;
    private WeaponController _weaponController;

    private void Awake()
    {
        _movementController = GetComponent<CharacterMovementController>();
        _weaponController = GetComponent<WeaponController>();
    }

    private void LateUpdate()
    {
        _movementController.UpdateMovement(new Vector2(inputs.look.x, -1 * inputs.look.y), inputs.move, inputs.jump, inputs.strafe > 0.1f, Time.deltaTime);
        if (inputs.weapon > 0) _weaponController.SetWeapon(inputs.weapon);
        if (inputs.scroll.y > 0.1f) _weaponController.SwitchToNextWeapon();
        else if (inputs.scroll.y < -0.1f) _weaponController.SwitchToPrevWeapon();
    }
}