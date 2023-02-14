using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Animation : MonoBehaviour
{
    [SerializeField] private Animator _animation;

    private string _animatorDamage = "Damage";
    private string _animatorHilling = "Hilling";

    public void TakeDamage()
    {
        _animation.SetTrigger(_animatorDamage);
    }

    public void Heal()
    {
        _animation.SetTrigger(_animatorHilling);
    }
}
