using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private UnityEvent _changeHealth;

    public float Health => _health;

    public void TakeDamage(float value)
    {
        _health -= value;
        _changeHealth?.Invoke();
    }

    public void TakeHealth(float value)
    {
        _health += value;
        _changeHealth?.Invoke();
    }
}
