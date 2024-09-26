using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor.SceneManagement;
using System;
using TMPro;

public class CambioEscenas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textohamburguesa;
    [SerializeField] TextMeshProUGUI textosandwiches;
    void Update(){
        int index_scene_active = SceneManager.GetActiveScene().buildIndex;
        if (index_scene_active == 1)
        {
            textohamburguesa.text = PlayerPrefs.GetInt("Hamburguesa",0).ToString();
            textosandwiches.text = PlayerPrefs.GetInt("Sandwiches",0).ToString();

        }
    }

     public void cambioEscenas(int indexEscenaNueva){
        SceneManager.LoadScene(indexEscenaNueva);
    }
}
