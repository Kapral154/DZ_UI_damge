using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private Coroutine _coroutine;
    private float _rateChange = 20;

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
