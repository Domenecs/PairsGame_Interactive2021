using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ShuffleCards : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] cards = new GameObject[16];
    public List<Vector3> positions = new List<Vector3>();
    public int RandomIndex;

    public  Vector3 RandomPosition = new Vector3(0, 0, 0);
    void Start()
    {
       
        // Store all card positions in the array.
        for (int i = 0; i < cards.Length; i++)
        {          
            positions.Add(cards[i].transform.position);
            print(positions.Count);
                       
        }
        StartCoroutine("Shuffle");
    }
  

    
    IEnumerator Shuffle()
    {
        for(int j = 0; j < cards.Length; j++)
        {
           
                RandomIndex = (int)Random.Range(0, positions.Count);
                RandomPosition = positions[RandomIndex];
            
            cards[j].transform.DOMove(RandomPosition, 2);
            positions.RemoveAt(RandomIndex);
        }
        
        yield return new WaitForSeconds(0);
    }
    


}
