using UnityEngine;

// Setting up our scene
// store controllers

public class Game : MonoBehaviour
{
    public InputsController inputs;

    private void Start()
    {
        Time.fixedDeltaTime = 0.005f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}