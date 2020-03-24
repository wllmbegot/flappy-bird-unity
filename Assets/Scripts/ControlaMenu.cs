using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlaMenu : MonoBehaviour
{

    public GameObject BotaoSair;

    private void Start()
    {
    #if UNITY_STANDALONE || UNITY_EDITOR

        BotaoSair.SetActive(true);

    #endif
    }

    public void JogarJogo()
    {
        //Debug.Log("Mudou de /cena");
        SceneManager.LoadScene("Jogo");
    }

    public void SairDoJogo()
    {
        //Debug.Log("Mudou de /cena");
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

}

