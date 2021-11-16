using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfNight : MonoBehaviour {

    public GameObject Children;
    public float WichNight;

	// Use this for initialization
	void Start () {
        StartCoroutine(Update());

        WichNight = PlayerPrefs.GetFloat("WichNight", WichNight);

        SceneManager.UnloadSceneAsync("MainMenu");
        SceneManager.UnloadSceneAsync("GameOver");
        SceneManager.UnloadSceneAsync("NextNight");
        SceneManager.UnloadSceneAsync("Controlls");
        SceneManager.UnloadSceneAsync("Office");
        SceneManager.UnloadSceneAsync("Advertisement");
        SceneManager.UnloadSceneAsync("PowerOut");
        SceneManager.UnloadSceneAsync("TheEnd");
        SceneManager.UnloadSceneAsync("CostumNight");
    }
	
	// Update is called once per frame
	IEnumerator Update () {

        yield return new WaitForSeconds(6);

        Children.SetActive(true);

        yield return new WaitForSeconds(5);

        if (WichNight < 5)
        {
            SceneManager.LoadScene("NextNight");
        }
        else if (WichNight > 5)
        {
            SceneManager.LoadScene("TheEnd");
        }
	}
}
