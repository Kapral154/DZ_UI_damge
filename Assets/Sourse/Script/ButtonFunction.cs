using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunction : MonoBehaviour
{
    [SerializeField] private EnemyHealth _enemy;

    private float _damge = 10;
    private float _treatment = 10;

    public void AppyTreatment()
    {
        _enemy.GetTreatment(_treatment);
    }

    public void MakeDamage()
    {
        _enemy.TakeDamage(_damge);
    }
}
