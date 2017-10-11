using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btnCuisinerMenu : MonoBehaviour {

    private Button btnCuisineMenu;

    void Start()
    {
        btnCuisineMenu = GetComponent<Button>();
        btnCuisineMenu.onClick.AddListener(PlayScene);
    }

    void PlayScene()
    {
        SceneManager.LoadScene("ustensiles", LoadSceneMode.Single);
    }
}
