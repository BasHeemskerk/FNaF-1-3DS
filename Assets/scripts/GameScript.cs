using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScript : MonoBehaviour {

    public float WichNight = 1;
    public float Time = 360;
    public float Usage = 1;

    public GameObject WichNightShower;
    public GameObject TimeShower;

    public float PowerUsage = 1;
    public float PowerDrain = 1;
    public float PowerLeft = 100;
    public GameObject PowerShower;
    public GameObject Bar1, Bar2, Bar3, Bar4, Bar5;

    public AudioSource Call1;
    public AudioSource Call2;
    public AudioSource Call3;
    public AudioSource Call4;
    public AudioSource Call5;


	void Start ()
    {
        WichNight = PlayerPrefs.GetFloat("WichNight", WichNight);
        WichNightShower.GetComponent<Text>().text = WichNight.ToString();

        //--------------------------------------CallAndNight----------------------//
        if (WichNight == 1)
        {
            Call1.Play();
        }

        if (WichNight == 2)
        {
            Call2.Play();
        }

        if (WichNight == 3)
        {
            Call3.Play();
        }

        if (WichNight == 4)
        {
            Call4.Play();
        }

        if (WichNight == 5)
        {
            Call5.Play();
        }
        //-------------------------------CallAndNight-----------------------------//
    }

    void Update ()
    {

        WichNight = PlayerPrefs.GetFloat("WichNight", WichNight);
        WichNightShower.GetComponent<Text>().text = WichNight.ToString();

        //---------------------------------------TIME-------------------------------------//
        Time -= UnityEngine.Time.deltaTime;

        if (Time <= 360)
        {
            TimeShower.GetComponent<Text>().text = "12 AM";
        }

        if (Time <= 300)
        {
            TimeShower.GetComponent<Text>().text = "1 AM";
        }

        if (Time <= 240)
        {
            TimeShower.GetComponent<Text>().text = "2 AM";
        }

        if (Time <= 180)
        {
            TimeShower.GetComponent<Text>().text = "3 AM";
        }

        if (Time <= 120)
        {
            TimeShower.GetComponent<Text>().text = "4 AM";
        }

        if (Time <= 60)
        {
            TimeShower.GetComponent<Text>().text = "5 AM";
        }

        if (Time <= 0)
        {
            TimeShower.GetComponent<Text>().text = "6 AM";
            WichNight += 1;
            PlayerPrefs.SetFloat("WichNight", WichNight);
            PlayerPrefs.Save();

            SceneManager.LoadScene("6AM");
        }
        //--------------------------------------TIME------------------------------//

        //-------------------------------PowerUsage-------------------------------//
        if (PowerUsage <= 0)
        {
            PowerUsage = 1;
        }

        if (PowerUsage >= 5)
        {
            PowerUsage = 5;
        }

        if (PowerUsage == 1)
        {
            PowerDrain -= UnityEngine.Time.deltaTime;

            if (PowerDrain <= 0)
            {
                PowerLeft -= 1;
                PowerShower.GetComponent<Text>().text = PowerLeft.ToString();
                PowerDrain = 8;
            }

            Bar1.SetActive(true);
            Bar2.SetActive(false);
            Bar3.SetActive(false);
            Bar4.SetActive(false);
            Bar5.SetActive(false);
        }

        if (PowerUsage == 2)
        {
            PowerDrain -= UnityEngine.Time.deltaTime;

            if (PowerDrain <= 0)
            {
                PowerLeft -= 1;
                PowerShower.GetComponent<Text>().text = PowerLeft.ToString();
                PowerDrain = 4.5f;
            }

            Bar1.SetActive(false);
            Bar2.SetActive(true);
            Bar3.SetActive(false);
            Bar4.SetActive(false);
            Bar5.SetActive(false);
        }

        if (PowerUsage == 3)
        {
            PowerDrain -= UnityEngine.Time.deltaTime;

            if (PowerDrain <= 0)
            {
                PowerLeft -= 1;
                PowerShower.GetComponent<Text>().text = PowerLeft.ToString();
                PowerDrain = 2.3f;
            }

            Bar1.SetActive(false);
            Bar2.SetActive(false);
            Bar3.SetActive(true);
            Bar4.SetActive(false);
            Bar5.SetActive(false);
        }

        if (PowerUsage == 4)
        {
            PowerDrain -= UnityEngine.Time.deltaTime;

            if (PowerDrain <= 0)
            {
                PowerLeft -= 1;
                PowerShower.GetComponent<Text>().text = PowerLeft.ToString();
                PowerDrain = 1.1f;
            }

            Bar1.SetActive(false);
            Bar2.SetActive(false);
            Bar3.SetActive(false);
            Bar4.SetActive(true);
            Bar5.SetActive(false);
        }

        if (PowerUsage == 5)
        {
            PowerDrain -= UnityEngine.Time.deltaTime;

            if (PowerDrain <= 0)
            {
                PowerLeft -= 1;
                PowerShower.GetComponent<Text>().text = PowerLeft.ToString();
                PowerDrain = 0.6f;
            }

            Bar1.SetActive(false);
            Bar2.SetActive(false);
            Bar3.SetActive(false);
            Bar4.SetActive(false);
            Bar5.SetActive(true);
        }

        if (PowerLeft <= 0)
        {
            SceneManager.LoadScene("PowerOut");
        }
        //--------------------------------PowerUsage---------------------------//

    }
}
