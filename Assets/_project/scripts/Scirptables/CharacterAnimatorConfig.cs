using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character Animator", menuName = "ScriptableObjects/SimpleFPS/Character Animator")]
public class CharacterAnimatorConfig : ScriptableObject
{
    public Vector3 ModelPositionOffset;
    public Vector3 SpineRotationOffset;
}