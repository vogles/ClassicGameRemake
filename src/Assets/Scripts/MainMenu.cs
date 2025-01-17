using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu : UIBehaviour
{
    public void OnPlayPong()
    {
        SceneManager.LoadScene("Pong", LoadSceneMode.Single);
    }
}
