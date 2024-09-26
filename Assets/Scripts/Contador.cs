using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Contador : MonoBehaviour
{
[SerializeField]  CambioEscenas aux;
    [SerializeField]int TiempoContador;
    [SerializeField] TextMeshProUGUI texto_tiempo;
    void Start()
    {
        StartCoroutine(currutina_contador());
    }

    IEnumerator currutina_contador(){
        while(TiempoContador > 0){
            TiempoContador--;
            texto_tiempo.text = TiempoContador.ToString();
            yield return new WaitForSeconds(1f); 
        }
        aux.cambioEscenas(1);
    }

}
