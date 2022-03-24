using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiretorMultiplayer : Diretor
{
    private bool _alguemMorto;
    private int _pontosDesdeAMorte = 0;
    [SerializeField] private int _pontosParaReviver;
    private Jogador[] _jogadores;
    private InterfaceCanvasInativo _interfaceInativo;

    protected override void Start()
    {
        base.Start();
        _jogadores = FindObjectsOfType<Jogador>();
        _interfaceInativo = FindObjectOfType<InterfaceCanvasInativo>();
    }

    public void AvisarAlguemMorreu(Camera cam)
    {
        if (_alguemMorto)
        {
            _interfaceInativo.Sumir();
            FinalizarJogo();
        }
        else
        {
            _alguemMorto = true;
            _pontosDesdeAMorte = 0;
            _interfaceInativo.AtualizarTextoPontos(_pontosParaReviver);
            _interfaceInativo.Mostrar(cam);
        }
    }

    public void ReviverSePrecisar()
    {
        if (_alguemMorto)
        {
            _pontosDesdeAMorte++;
            _interfaceInativo.AtualizarTextoPontos(_pontosParaReviver - _pontosDesdeAMorte);
            if(_pontosDesdeAMorte >= _pontosParaReviver)
            {
                ReviverJogadores();
                _interfaceInativo.Sumir();
            }
        }        
    }

    public void ReviverJogadores()
    {
        _alguemMorto = false;
        foreach (Jogador jogador in _jogadores)
        {
            jogador.Ativar();
        }
    }

    public override void ReiniciarJogo()
    {
        base.ReiniciarJogo();
        ReviverJogadores();
    }
}
