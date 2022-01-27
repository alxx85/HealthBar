using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Presenter : MonoBehaviour
{
    [SerializeField] private Slider _sliderHP;
    [SerializeField] private float _changeSpeed;

    private float _currentHealth = 50f;


    private void Start()
    {
        _sliderHP.value = _currentHealth;
    }

    private void Update()
    {
        if (_currentHealth != _sliderHP.value)
        {
            _sliderHP.value = Mathf.MoveTowards(_sliderHP.value, _currentHealth, _changeSpeed * Time.deltaTime);
        }
    }

    public void ChangeHealth(float value)
    {
        _currentHealth += value;
    }
}
