using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _health;
    [SerializeField] private UnityEvent _changeHealth;

    public float Health => _health;
    public float MaxHealth => _maxHealth;

    public void TakeDamage(float value)
    {
        if (_health > 0)
        {
            _health -= value;
            _changeHealth?.Invoke();
        }
    }

        public void TakeHealth(float value)
    {
        if (_health < _maxHealth)
        {
            _health += value;
            _changeHealth?.Invoke();
        }
    }
}
