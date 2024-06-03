using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;
    private Vector3 posicaoInicial;
    private float tamanhoDaImagem;

    void Awake()
    {
        this.posicaoInicial = this.transform.position;
        this.tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoDaImagem);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
