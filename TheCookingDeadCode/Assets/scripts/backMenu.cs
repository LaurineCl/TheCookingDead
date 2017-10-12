using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backMenu : MonoBehaviour {
    private Button btnBackM;
	// Use this for initialization
	void Start () {
        btnBackM = GetComponent<Button>();
        btnBackM.onClick.AddListener(PlayScene);
    }


    void PlayScene()
    {
        print("coucou");
        SceneManager.LoadScene("menuPrincipal", LoadSceneMode.Single);
    }
}
