using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class chooseTool : MonoBehaviour {
    private Button btnU;

    void Start()
    {
        btnU = GetComponent<Button>();
        btnU.onClick.AddListener(Greet);
    }


    void Greet()
    {
        //TODO: instancier les variables correspondant aux ustensils
        switch (this.name)
        {
            case "U1":
                print("ok1");
                break;
            case "U2":
                print("ok2");
                break;
            case "U3":
                print("ok3");
                break;
            case "U4":
                print("ok4");
                break;
            case "U5":
                print("ok5");
                break;
            case "U6":
                print("ok6");
                break;
            case "U7":
                print("ok7");
                break;
            case "U8":
                print("ok8");
                break;


        }
    }
}
