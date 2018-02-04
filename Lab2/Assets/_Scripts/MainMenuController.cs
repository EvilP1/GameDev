using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour {

    public void ButtonHandlerPlay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(1);
    }
}

