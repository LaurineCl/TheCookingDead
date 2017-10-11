using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btnExplorer : MonoBehaviour {
    private Button btnExplorer1;

    void Start()
    {
        btnExplorer1 = GetComponent<Button>();
        btnExplorer1.onClick.AddListener(PlayScene);
    }

    void PlayScene()
    {
        SceneManager.LoadScene("exploration", LoadSceneMode.Single);
    }
}
