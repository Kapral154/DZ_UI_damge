using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private Animator _animation;
    [SerializeField] private SliderHitpoints _slider;

    private float _health = 100;
    private float _maxHealth;
    private float _minHealth = 0;

    private void Start()
    {
        _maxHealth = _health;
    }

    private void Update()
    {
        _slider.Value = _health;
    }

    public void TakeDamage(float damage)
    {
        _animation.SetTrigger("Damage");

        if (_health > _minHealth)
        {
            _health -= damage;
        }      
    }

    public void GetTreatment(float treatment)
    {
        _animation.SetTrigger("Hilling");

        if (_health < _maxHealth)
        {
            _health += treatment;
        }
    }
}
