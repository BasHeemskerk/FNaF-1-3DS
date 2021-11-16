using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour {

    public double BonnieMovementTime;
    public double ChicaMovementTime;
    public double FreddyMovementTime;
    public double FoxyMovementTime;

    public float WhereBonnie = 1;
    public float WhereChica = 1;
    public float WhereFreddy = 1;
    public float WhereFoxy = 1;

    public float BonnieDifficulty;
    public float ChicaDifficulty;
    public float FreddyDifficulty;
    public float FoxyDifficulty;

    public bool bonnieInCount;
    public bool chicaInCount;
    public bool freddyInCount;
    public bool foxyInCount;

    public bool camIsUp = false;

    public float WichNight = 1;

    public GameObject MoveGlitch;
    public bool GlitchActive = false;
    public float MoveGlitchUp = 0.5f;

    public bool ChicaActive = false;
    public bool BonnieActive = false;
    public bool FreddyActive = false;
    public bool FoxyActive = false;

    public bool BonnieOutsideDoor = false;
    public bool ChicaOutsideDoor = false;
    public bool FreddyOutsideDoor = false;
    public bool FoxyRunningHallway = false;

    public float BonnieOutsideDoorTime;
    public float ChicaOutsideDoorTime;
    public float FreddyOutsideDoorTime;

    public bool WaitForMovingFromDoorBonnie = false;
    public bool WaitForMovingFromDoorChica = false; 
    public bool WaitForMovingFromDoorFreddy = false;

    public bool LeftDoorClosed = false;
    public bool RightDoorClosed = false;

    public GameObject OfficeObject;


    void Start()
    {

        WichNight = PlayerPrefs.GetFloat("WichNight", WichNight);

        GenNumber();
    }

    public void GenNumber()
    {

        if (WichNight == 1)
        {
            BonnieDifficulty = 3;
            ChicaDifficulty = 3;
            FreddyDifficulty = 0;
            FoxyDifficulty = 0;

            PlayerPrefs.SetFloat("BonnieDifficulty", BonnieDifficulty);
            PlayerPrefs.SetFloat("ChicaDifficulty", ChicaDifficulty);
            PlayerPrefs.SetFloat("FreddyDifficulty", FreddyDifficulty);
            PlayerPrefs.SetFloat("FoxyDifficulty", FoxyDifficulty);
            PlayerPrefs.Save();
        }

        if (WichNight == 2)
        {
            BonnieDifficulty = 6;
            ChicaDifficulty = 6;
            FreddyDifficulty = 5;
            FoxyDifficulty = 0;

            PlayerPrefs.SetFloat("BonnieDifficulty", BonnieDifficulty);
            PlayerPrefs.SetFloat("ChicaDifficulty", ChicaDifficulty);
            PlayerPrefs.SetFloat("FreddyDifficulty", FreddyDifficulty);
            PlayerPrefs.SetFloat("FoxyDifficulty", FoxyDifficulty);
            PlayerPrefs.Save();
        }

        if (WichNight == 3)
        {
            BonnieDifficulty = 11;
            ChicaDifficulty = 11;
            FreddyDifficulty = 10;
            FoxyDifficulty = 8;

            PlayerPrefs.SetFloat("BonnieDifficulty", BonnieDifficulty);
            PlayerPrefs.SetFloat("ChicaDifficulty", ChicaDifficulty);
            PlayerPrefs.SetFloat("FreddyDifficulty", FreddyDifficulty);
            PlayerPrefs.SetFloat("FoxyDifficulty", FoxyDifficulty);
            PlayerPrefs.Save();
        }

        if (WichNight == 4)
        {
            BonnieDifficulty = 15;
            ChicaDifficulty = 15;
            FreddyDifficulty = 15;
            FoxyDifficulty = 14;

            PlayerPrefs.SetFloat("BonnieDifficulty", BonnieDifficulty);
            PlayerPrefs.SetFloat("ChicaDifficulty", ChicaDifficulty);
            PlayerPrefs.SetFloat("FreddyDifficulty", FreddyDifficulty);
            PlayerPrefs.SetFloat("FoxyDifficulty", FoxyDifficulty);
            PlayerPrefs.Save();
        }

        if (WichNight == 5)
        {
            BonnieDifficulty = 16;
            ChicaDifficulty = 16;
            FreddyDifficulty = 16;
            FoxyDifficulty = 16;

            PlayerPrefs.SetFloat("BonnieDifficulty", BonnieDifficulty);
            PlayerPrefs.SetFloat("ChicaDifficulty", ChicaDifficulty);
            PlayerPrefs.SetFloat("FreddyDifficulty", FreddyDifficulty);
            PlayerPrefs.SetFloat("FoxyDifficulty", FoxyDifficulty);
            PlayerPrefs.Save();
        }

        if (WichNight == 6)
        {
            BonnieDifficulty = 17;
            ChicaDifficulty = 16;
            FreddyDifficulty = 16;
            FoxyDifficulty = 18;

            PlayerPrefs.SetFloat("BonnieDifficulty", BonnieDifficulty);
            PlayerPrefs.SetFloat("ChicaDifficulty", ChicaDifficulty);
            PlayerPrefs.SetFloat("FreddyDifficulty", FreddyDifficulty);
            PlayerPrefs.SetFloat("FoxyDifficulty", FoxyDifficulty);
            PlayerPrefs.Save();
        }

        if (WichNight == 7)
        {
            BonnieDifficulty = PlayerPrefs.GetFloat("BonnieDifficulty", BonnieDifficulty);
            ChicaDifficulty = PlayerPrefs.GetFloat("ChicaDifficulty", ChicaDifficulty);
            FreddyDifficulty = PlayerPrefs.GetFloat("FreddyDifficulty", FreddyDifficulty);
            FoxyDifficulty = PlayerPrefs.GetFloat("FoxyDifficulty", FoxyDifficulty);
        }

        if (WichNight >= 1)
        {
            BonnieActive = true;

            if (!bonnieInCount)
            {
                BonnieMovementTime = System.Math.Round(UnityEngine.Random.Range(20f, 35f), 0);
                BonnieMovementTime -= BonnieDifficulty;


                bonnieInCount = true;
            }
        }

        if (WichNight >= 2)
        {
            ChicaActive = true;

            if (!chicaInCount)
            {
                ChicaMovementTime = System.Math.Round(UnityEngine.Random.Range(35f, 40f), 0);
                ChicaMovementTime -= ChicaDifficulty;


                chicaInCount = true;
            }

            FoxyActive = true;

            if (!foxyInCount)
            {
                FoxyMovementTime = System.Math.Round(UnityEngine.Random.Range(60f, 90f), 0);
                FoxyMovementTime -= FoxyDifficulty;


                foxyInCount = true;
            }
        }

        if (WichNight >= 3)
        {
            FreddyActive = true;

            if (!freddyInCount)
            {
                FreddyMovementTime = System.Math.Round(UnityEngine.Random.Range(40f, 60f));
                FreddyMovementTime -= FreddyDifficulty;

                freddyInCount = true;
            }
        }
    }

    void MoveFromDoorBonnie()
    {
        if (!WaitForMovingFromDoorBonnie)
        {
            BonnieOutsideDoorTime += BonnieDifficulty;
            WaitForMovingFromDoorBonnie = true;
        }
    }

    void MoveFromDoorChica()
    {

        if (!WaitForMovingFromDoorChica)
        {
            ChicaOutsideDoorTime += ChicaDifficulty;
            WaitForMovingFromDoorChica = true;
        }
    }

    void MoveFromDoorFreddy()
    {
        if (!WaitForMovingFromDoorFreddy)
        {
            FreddyOutsideDoorTime += FreddyDifficulty;
            WaitForMovingFromDoorFreddy = true;
        }
    }
	

	void Update ()
    {
        PlayerPrefs.SetFloat("WhereBonnie", WhereBonnie);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("WhereChica", WhereChica);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("WhereFoxy", WhereFoxy);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("WhereFreddy", WhereFreddy);
        PlayerPrefs.Save();

        if (WhereBonnie >= 2)
        {
            OfficeObject.GetComponent<RandNumberGen>().BonnieLeftStage = true;
        }

        if (WhereChica >= 2)
        {
            OfficeObject.GetComponent<RandNumberGen>().ChicaLeftStage = true;
        }

        if (WhereFreddy >= 2)
        {
            OfficeObject.GetComponent<RandNumberGen>().FreddyLeftStage = true;
        }

        if (BonnieOutsideDoor)
        {
            OfficeObject.GetComponent<Office>().BonnieOutsideDoor = true;
        }

        if (ChicaOutsideDoor)
        {
            if (!BonnieOutsideDoor)
            {
                OfficeObject.GetComponent<Office>().ChicaOutsideDoor = true;
            }
        }

        if (FreddyOutsideDoor)
        {
            if (!ChicaOutsideDoor)
            {
                OfficeObject.GetComponent<Office>().FreddyOutsideDoor = true;
            }
        }

        if (FoxyRunningHallway)
        {
            if (!BonnieOutsideDoor)
            {
                OfficeObject.GetComponent<Office>().FoxyRunningHallway = true;
            }
        }


        if (WichNight >= 1)
        {

            BonnieMovementTime -= Time.deltaTime;

            if (BonnieMovementTime <= 0)
            {
                if (BonnieActive)
                {
                    WhereBonnie += 1;
                    bonnieInCount = false;
                    GlitchActive = true;
                    MoveGlitch.SetActive(true);

                    if (!camIsUp)
                    {
                        GlitchActive = false;
                        MoveGlitch.SetActive(false);
                    }

                    GenNumber();
                }
            }
        }



        if (WichNight >= 2)
        {
            ChicaMovementTime -= Time.deltaTime;

            if (ChicaMovementTime <= 0)
            {
                if (ChicaActive)
                {
                    WhereChica += 1;
                    chicaInCount = false;
                    GlitchActive = true;
                    MoveGlitch.SetActive(true);

                    if (!camIsUp)
                    {
                        GlitchActive = false;
                        MoveGlitch.SetActive(false);
                    }

                    GenNumber();
                }
            }

            if (!camIsUp)
            {
                FoxyMovementTime -= Time.deltaTime;
            }

            if (FoxyMovementTime <= 0)
            {
                if (FoxyActive)
                {
                    WhereFoxy += 1;
                    foxyInCount = false;
                    GlitchActive = true;
                    MoveGlitch.SetActive(true);

                    if (!camIsUp)
                    {
                        GlitchActive = false;
                        MoveGlitch.SetActive(false);
                    }

                    GenNumber();
                }
            }
        }

        if (WichNight >= 3)
        {
            FreddyMovementTime -= Time.deltaTime;

            if (FreddyMovementTime <= 0)
            {
                if (FreddyActive)
                {
                    WhereFreddy += 1;
                    freddyInCount = false;
                    GlitchActive = true;
                    MoveGlitch.SetActive(true);

                    if (!camIsUp)
                    {
                        GlitchActive = false;
                        MoveGlitch.SetActive(false);
                    }

                    GenNumber();
                }
            }
        }



        if (BonnieOutsideDoor)
        {
            if (LeftDoorClosed)
            {
                MoveFromDoorBonnie();
                BonnieMovementTime = 20;

                if (WaitForMovingFromDoorBonnie)
                {
                    BonnieOutsideDoorTime -= Time.deltaTime;

                    if (BonnieOutsideDoorTime <= 0)
                    {
                        BonnieOutsideDoor = false;
                        OfficeObject.GetComponent<Office>().BonnieOutsideDoor = false;
                        WhereBonnie = 2;
                        PlayerPrefs.SetFloat("WhereBonnie", WhereBonnie);
                        PlayerPrefs.Save();
                        WaitForMovingFromDoorBonnie = false;
                        BonnieOutsideDoorTime = 0;
                    }
                }
            }
        }

        if (ChicaOutsideDoor)
        {
            if (RightDoorClosed)
            {
                MoveFromDoorChica();
                ChicaMovementTime = 20;

                if (WaitForMovingFromDoorChica)
                {
                    ChicaOutsideDoorTime -= Time.deltaTime;

                    if (ChicaOutsideDoorTime <= 0)
                    {
                        ChicaOutsideDoor = false;
                        OfficeObject.GetComponent<Office>().ChicaOutsideDoor = false;
                        WhereChica = 2;
                        PlayerPrefs.SetFloat("WhereChica", WhereChica);
                        PlayerPrefs.Save();
                        WaitForMovingFromDoorChica = false;
                        ChicaOutsideDoorTime = 0;
                    }
                }
            }
        }

        if (FreddyOutsideDoor)
        {
            if (RightDoorClosed)
            {
                MoveFromDoorFreddy();
                FreddyMovementTime = 20;

                if (WaitForMovingFromDoorFreddy)
                {
                    FreddyOutsideDoorTime -= Time.deltaTime;

                    if  (FreddyOutsideDoorTime <= 0)
                    {
                        FreddyOutsideDoor = false;
                        OfficeObject.GetComponent<Office>().FreddyOutsideDoor = false;
                        WhereFreddy = 1;
                        PlayerPrefs.SetFloat("WhereFreddy", WhereFreddy);
                        PlayerPrefs.Save();
                        WaitForMovingFromDoorFreddy = false;
                        FreddyOutsideDoorTime = 0;
                    }
                }
            }
        }

        if (GlitchActive)
        {
            MoveGlitchUp -= Time.deltaTime;

            if (MoveGlitchUp <= 0)
            {
                MoveGlitch.SetActive(false);
                GlitchActive = false;
                MoveGlitchUp = 0.5f;
            }
        }

        
    }
}
