using UnityEngine;
using UnityEngine.Serialization;

public abstract class HealthViewer : MonoBehaviour
{
    [SerializeField] protected Health Health;
    
    private void OnEnable()
    {
        Health.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        Health.HealthChanged -= OnHealthChanged;
    }
    
    protected abstract void OnHealthChanged(float healthValue);
}