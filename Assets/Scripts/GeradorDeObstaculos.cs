using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour {
    [SerializeField] private float tempoParaGerarFacil;
    [SerializeField] private float tempoParaGerarDificil;
    [SerializeField] private GameObject _prefabObstaculo;
    private float cronometro;
    private ControleDeDificuldade _controleDificuldade;
    private bool _parado = false;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerarFacil;    
    }

    private void Start()
    {
        _controleDificuldade = FindObjectOfType<ControleDeDificuldade>();
    }

    void Update () {

        if (_parado) { return; }

        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
           GameObject.Instantiate(this._prefabObstaculo, this.transform.position, Quaternion.identity);
            this.cronometro = Mathf.Lerp(tempoParaGerarFacil, tempoParaGerarDificil, _controleDificuldade.Dificuldade);
        }
    }

    public void Parar()
    {
        _parado = true;
    }

    public void Recomecar()
    {
        _parado = false;
    }
}


