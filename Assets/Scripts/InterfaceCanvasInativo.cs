using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceCanvasInativo : MonoBehaviour
{
    [SerializeField] private GameObject _fundo;
    [SerializeField] private Text _textoPontosParaReviver;
    private Canvas _canvas;


    private void Awake()
    {
        _canvas = GetComponent<Canvas>();
    }

    public void Mostrar(Camera cam)
    {
        _fundo.SetActive(true);
        _canvas.worldCamera = cam;
    }

    public void Sumir()
    {
        _fundo.SetActive(false);
    }

    public void AtualizarTextoPontos(int pontosParaReviver)
    {
        _textoPontosParaReviver.text = pontosParaReviver.ToString();
    }
}
