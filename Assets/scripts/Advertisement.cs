using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Advertisement : MonoBehaviour {

    public GameObject Image;

	// Use this for initialization
	void Start () {

        StartCoroutine(Update());

        SceneManager.UnloadSceneAsync("MainMenu");
        SceneManager.UnloadSceneAsync("GameOver");
        SceneManager.UnloadSceneAsync("6AM");
        SceneManager.UnloadSceneAsync("NextNight");
        SceneManager.UnloadSceneAsync("Controlls");
        SceneManager.UnloadSceneAsync("Office");
        SceneManager.UnloadSceneAsync("PowerOut");
        SceneManager.UnloadSceneAsync("TheEnd");
        SceneManager.UnloadSceneAsync("CostumNight");

    }
	
	// Update is called once per frame
	IEnumerator Update () {

        Resources.UnloadUnusedAssets();

        yield return new WaitForSeconds(10f);

        Image.GetComponent<Animator>().enabled = true;

        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("Office");
	}
}
