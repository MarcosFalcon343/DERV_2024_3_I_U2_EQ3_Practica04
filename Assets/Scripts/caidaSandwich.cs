using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caidaSandwich : MonoBehaviour
{
    [SerializeField] List<GameObject> spawns;
    [SerializeField] HandlerUI handlerUi;
    int index;
    float tiempo_en_collision;
    private void OnCollisionStay(Collision Other){
        tiempo_en_collision += Time.deltaTime;
        if(tiempo_en_collision > 1f){
            mueveObjeto();
        }
    }
    private void OnCollisionEnter(Collision other){
         GameObject objeto = other.gameObject;
         if(objeto.CompareTag("Player")){
            mueveObjeto();
            handlerUi.agregarSandwiches();
        }
        tiempo_en_collision = 0;
    }
    private void mueveObjeto(){
        index = Random.Range(0, spawns.Count);
        transform.position = spawns[index].transform.position;
    }
}
