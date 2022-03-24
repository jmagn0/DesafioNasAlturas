using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDeDificuldade : MonoBehaviour
{
    [SerializeField] private float _tempoParaDificuldadeMaxima;
    private float _tempoPassado;
    public float Dificuldade { get; private set; }

    // Update is called once per frame
    void Update()
    {
        _tempoPassado += Time.deltaTime;
        Dificuldade = Mathf.Clamp(_tempoPassado / _tempoParaDificuldadeMaxima, 0, 1);
    }

    public float GetDificuldade()
    {
        return Dificuldade;
    }
}
