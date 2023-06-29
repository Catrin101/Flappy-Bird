using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaObstaculo : MonoBehaviour
{
    public float velocidad;
    public float Timer,tiempoEspera;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position+=Vector3.left*velocidad*Time.deltaTime;
        if(Timer <=0){
            Destroy(gameObject);
            Timer = tiempoEspera;
        }
        Timer -=Time.deltaTime;
    }
}
