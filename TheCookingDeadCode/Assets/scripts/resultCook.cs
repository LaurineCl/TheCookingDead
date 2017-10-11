using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class resultCook : MonoBehaviour {
    private Button btnResult;
    private bool clickedBtn = false;

    // Use this for initialization
    void Start () {
        btnResult = GetComponent<Button>();
        btnResult.onClick.AddListener(DisplayMsg);
    }

    void DisplayMsg()
    {
        
        if (!clickedBtn)
        {
            GameObject.Find("Canvas/msgResultat/suite").SetActive(true);
            GameObject.Find("Canvas/msgResultat/Text").SetActive(true);
            GameObject.Find("Canvas/msgResultat/ImageResultat").SetActive(true);
            print("coucou");
            clickedBtn = true;
        }

        else
        {
            GameObject.Find("Canvas/msgResultat/suite").SetActive(false);
            GameObject.Find("Canvas/msgResultat/Text").SetActive(false);
            GameObject.Find("Canvas/msgResultat/ImageResultat").SetActive(false);
            clickedBtn = false;
        }
    }
}
