using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour {
    
    private Aviao _aviao;
    private Pontuacao _pontucao;
    private InterfaceGameOver _interface;

    protected virtual void Start()
    {
        _aviao = FindObjectOfType<Aviao>();
        _pontucao = FindObjectOfType<Pontuacao>();
        _interface = FindObjectOfType<InterfaceGameOver>();
        _interface.EsconderInterface();
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        _pontucao.SalvarRecorde();
        _interface.MostrarInterface();
    }

    public virtual void ReiniciarJogo()
    {
        Time.timeScale = 1;
        _aviao.Reiniciar();
        _interface.EsconderInterface();
        DestruirObstaculos();
        _pontucao.Reiniciar();        
    }

    private void DestruirObstaculos()
    {
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach(Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
