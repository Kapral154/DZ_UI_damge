using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private EnemyHealth _enemyHealth;

    private Coroutine _coroutine;
    private float _rateChange = 20;

    private void Start()
    {
        _enemyHealth._healthChange += SetHitpoints;       
    }

    private void OnDestroy()
    {
        _enemyHealth._healthChange -= SetHitpoints;
    }

    public void SetHitpoints(float value)
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(ChangeHealth(value));
    }

    private IEnumerator ChangeHealth(float value)
    {       
        while (_slider.value != value)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, value, _rateChange * Time.deltaTime);
            yield return null;
        }
    }
}
