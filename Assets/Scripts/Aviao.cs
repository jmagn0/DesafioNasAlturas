using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Aviao : MonoBehaviour {
    private Rigidbody2D fisica;
    [SerializeField]
    private float forca;
    [SerializeField] private UnityEvent onBater;
    [SerializeField] private UnityEvent onPassarObstaculo;    
    private Vector3 posicaoInicial;
    private bool _deveImpulsionar;
    private Animator _animacao;


    private void Awake()
    {
        posicaoInicial = transform.position;
        fisica = GetComponent<Rigidbody2D>();
        _animacao = GetComponent<Animator>();
    }

    private void Update()
    {
        _animacao.SetFloat("VelocidadeY", fisica.velocity.y);
    }

    private void FixedUpdate () {

        if (_deveImpulsionar)
        {
            Impulsionar();
            _deveImpulsionar = false;
        }
    }

    public void DarImpulso()
    {
        _deveImpulsionar = true;
    }

    public void Reiniciar()
    {
        transform.position = posicaoInicial;
        fisica.simulated = true;
    }

    private void Impulsionar()
    {
        fisica.velocity = Vector2.zero;
        fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        fisica.simulated = false;
        onBater?.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onPassarObstaculo?.Invoke();
    }
}
