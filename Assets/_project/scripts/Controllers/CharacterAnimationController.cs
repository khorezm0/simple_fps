using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    public Transform HeadRoot;
    public Transform ModelRoot;
    public Animator Animator;
    public CharacterAnimatorConfig Config;

    //Test
    public Transform IKLeft, IKRight;

    private AnimatorIKListener _ikListener;
    private Quaternion _spineLookOffset;

    private void Awake()
    {
        _ikListener = Animator.GetComponent<AnimatorIKListener>();
        if (_ikListener == null)
        {
            _ikListener = Animator.gameObject.AddComponent<AnimatorIKListener>();
        }
        if (gameObject != Animator.gameObject)
        {
            _ikListener.OnIkPass += OnAnimatorIK;
        }
    }

    private void Start()
    {
        if (Config != null)
        {
            ModelRoot.localPosition = ModelRoot.localPosition + Config.ModelPositionOffset;
            _spineLookOffset = Quaternion.Euler(Config.SpineRotationOffset);
        }
        else
        {
            LogWarn("ANIM: Config is not set");
        }
    }

    public void OnAnimatorIK(int layer)
    {
        //Animator.SetLookAtWeight(1, 0.5f, 1);
        //Animator.SetLookAtPosition(HeadRoot.position + (HeadRoot.rotation * Quaternion.Euler(Config.SpineRotationOffset) * (Vector3.forward * 0.5f)));
        //Animator.GetBoneTransform(HumanBodyBones.LeftShoulder);

        //Animator.SetBoneLocalRotation(HumanBodyBones.LeftShoulder, Quaternion.LookRotation(transform.TransformDirection(HeadRoot.forward)) * Quaternion.Euler(Config.SpineRotationOffset));

        Animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
        Animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        Animator.SetIKPosition(AvatarIKGoal.LeftHand, IKLeft.position);
        Animator.SetIKPosition(AvatarIKGoal.RightHand, IKRight.position);
    }

    private void OnDestroy()
    {
        _ikListener.OnIkPass -= OnAnimatorIK;
    }

    private void Log(object message)
    {
        Debug.Log(message, gameObject);
    }

    private void LogWarn(object message)
    {
        Debug.LogWarning(message, gameObject);
    }
}