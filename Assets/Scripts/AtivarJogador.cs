using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AtivarJogador : MonoBehaviour
{
    [SerializeField] private UnityEvent onTerminarAnimacao;
    // Chamado na animação
    public void AtivarFisicaNoJogador()
    {
        onTerminarAnimacao.Invoke();
    }
}
