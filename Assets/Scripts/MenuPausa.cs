using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject painel;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            AbrirPainel();
        }
    }

    public void AbrirPainel()
    {
        painel.SetActive(true);
        Time.timeScale = 0;
    }

    public void FecharPainel()
    {
        Time.timeScale = 1;
        painel.SetActive(false);
    }

    public void Sair()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
