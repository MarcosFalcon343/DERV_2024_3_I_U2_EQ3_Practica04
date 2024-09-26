using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJugador : MonoBehaviour
{
    [SerializeField] int velocidad_movimiento;
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.rotation = Quaternion.Euler(0, 0, 0); 
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        }else if(Input.GetKey(KeyCode.S)){
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        }else if(Input.GetKey(KeyCode.A)){
            transform.rotation = Quaternion.Euler(0, -90, 0); 
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        }else if(Input.GetKey(KeyCode.D)){
            transform.rotation = Quaternion.Euler(0, 90, 0); 
            transform.position += velocidad_movimiento *Time.deltaTime * transform.forward;
        }
    }

}
