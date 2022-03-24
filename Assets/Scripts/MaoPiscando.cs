using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaoPiscando : MonoBehaviour
{
    private SpriteRenderer _sprite;

    private void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Desaparecer();
        }
    }

    private void Desaparecer()
    {
        _sprite.enabled = false;
    }
    
}
