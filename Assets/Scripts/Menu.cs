using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    
    private GameObject[] personagemList;
    private int index;

    private SeletorPersonagem seletorPersonagem;

    private Aviao aviao;

    public GameObject BotaoOpcao;
    public GameObject BotaoExit;
    public GameObject PainelOpcao;
    public GameObject PainelMenu;

	private void Start ()
    {

        this.seletorPersonagem = GameObject.FindObjectOfType<SeletorPersonagem>();
        this.aviao = GameObject.FindObjectOfType<Aviao>();

        #if UNITY_STANDALONE || UNITY_EDITOR

        BotaoExit.SetActive(true);
        BotaoOpcao.SetActive(true);

        #endif



    }


    void Update () {
		
	}

    public void ToggleRight()
    {
        personagemList[index].SetActive(false);

        index++;//index -= 1; index = index - 1
        if (index == personagemList.Length)
            index = 0;

        personagemList[index].SetActive(true);

    }

    public void ToggleLeft()
    {
        personagemList[index].SetActive(false);

        index--;//index -= 1; index = index - 1
        if (index < 0)
            index = personagemList.Length - 1;

        personagemList[index].SetActive(true);

    }

    public void Bt_Start()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void Bt_Exit()
    {  
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }


    public void Bt_Option()
    {
        try
        {

            PainelMenu.SetActive(false);
            PainelOpcao.SetActive(true);

            



        }
        catch (System.Exception)
        {

            throw;
        }

    }

    public void Bt_AviaoRed()
    {
        PlayerPrefs.SetInt("PersonagemSelecionado", index);
        SceneManager.LoadScene("Jogo");
    }

}
