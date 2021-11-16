using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnd : MonoBehaviour {
	
    void Start()
    {
        SceneManager.UnloadSceneAsync("MainMenu");
        SceneManager.UnloadSceneAsync("GameOver");
        SceneManager.UnloadSceneAsync("6AM");
        SceneManager.UnloadSceneAsync("NextNight");
        SceneManager.UnloadSceneAsync("Controlls");
        SceneManager.UnloadSceneAsync("Office");
        SceneManager.UnloadSceneAsync("Advertisement");
        SceneManager.UnloadSceneAsync("PowerOut");
        SceneManager.UnloadSceneAsync("CostumNight");
    }

	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("MainMenu");
        }
	}
}
