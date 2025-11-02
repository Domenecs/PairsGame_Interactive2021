using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CompareTo : MonoBehaviour
{
    public Carta lastSelection;
    private bool clickable = true;
    private float offset = 0.01f;
    public AudioSource wrong;
    public AudioSource correct;
    public AudioSource girar;


    public void compararCartas(Carta carta)
    {
        girar.Play();
        if (lastSelection == null && clickable)
        {
            lastSelection = carta;
            lastSelection.transform.DORotate(new Vector3(0, 180, 90), 1);
            
        }
        else if (lastSelection != carta && clickable)
            
        {
            clickable = false;
            carta.transform.DORotate(new Vector3(0, 180, 90), 1);
            if (lastSelection.comparacion(carta) == 0)
            {
                    
                StartCoroutine(Correcto(1.2f,carta));
                
            }
            else
            {
                StartCoroutine(Incorrecto(1.2f,carta));
                

            }
        }
    }
    IEnumerator Correcto(float time,Carta x)
    {
        yield return new WaitForSeconds(time);
        lastSelection.transform.DOMove(new Vector3(26, 2, -5+offset), 1);
        x.transform.DOMove(new Vector3(26,2,-5-offset),1);

        lastSelection.GetComponent<Collider>().enabled = false;
        x.GetComponent<Collider>().enabled = false;

        lastSelection = null;
        clickable = true;
  
        correct.Play();
        GameManager.numberPairs++;
        offset += 0.01f;


    }
    IEnumerator Incorrecto(float time,Carta x)
    {
        
        yield return new WaitForSeconds(time);
        lastSelection.transform.DORotate(new Vector3(0, 0, 90), 0.7f);
        x.transform.DORotate(new Vector3(0, 0 , 90), 0.7f);
        lastSelection = null;
        clickable = true;
        wrong.Play();
    }
}


