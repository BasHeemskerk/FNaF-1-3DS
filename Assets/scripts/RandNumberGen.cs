using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandNumberGen : MonoBehaviour {

    public GameObject OfficeObject;

    public bool camIsUp = false;

    public double CountDown = 30f;
    public double RandNumberBonnie;
    public double RandNumberChica;
    public double RandNumberFreddy;

    public bool BonnieOutsideLeftDoor = false;
    public bool ChicaOutsideRightDoor = false;
    public bool FreddyOutsideRightDoor = false;

    public bool BonnieLeftStage = false;
    public bool ChicaLeftStage = false;
    public bool FreddyLeftStage = false;

    public float WichNight;

	void GenRandomNumber ()
    {
        CountDown = System.Math.Round(UnityEngine.Random.Range(30f, 40f), 0);

        if (WichNight >= 1)
        {
            if (BonnieLeftStage)
            {
                RandNumberBonnie = System.Math.Round(UnityEngine.Random.Range(2f, 6f), 0);
            }
        }

        if (WichNight >= 2)
        {
            if (ChicaLeftStage)
            {
                RandNumberChica = System.Math.Round(UnityEngine.Random.Range(2f, 7f), 0);
            }
        }

        if (WichNight >= 3)
        {
            if (FreddyLeftStage)
            {
                RandNumberFreddy = System.Math.Round(UnityEngine.Random.Range(1f, 2f), 0);
            }
        }

        ChangePos();
	}

    void ChangePos()
    {

        if (!BonnieOutsideLeftDoor)
        {
            if (RandNumberBonnie == 2)
            {
                OfficeObject.GetComponent<Movement>().WhereBonnie = 2;

                if (camIsUp)
                {
                    OfficeObject.GetComponent<Movement>().MoveGlitch.SetActive(true);
                    OfficeObject.GetComponent<Movement>().GlitchActive = true;
                }
            }

            if (RandNumberBonnie == 3)
            {
                OfficeObject.GetComponent<Movement>().WhereBonnie = 3;

                if (camIsUp)
                {
                    OfficeObject.GetComponent<Movement>().MoveGlitch.SetActive(true);
                    OfficeObject.GetComponent<Movement>().GlitchActive = true;
                }
            }

            if (RandNumberBonnie == 4)
            {
                OfficeObject.GetComponent<Movement>().WhereBonnie = 4;

                if (camIsUp)
                {
                    OfficeObject.GetComponent<Movement>().MoveGlitch.SetActive(true);
                    OfficeObject.GetComponent<Movement>().GlitchActive = true;
                }
            }

            if (RandNumberBonnie == 5)
            {
                OfficeObject.GetComponent<Movement>().WhereBonnie = 5;

                if (camIsUp)
                {
                    OfficeObject.GetComponent<Movement>().MoveGlitch.SetActive(true);
                    OfficeObject.GetComponent<Movement>().GlitchActive = true;
                }
            }

            if (RandNumberBonnie == 6)
            {
                OfficeObject.GetComponent<Movement>().WhereBonnie = 6;

                if (camIsUp)
                {
                    OfficeObject.GetComponent<Movement>().MoveGlitch.SetActive(true);
                    OfficeObject.GetComponent<Movement>().GlitchActive = true;
                }
            }
        }

        if (!ChicaOutsideRightDoor)
        {
            if (RandNumberChica == 2)
            {
                OfficeObject.GetComponent<Movement>().WhereChica = 2;

                if (camIsUp)
                {
                    OfficeObject.GetComponent<Movement>().MoveGlitch.SetActive(true);
                    OfficeObject.GetComponent<Movement>().GlitchActive = true;
                }
            }

            if (RandNumberChica == 3)
            {
                OfficeObject.GetComponent<Movement>().WhereChica = 3;

                if (camIsUp)
                {
                    OfficeObject.GetComponent<Movement>().MoveGlitch.SetActive(true);
                    OfficeObject.GetComponent<Movement>().GlitchActive = true;
                }
            }

            if (RandNumberChica == 4)
            {
                OfficeObject.GetComponent<Movement>().WhereChica = 4;

                if (camIsUp)
                {
                    OfficeObject.GetComponent<Movement>().MoveGlitch.SetActive(true);
                    OfficeObject.GetComponent<Movement>().GlitchActive = true;
                }
            }

            if (RandNumberChica == 5)
            {
                OfficeObject.GetComponent<Movement>().WhereChica = 5;

                if (camIsUp)
                {
                    OfficeObject.GetComponent<Movement>().MoveGlitch.SetActive(true);
                    OfficeObject.GetComponent<Movement>().GlitchActive = true;
                }
            }

            if (RandNumberChica == 6)
            {
                OfficeObject.GetComponent<Movement>().WhereChica = 6;

                if (camIsUp)
                {
                    OfficeObject.GetComponent<Movement>().MoveGlitch.SetActive(true);
                    OfficeObject.GetComponent<Movement>().GlitchActive = true;
                }
            }

            if (RandNumberChica == 7)
            {
                OfficeObject.GetComponent<Movement>().WhereChica = 7;

                if (camIsUp)
                {
                    OfficeObject.GetComponent<Movement>().MoveGlitch.SetActive(true);
                    OfficeObject.GetComponent<Movement>().GlitchActive = true;
                }
            }
        }


        if (!FreddyOutsideRightDoor)
        {
            if (RandNumberFreddy == 1)
            {
                OfficeObject.GetComponent<Movement>().WhereFreddy = 1;

                if (camIsUp)
                {
                    OfficeObject.GetComponent<Movement>().MoveGlitch.SetActive(true);
                    OfficeObject.GetComponent<Movement>().GlitchActive = true;
                }
            }

            if (RandNumberFreddy > 2)
            {
                OfficeObject.GetComponent<Movement>().WhereFreddy = 2;

                if (camIsUp)
                {
                    OfficeObject.GetComponent<Movement>().MoveGlitch.SetActive(true);
                    OfficeObject.GetComponent<Movement>().GlitchActive = true;
                }
            }

            
        }
    }
	

	void Update ()
    {
        WichNight = PlayerPrefs.GetFloat("WichNight", WichNight);

        CountDown -= Time.deltaTime;

        if (CountDown <= 0)
        {
            GenRandomNumber();
        }
	}
}
