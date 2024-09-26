using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HandlerUI : MonoBehaviour
{
   [SerializeField] TextMeshProUGUI hamburguesasTexto;
   [SerializeField] TextMeshProUGUI sandwichesTexto;

   int contadorHamburguesas;
   int contadorSandwiches;
    void Start()
    {
        contadorHamburguesas = 0;
        contadorSandwiches = 0;
    }

    public void agregarHamburguesa(){
        contadorHamburguesas+=1;
        hamburguesasTexto.text = contadorHamburguesas.ToString();
        HamburguesaCambio(contadorHamburguesas);
    }

    public void agregarSandwiches(){
        contadorSandwiches+=1;
        sandwichesTexto.text = contadorSandwiches.ToString();
        sandwichesCambio(contadorSandwiches);
    }

    
    public void HamburguesaCambio(int puntuacion){
        PlayerPrefs.SetInt("Hamburguesa",puntuacion);
    }

    public void sandwichesCambio(int puntuacion){
        PlayerPrefs.SetInt("Sandwiches",puntuacion);
    }
    
}
