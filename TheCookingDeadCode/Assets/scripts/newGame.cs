using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class newGame : MonoBehaviour {
    private Button btnnG;
    private bool clickedBtn = false;

    void Start()
    {
        btnnG = GetComponent<Button>();
        btnnG.onClick.AddListener(Lvl);
    }

    void Lvl()
    {

        if (!clickedBtn)
        {
            GameObject.Find("Canvas/nouvelle_partie/cuisiner").SetActive(true);
            GameObject.Find("Canvas/nouvelle_partie/explorer").SetActive(true);
            clickedBtn = true;
        }

        else
        {
            GameObject.Find("Canvas/nouvelle_partie/cuisiner").SetActive(false);
            GameObject.Find("Canvas/nouvelle_partie/explorer").SetActive(false);
            //TODO: mettre a zero toutes les variables pour une nouvelle partie, elles doivent etre dans le game manager
            clickedBtn = false;
        }
    }
}
