using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorIKListener : MonoBehaviour
{
    public event System.Action<int> OnIkPass;

    private void OnAnimatorIK(int layer)
    {
        OnIkPass?.Invoke(layer);
    }
}