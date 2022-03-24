using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoComputador : MonoBehaviour
{
    [SerializeField] private float _intervalo = 0.8f;
    private Aviao _aviao;

    void Start()
    {
        _aviao = GetComponent<Aviao>();
        StartCoroutine(Impulsionar());
    }

    private IEnumerator Impulsionar()
    {
        while (true)
        {
            yield return new WaitForSeconds(_intervalo);
            _aviao.DarImpulso();
        }
    }
}
