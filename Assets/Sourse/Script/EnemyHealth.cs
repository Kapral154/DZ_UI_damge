using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private Animator _animation;
    [SerializeField] private SliderBar _slider;
    [SerializeField] private UnityEvent<float> _reached;

    private float _health = 100;
    private float _maxHealth;
    private float _minHealth = 0;
    private string _animatorDamage = "Damage";
    private string _animatorHilling = "Hilling";

    private void Start()
    {
        _maxHealth = _health;
    }

    public void TakeDamage(float damage)
    {
        _animation.SetTrigger(_animatorDamage);
        _health = Mathf.Clamp(_health -= damage, _minHealth, _maxHealth);

        _reached.Invoke(_health);
    }

    public void GetTreatment(float treatment)
    {
        _animation.SetTrigger(_animatorHilling);
        _health = Mathf.Clamp(_health += treatment, _minHealth, _maxHealth);

        _reached.Invoke(_health);
    }
}
