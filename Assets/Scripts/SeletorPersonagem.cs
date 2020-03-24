using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeletorPersonagem : MonoBehaviour
{

    private GameObject[] personagemList;

    private int index;
    private void Start()
    {
        index = PlayerPrefs.GetInt("PersonagemSelecionado");

        personagemList = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            personagemList[i] = transform.GetChild(i).gameObject;
        }
        foreach (GameObject ir in personagemList)
            ir.SetActive(false);
        if (personagemList[index])
            personagemList[index].SetActive(true);

    }
    //avannçar esquerda
    public void ToggleLeft()
    {
        personagemList[index].SetActive(false);

        index--;//index -= 1; index = index - 1
        if (index < 0)
            index = personagemList.Length - 1;

        personagemList[index].SetActive(true);

    }
    //avannçar direita
    public void ToggleRight()
    {
        personagemList[index].SetActive(false);

        index++;//index -= 1; index = index - 1
        if (index == personagemList.Length)
            index = 0;

        personagemList[index].SetActive(true);

    }
    public void ConfirmaButton()
    {
        PlayerPrefs.SetInt("PersonagemSelecionado", index);
        SceneManager.LoadScene("Jogo");
    }

}
