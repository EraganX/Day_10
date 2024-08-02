using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Sprite[] _sprite;
    [SerializeField] private int level = 0;

    private SpriteRenderer _spriteRender;

    private void Awake()
    {
        _spriteRender = GetComponent<SpriteRenderer>();
        _spriteRender.sprite = _sprite[level];
    }

    private void CheckHealth()
    {
        level--;

        if (level<0)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            _spriteRender.sprite = _sprite[level];
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            CheckHealth();
        }
    }

}
