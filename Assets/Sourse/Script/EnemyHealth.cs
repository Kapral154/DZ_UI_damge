using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    public event UnityAction<float> _healthChange;

    private float _health = 100;
    private float _maxHealth;
    private float _minHealth = 0;

    private void Start()
    {
        _maxHealth = _health;
    }

    public void TakeDamage(float damage)
    {
        _health = Mathf.Clamp(_health -= damage, _minHealth, _maxHealth);
        _healthChange?.Invoke(_health);
    }

    public void Heal(float treatment)
    {
        _health = Mathf.Clamp(_health += treatment, _minHealth, _maxHealth);
        _healthChange?.Invoke(_health);
    }
}
