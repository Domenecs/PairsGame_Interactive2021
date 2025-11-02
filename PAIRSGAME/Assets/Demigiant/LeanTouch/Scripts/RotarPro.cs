using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotarPro : MonoBehaviour {


    public GameObject gameObject;
    public int tiempo;

    public void Update()
    {
        tiempo--;
    }

    public void RotarProg()
    {
        StartCoroutine(Girar(5));
        
        
    }
    IEnumerator Girar(float time)
    {
        
        yield return new WaitForSeconds(time);
        gameObject.transform.DORotate(new Vector3(0, 180, 0), tiempo*Time.deltaTime);
        
    }
}
