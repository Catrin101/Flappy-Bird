using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoguicaGenerador : MonoBehaviour
{
    public float tiempoMax=1,tiempoInicial=0,altura,tiempo;
    public GameObject obstaculo;

    void Start()
    {
        GameObject obstaculoNew = Instantiate(obstaculo);
        obstaculoNew.transform.position=transform.position+new Vector3(0,0,0);
    }

    void Update()
    {
        if(tiempoInicial>tiempoMax){
            GameObject obstaculoNew = Instantiate(obstaculo);
            obstaculoNew.transform.position=transform.position+new Vector3(0,Random.Range(-altura,altura),0);
            tiempoInicial=0;  
        }else{
            tiempoInicial+=Time.deltaTime;
        }
        tiempo++;
    }
}
