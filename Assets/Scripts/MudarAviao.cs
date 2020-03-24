using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarAviao : MonoBehaviour {

    public GameObject aviaoRed, aviaoYellow;


    int aviaoAtivo = 1;


	// Use this for initialization
	void Start () {

        //aviaored.gameobject.setactive(true);
        //aviaoyellow.gameobject.setactive(false);

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void TrocaAviao()
    {
        switch (aviaoAtivo)
        {
            case 1:
                aviaoAtivo = 2;
                aviaoYellow.gameObject.SetActive(true);
                break;


            case 2:
                aviaoAtivo = 1;
                aviaoRed.gameObject.SetActive(true);
                break;

        }
    }

}
