using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField] private Text _valorRecorde;
    [SerializeField] private GameObject imagemGameOver;
    [SerializeField] private Image _medalhaPosicao;
    [SerializeField] private Sprite _medalhaOuro;
    [SerializeField] private Sprite _medalhaPrata;
    [SerializeField] private Sprite _medalhaBronze;
    private Pontuacao _pontuacao;
    private int record;

    private void Start()
    {
        _pontuacao = FindObjectOfType<Pontuacao>();
    }

    private void AtualizarInterfaceGrafica()
    {
        record = PlayerPrefs.GetInt("recorde");
        _valorRecorde.text = record.ToString();

        VerificarMedalha();
    }

    public void MostrarInterface()
    {
        AtualizarInterfaceGrafica();
        imagemGameOver.SetActive(true);
    }

    public void EsconderInterface()
    {
        imagemGameOver.SetActive(false);
    }

    private void VerificarMedalha()
    {
        if(_pontuacao.Pontos > record - 2)
        {
            _medalhaPosicao.sprite = _medalhaOuro;
        }
        else if(_pontuacao.Pontos > record / 2)
        {
            _medalhaPosicao.sprite = _medalhaPrata;
        }
        else
        {
            _medalhaPosicao.sprite = _medalhaBronze;
        }
    }
}
