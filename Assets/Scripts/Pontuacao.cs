using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text textoPontuacao;
    [SerializeField]
    private int faseCena1;
    [SerializeField]
    private int faseCena2;
    private int pontos;
    private AudioSource audioPontuacao;

    private void Awake()
    {
        this.audioPontuacao = this.GetComponent<AudioSource>();
    }

    public void AdicionarPontos()
    {
        this.pontos++;
        this.textoPontuacao.text = this.pontos.ToString();
        this.audioPontuacao.Play();
        //muda de fase
        if ((pontos == this.faseCena1) && (SceneManager.GetActiveScene().name == "Jogo"))
        {
                SceneManager.LoadScene("JogoCena_2");
        }
        else if((pontos == this.faseCena2) && (SceneManager.GetActiveScene().name == "JogoCena_2"))
        {
            SceneManager.LoadScene("Jogo");
            //Debug.Log("zerou");
        }

    }

    public void Reiniciar()
    {
        this.pontos = 0;
        this.textoPontuacao.text = this.pontos.ToString();
    }
}
