using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour {
    public string id;


    public int comparacion(Carta carta)
    {
        if (id.CompareTo(carta.id) == 0)
        {
            return 0;
        }   
            return 1;
        
    }
}
