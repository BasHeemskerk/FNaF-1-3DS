using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public float WichNight = 1;
    public GameObject WichNightShower;
    public GameObject Music;

    public GameObject ExtraNight;
    public bool ExtraNightEnabled = false;

    public GameObject CostumNight;
    public bool CostumNightEnabled = false;


    void Start()
    {
        SceneManager.UnloadSceneAsync("GameOver");
        SceneManager.UnloadSceneAsync("6AM");
        SceneManager.UnloadSceneAsync("NextNight");
        SceneManager.UnloadSceneAsync("Controlls");
        SceneManager.UnloadSceneAsync("Office");
        SceneManager.UnloadSceneAsync("Advertisement");
        SceneManager.UnloadSceneAsync("PowerOut");
        SceneManager.UnloadSceneAsync("TheEnd");
        SceneManager.UnloadSceneAsync("CostumNight");

        if (WichNight >= 5)
        {
            WichNight = 5;
        }
    }

    void Update()
    {

        WichNight = PlayerPrefs.GetFloat("WichNight", WichNight);

        WichNightShower.GetComponent<Text>().text = WichNight.ToString();

        if (Input.GetKeyDown(KeyCode.B))
        {
            Music.SetActive(false);
            WichNight = 1;
            PlayerPrefs.SetFloat("WichNight", WichNight);
            PlayerPrefs.Save();
            SceneManager.LoadScene("Advertisement");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Music.SetActive(false);
            if (WichNight == 1)
            {
                WichNight = 1;
                PlayerPrefs.SetFloat("WichNight", WichNight);
                PlayerPrefs.Save();
                SceneManager.LoadScene("Advertisement");
            }
            if (WichNight >= 2)
            {
                SceneManager.LoadScene("Office");
            }
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            Music.SetActive(false);
            SceneManager.LoadScene("Controlls");
        }

        if (WichNight >= 5)
        {
            WichNight = 5;
            ExtraNightEnabled = true;
            CostumNightEnabled = true;
        }

        if (ExtraNightEnabled)
        {
            ExtraNight.SetActive(true);
        }
        if (CostumNightEnabled)
        {
            CostumNight.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (ExtraNightEnabled)
            {
                WichNight = 6;
                PlayerPrefs.SetFloat("WichNight", WichNight);
                PlayerPrefs.Save();
                SceneManager.LoadScene("Office");
            }
        }

        
    }

    public void CostumNightEnter()
    {
        SceneManager.LoadScene("CostumNight");
    }
}
