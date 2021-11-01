using UnityEngine;
using UnityEngine.InputSystem;

//Listens for Inputs from InputSystem
public class InputsController : MonoBehaviour
{
    public Vector2 move;
    public Vector2 look;
    public float fire;//Trigger
    public float reload;
    public float interact;
    public float jump;
    public float strafe;

    public void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }

    public void OnLook(InputValue value)
    {
        look = value.Get<Vector2>();
    }

    public void OnFire(InputValue context)
    {
        fire = context.Get<float>();
    }

    public void OnReload(InputValue context)
    {
        reload = context.Get<float>();
    }

    public void OnInteract(InputValue context)
    {
        interact = context.Get<float>();
    }

    public void OnJump(InputValue context)
    {
        jump = context.Get<float>();
    }

    public void OnStrafe(InputValue context)
    {
        strafe = context.Get<float>();
    }
}