using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

   public void PlayButton()
    {
        SceneManager.LoadScene("CardGame");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Arcade");
    }
}
