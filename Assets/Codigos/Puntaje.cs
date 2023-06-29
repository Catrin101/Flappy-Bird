using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public static int puntaje = 0;

    void Start()
    {
        puntaje=0;
    }

    void Update()
    {
        GetComponent<TextMeshProUGUI>().text=puntaje.ToString();
    }
}
