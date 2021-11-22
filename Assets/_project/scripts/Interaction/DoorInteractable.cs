using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractable : Interactable
{
    public Transform Target;
    public Vector3 RotationOrigin;
    public Vector3 OpenState = new Vector3(0, 90, 0);
    public Vector3 CloseState = new Vector3(0, 0, 0);
    public float AnimationTime = 1;
    public bool Test;

    private bool _isOpen;

    private void Start()
    {
        if (!Target)
        {
            Target = transform;
        }

        if (RotationOrigin.sqrMagnitude > 0.1f)
        {
            var gm = new GameObject(name + "_Pivot");
            gm.transform.rotation = Target.rotation;
            gm.transform.position = Target.TransformPoint(RotationOrigin);
            Target.SetParent(gm.transform);
            Target = gm.transform;
        }
    }

    private void Update()
    {
        if (Test)
        {
            Test = false;
            Toggle();
        }
    }

    public override void Interact(Transform interactorTransform)
    {
        //TODO: можно сделать чтобы дверь открывалась от стороны игрока
        Toggle();
    }

    public void Toggle()
    {
        SetState(!_isOpen);
    }

    public void SetState(bool isOpen)
    {
        _isOpen = isOpen;
        if (_isOpen)
        {
            Target.localRotation = Quaternion.Euler(OpenState);
        }
        else
        {
            Target.localRotation = Quaternion.Euler(CloseState);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color32(78, 50, 168, 120);
        Gizmos.DrawSphere(transform.TransformPoint(RotationOrigin), 0.25f);
        Gizmos.color = Color.white;
    }
}