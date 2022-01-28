using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Presenter : MonoBehaviour
{
    [SerializeField] private Slider _sliderHP;
    [SerializeField] private float _changeSpeed;
    [SerializeField] private PlayerStats _player;

    private float _currentHealth;
    private Coroutine _changeHealthView;
    private WaitForEndOfFrame _wait = new WaitForEndOfFrame();

    private void Awake()
    {
        _sliderHP.value = _player.Health;
    }

    public void ChangeHealth()
    {
        if (_changeHealthView != null)
        {
            StopCoroutine(_changeHealthView);
        }
        _currentHealth = _player.Health;
        _changeHealthView = StartCoroutine(ChangeViewHealth());
    }

    private IEnumerator ChangeViewHealth()
    {
        while (_sliderHP.value != _currentHealth)
        {
            _sliderHP.value = Mathf.MoveTowards(_sliderHP.value, _currentHealth, _changeSpeed * Time.deltaTime);
            yield return _wait;
        }
    }
}
