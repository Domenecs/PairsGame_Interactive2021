using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class InterfaceCards : MonoBehaviour
{
    public GameObject BotonPlay;
    public GameObject BotonGoBack;
    public GameObject WellDoneText;
    public AudioSource aplause;
    
    // Start is called before the first frame update
    void Start()
    {
        WellDoneText.SetActive(false);
        BotonPlay.SetActive(false);
        BotonGoBack.SetActive(false);
        GameManager.numberPairs = 0;
    }

    // Update is called once per frame
    void Update()
    {
       if(GameManager.numberPairs == 8)
        {
            WellDoneText.SetActive(true);
            BotonPlay.SetActive(true);
            BotonGoBack.SetActive(true);
            aplause.Play();
            GameManager.numberPairs = 0;
        } 
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("CardGame");
    }
    public void GoBack()
    {
        SceneManager.LoadScene("MenúCards");
    }
    
}
