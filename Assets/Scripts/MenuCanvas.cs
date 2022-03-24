using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCanvas : MonoBehaviour
{
   public void CarregarScena(int index)
    {
        SceneManager.LoadScene(index);
    }
}
