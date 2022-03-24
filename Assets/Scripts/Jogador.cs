using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    private Carrossel[] cenario;
    private GeradorDeObstaculos obstaculo;
    private Aviao _aviao;
    private bool estouMorto = false;

    private void Start()
    {
        cenario = GetComponentsInChildren<Carrossel>();
        obstaculo = GetComponentInChildren<GeradorDeObstaculos>();
        _aviao = GetComponentInChildren<Aviao>();
    }

    public void Desativar()
    {
        obstaculo.Parar();
        estouMorto = true;
        foreach (Carrossel carrossel in cenario)
        {
            carrossel.enabled = false;
        }
    }

    public void Ativar()
    {
        if(!estouMorto) { return; }

        _aviao.Reiniciar();
        obstaculo.Recomecar();
        
        foreach (Carrossel carrossel in cenario)
        {
            carrossel.enabled = true;
        }
        estouMorto = false;
    }
}
