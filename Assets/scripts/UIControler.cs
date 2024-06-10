using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIControler : MonoBehaviour
{
    // Start is called before the first frame update
    private int pontos;
    private Label textoPontuacao;

    public void adicionarPontos()
    {
        this.textoPontuacao.text = this.pontos.ToString();
        this.pontos++;
    }
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        this.textoPontuacao = root.Q<Label>("pontos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
