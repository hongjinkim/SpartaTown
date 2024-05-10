using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class CharacterAnimationController : AnimationController
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

    private readonly float magnituteThreshold = 0.5f;

    [SerializeField] private RuntimeAnimatorController[] playerAnimator;

    protected override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        controller.OnMoveEvent += Move;
        animator.runtimeAnimatorController = playerAnimator[PlayerPrefs.GetInt("character_index")];
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > magnituteThreshold);
    }

}
