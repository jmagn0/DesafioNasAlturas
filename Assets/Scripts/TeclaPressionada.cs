using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TeclaPressionada : MonoBehaviour
{
    [SerializeField] private KeyCode _tecla;
    [SerializeField] private UnityEvent onTeclaPressionada;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(_tecla))
        {
            onTeclaPressionada?.Invoke();
        }
    }
}
