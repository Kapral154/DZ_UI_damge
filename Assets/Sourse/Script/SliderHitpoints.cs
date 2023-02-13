using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderHitpoints : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private float _rateChange = 15;

    public float Value;

    void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, Value, _rateChange * Time.deltaTime);
    }

    public void SetHitpoints(float health)
    {
        Value = health;
    }
}
