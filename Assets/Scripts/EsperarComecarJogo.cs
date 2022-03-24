using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsperarComecarJogo : MonoBehaviour
{
    Coroutine coroutine;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().simulated = false;
        coroutine = StartCoroutine(ComecarTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Comecar();
            StopCoroutine(coroutine);
        }
    }

    public void Comecar()
    {
        GetComponent<Rigidbody2D>().simulated = true;
        this.enabled = false;
    }

    IEnumerator ComecarTimer()
    {
        yield return new WaitForSeconds(2);
        Comecar();
    }
}
