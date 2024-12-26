using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{
    public void StartGameAnother()
    {
        SceneManager.LoadScene(0);
    }
    
    
        
    

    public void StartGameNobe()
    {
        SceneManager.LoadScene(3);
    }
}