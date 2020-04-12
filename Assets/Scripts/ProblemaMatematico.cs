using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemaMatematico : MonoBehaviour
{
    public bool resolvido;
    public string problema;
    public int solucao;
    public int[] solucoes;
    public Sprite valor1, valor2, operador;
    SpriteRenderer spriteRenderer;

    public ProblemaMatematico(string problema, int solucao)
    {
        this.problema = problema;
        this.solucao = solucao;
        resolvido = false;
        solucoes = new int[4];
        for (int i = 0; i < solucoes.Length; i++)
        {
            solucoes[i] = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.GetComponentInChildren<SpriteRenderer>();
        spriteRenderer.sprite = valor1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
