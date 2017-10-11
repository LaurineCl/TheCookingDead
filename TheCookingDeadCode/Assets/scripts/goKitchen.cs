using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goKitchen : MonoBehaviour {
    private Button btnGoK;
	// Use this for initialization
	void Start () {
        btnGoK = GetComponent<Button>();
        btnGoK.onClick.AddListener(goKit);
    }
	
	void goKit()
    {
        SceneManager.LoadScene("cuisine", LoadSceneMode.Single);
    }
}
