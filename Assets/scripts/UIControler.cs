using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIControler : MonoBehaviour
{
    // Start is called before the first frame update
    public int pontos;
    private Label textoPontuacao;

    public void adicionarPontos()
    {
        this.pontos++;
        this.textoPontuacao.text = this.pontos.ToString();
    }
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        this.textoPontuacao = root.Q<Label>("pontos");
    }

}
