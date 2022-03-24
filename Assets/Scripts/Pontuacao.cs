using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour {
   [SerializeField]
    private Text textoPontuacao;
    private AudioSource audioPontuacao;
    [SerializeField] UnityEvent onPontuar;
    public int Pontos { get; private set; }

    private void Awake()
    {
        audioPontuacao = GetComponent<AudioSource>();
    }

    public void AdicionarPontos()
    {
        Pontos++;
        textoPontuacao.text = Pontos.ToString();
        audioPontuacao.Play();
        onPontuar.Invoke();
    }

    public void Reiniciar()
    {
        Pontos = 0;
        textoPontuacao.text = Pontos.ToString();
    }

    public void SalvarRecorde()
    {
        int record = PlayerPrefs.GetInt("recorde");

        if(Pontos > record)
        {
            PlayerPrefs.SetInt("recorde", Pontos);
        }
    }

    public void CarregarPontuacao()
    {
        PlayerPrefs.GetInt("recorde");
    }
}
