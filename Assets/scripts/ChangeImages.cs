using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class ChangeImages : MonoBehaviour
{

    public float WichCamera = 1;
    public GameObject WichCameraShower;
    public GameObject black;

    public Sprite ShowStage1;
    public Sprite ShowStage2;
    public Sprite ShowStage3;
    public Sprite ShowStage4;

    public Sprite DiningArea1;
    public Sprite DiningArea2;
    public Sprite DiningArea3;
    public Sprite DiningArea4;

    public Sprite PirateCove1;
    public Sprite PirateCove2;
    public Sprite PirateCove3;

    public Sprite WestHall1_1;
    public Sprite WestHall1_2;

    public Sprite WestHall2_1;
    public Sprite WestHall2_2;

    public Sprite Closet1;
    public Sprite Closet2;

    public Sprite EastHall1_1;
    public Sprite EastHall1_2;
    public Sprite EastHall1_3;

    public Sprite EastHall2_1;
    public Sprite EastHall2_2;
    public Sprite EastHall2_3;

    public Sprite BackStage1;
    public Sprite BackStage2;
    public Sprite BackStage3;

    public Sprite Kitchen1;

    public Sprite RestRooms1;
    public Sprite RestRooms2;
    public Sprite RestRooms3;

    public double RandCamNoise;
    public bool noiseIsPlaying;

    public float WhereBonnie = 1;
    public float WhereChica = 1;
    public float WhereFreddy = 1;
    public float WhereFoxy = 1;

    public bool BonnieLeft = false;
    public bool ChicaLeft = false;
    public bool FreddyLeft = false;

    public GameObject BonnieJumpscare;
    public GameObject ChicaJumpscare;
    public GameObject FreddyJumpscare;

    public float WaitJumpscare = 2;
    public bool isBeingJumpscared = false;

    public GameObject OfficeObject;

    public float AmountLeft = 0;

    public bool camIsUp = false;

    public GameObject LowerCanvas;
    public GameObject ResetPoint;
    public GameObject Phonecalls;
    public GameObject AudioSources;
    public GameObject CamViewTabletOpen;
    public GameObject CamViewTabletClose;
    public GameObject Dot;
    public GameObject Image;
    public GameObject Black;
    public GameObject StripeGlitches;

    public GameObject OriginalOfficeImage;
    public GameObject FoxyEnterOffice;

    public GameObject FoxyRunDownHall;
    public AudioSource DoorBang;

    public float foxyRunTime = 3.5f;

    public bool L_Door_Closed;
    public bool foxyStarted;

    void GenRandNoise()
    {
        if (!noiseIsPlaying)
        {
            RandCamNoise = System.Math.Round(UnityEngine.Random.Range(0f, 10f), 0);
        }
    }

    void Update()
    {
        PlayerPrefs.SetFloat("WichCamera", WichCamera);
        PlayerPrefs.Save();

        WhereBonnie = PlayerPrefs.GetFloat("WhereBonnie", WhereBonnie);
        WhereChica = PlayerPrefs.GetFloat("WhereChica", WhereChica);
        WhereFreddy = PlayerPrefs.GetFloat("WhereFreddy", WhereFreddy);
        WhereFoxy = PlayerPrefs.GetFloat("WhereFoxy", WhereFoxy);

        if (WichCamera == 1)
        {
            WichCameraShower.GetComponent<Text>().text = "Show Stage";

            black.GetComponent<Image>().sprite = ShowStage1;

            if (WhereBonnie >= 2)
            {
                if (!BonnieLeft)
                {
                    AmountLeft += 1;

                    BonnieLeft = true;
                }
            }

            if (WhereChica >= 2)
            {
                if (BonnieLeft)
                {
                    if (!ChicaLeft)
                    {
                        AmountLeft += 1;

                        ChicaLeft = true;
                    }
                }
            }

            if (WhereFreddy >= 2)
            {
                if (BonnieLeft)
                {
                    if (ChicaLeft)
                    {
                        if (!FreddyLeft)
                        {
                            AmountLeft += 1;

                            FreddyLeft = true;
                        }
                    }
                }
            }

            if (AmountLeft == 1)
            {
                black.GetComponent<Image>().sprite = ShowStage2;
            }

            if (AmountLeft == 2)
            {
                black.GetComponent<Image>().sprite = ShowStage3;
            }

            if (AmountLeft == 3)
            {
                black.GetComponent<Image>().sprite = ShowStage4;
            }


        }

        if (WichCamera == 2)
        {
            WichCameraShower.GetComponent<Text>().text = "Dining Area";

            if (WhereBonnie == 2)
            {
                black.GetComponent<Image>().sprite = DiningArea2;
            }
            else
            {
                black.GetComponent<Image>().sprite = DiningArea1;
            }
        }

        if (WichCamera == 3)
        {
            WichCameraShower.GetComponent<Text>().text = "Pirate Cove";

            if (WhereFoxy == 2)
            {
                black.GetComponent<Image>().sprite = PirateCove2;
            }

            if (WhereFoxy >= 3)
            {
                black.GetComponent<Image>().sprite = PirateCove3;
            }

            if (WhereFoxy <= 1)
            {
                black.GetComponent<Image>().sprite = PirateCove1;
            }
        }

        if (WichCamera == 4)
        {
            WichCameraShower.GetComponent<Text>().text = "West-Hall";

            if (WhereBonnie == 5)
            {
                black.GetComponent<Image>().sprite = WestHall1_2;
            }
            else
            {
                black.GetComponent<Image>().sprite = WestHall1_1;
            }
        }

        if (WichCamera == 5)
        {
            WichCameraShower.GetComponent<Text>().text = "West-Hall";

            if (WhereBonnie == 6)
            {
                black.GetComponent<Image>().sprite = WestHall2_2;
            }
            else
            {
                black.GetComponent<Image>().sprite = WestHall2_1;
            }
        }

        if (WichCamera == 6)
        {
            WichCameraShower.GetComponent<Text>().text = "Closet";

            if (WhereBonnie == 4)
            {
                black.GetComponent<Image>().sprite = Closet2;
            }
            else
            {
                black.GetComponent<Image>().sprite = Closet1;
            }
        }

        if (WichCamera == 7)
        {
            WichCameraShower.GetComponent<Text>().text = "East-Hall";

            if (WhereChica == 5)
            {
                black.GetComponent<Image>().sprite = EastHall1_2;
            }
            else if (WhereChica == 6)
            {
                black.GetComponent<Image>().sprite = EastHall1_3;
            }
            else
            {
                black.GetComponent<Image>().sprite = EastHall1_1;
            }
        }

        if (WichCamera == 8)
        {
            WichCameraShower.GetComponent<Text>().text = "East-Hall";

            if (WhereChica == 7)
            {
                if (WhereFreddy <= 1)
                {
                    black.GetComponent<Image>().sprite = EastHall2_2;
                }
            }

            else
            {
                black.GetComponent<Image>().sprite = EastHall2_1;
            }

            if (WhereFreddy == 2)
            {
                if (WhereChica <= 6)
                {
                    black.GetComponent<Image>().sprite = EastHall2_3;
                }
            }

            else
            {
                black.GetComponent<Image>().sprite = EastHall2_1;
            }
        }

        if (WichCamera == 8)
        {

        }

        if (WichCamera == 9)
        {
            WichCameraShower.GetComponent<Text>().text = "Backstage";

            if (WhereBonnie == 3)
            {
                black.GetComponent<Image>().sprite = BackStage2;
            }
            else
            {
                black.GetComponent<Image>().sprite = BackStage1;
            }
        }

        if (WichCamera == 10)
        {
            WichCameraShower.GetComponent<Text>().text = "Kitchen";

            if (WhereChica == 5)
            {
                black.GetComponent<Image>().sprite = Kitchen1;
            }
            else
            {
                black.GetComponent<Image>().sprite = Kitchen1;
            }
        }

        if (WichCamera == 11)
        {
            WichCameraShower.GetComponent<Text>().text = "Restrooms";

            if (WhereChica == 3)
            {
                black.GetComponent<Image>().sprite = RestRooms2;
            }
            else if (WhereChica == 4)
            {
                black.GetComponent<Image>().sprite = RestRooms3;
            }
            else
            {
                black.GetComponent<Image>().sprite = RestRooms1;
            }
        }

        if (WhereBonnie < 7)
        {
            OfficeObject.GetComponent<RandNumberGen>().BonnieOutsideLeftDoor = false;
        }


        if (WhereBonnie >= 7)
        {
            OfficeObject.GetComponent<Movement>().BonnieOutsideDoor = true;
            OfficeObject.GetComponent<RandNumberGen>().BonnieOutsideLeftDoor = true;
        }
        if (WhereBonnie >= 8)
        {
            BonnieJumpscare.SetActive(true);
            isBeingJumpscared = true;
            OriginalOfficeImage.SetActive(false);

            LowerCanvas.SetActive(false);
            CamViewTabletOpen.SetActive(false);
            CamViewTabletClose.SetActive(false);
            Black.SetActive(false);
            Image.SetActive(false);
            Dot.SetActive(false);
            StripeGlitches.SetActive(false);
            AudioSources.SetActive(false);
            Phonecalls.SetActive(false);

        }

        if (WhereChica < 8)
        {
            OfficeObject.GetComponent<RandNumberGen>().ChicaOutsideRightDoor = false;
        }

        if (WhereChica >= 8)
        {
            OfficeObject.GetComponent<Movement>().ChicaOutsideDoor = true;
            OfficeObject.GetComponent<RandNumberGen>().ChicaOutsideRightDoor = true;
        }
        if (WhereChica >= 9)
        {
            if (camIsUp)
            {
                ChicaJumpscare.SetActive(true);
                isBeingJumpscared = true;
                OriginalOfficeImage.SetActive(false);

                LowerCanvas.SetActive(false);
                CamViewTabletOpen.SetActive(false);
                CamViewTabletClose.SetActive(false);
                Black.SetActive(false);
                Image.SetActive(false);
                Dot.SetActive(false);
                StripeGlitches.SetActive(false);
                AudioSources.SetActive(false);
                Phonecalls.SetActive(false);
            }
        }
        if (WhereFreddy >= 2)
        {
            OfficeObject.GetComponent<Movement>().FreddyOutsideDoor = true;
            OfficeObject.GetComponent<RandNumberGen>().FreddyOutsideRightDoor = true;
        }

        if (WhereFreddy >= 3)
        {
            FreddyJumpscare.SetActive(true);
            isBeingJumpscared = true;
            OriginalOfficeImage.SetActive(false);

            LowerCanvas.SetActive(false);
            CamViewTabletOpen.SetActive(false);
            CamViewTabletClose.SetActive(false);
            Black.SetActive(false);
            Image.SetActive(false);
            Dot.SetActive(false);
            StripeGlitches.SetActive(false);
            AudioSources.SetActive(false);
            Phonecalls.SetActive(false);
        }

        if (WhereFoxy >= 3)
        {
            if (WichCamera == 4)
            {
                if (camIsUp)
                {
                    foxyStarted = true;
                }

                if (foxyStarted)
                {
                    FoxyRunDownHall.SetActive(true);

                    foxyRunTime -= Time.deltaTime;
                }

                if (foxyRunTime <= 0)
                {
                    if (!L_Door_Closed)
                    {
                        FoxyEnterOffice.SetActive(true);
                        OriginalOfficeImage.GetComponent<Image>().enabled = false;
                        FoxyRunDownHall.SetActive(false);

                        LowerCanvas.SetActive(false);
                        ResetPoint.SetActive(false);
                        Phonecalls.SetActive(false);
                        AudioSources.SetActive(false);
                        CamViewTabletClose.SetActive(false);
                        CamViewTabletOpen.SetActive(false);
                        Dot.SetActive(false);
                        Black.SetActive(false);
                        StripeGlitches.SetActive(false);

                        if (foxyRunTime <= -3)
                        {
                            SceneManager.LoadScene("GameOver");
                            foxyRunTime = 3.5f;
                            foxyStarted = false;
                        }
                    }

                    if (L_Door_Closed)
                    {
                        DoorBang.Play();
                        OfficeObject.GetComponent<Movement>().WhereFoxy = 1;
                        OfficeObject.GetComponent<Movement>().foxyInCount = false;
                        OfficeObject.GetComponent<Movement>().GenNumber();
                        OriginalOfficeImage.GetComponent<Image>().enabled = true;
                        FoxyRunDownHall.SetActive(false);

                        foxyRunTime = 3.5f;
                        foxyStarted = false;
                    }
                }

            }

            if (!camIsUp)
            {
                FoxyRunDownHall.SetActive(false);
            }
        }

        if (isBeingJumpscared)
        {
            WaitJumpscare -= Time.deltaTime;

            if (WaitJumpscare <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }

    }

    public void cam1a()
    {
        WichCamera = 1;
    }

    public void cam1b()
    {
        WichCamera = 2;
    }

    public void cam1c()
    {
        WichCamera = 3;
    }

    public void cam2a()
    {
        WichCamera = 4;
    }

    public void cam2b()
    {
        WichCamera = 5;
    }

    public void cam3()
    {
        WichCamera = 6;
    }

    public void cam4a()
    {
        WichCamera = 7;
    }

    public void cam4b()
    {
        WichCamera = 8;
    }

    public void cam5()
    {
        WichCamera = 9;
    }

    public void cam6()
    {
        WichCamera = 10;
    }

    public void cam7()
    {
        WichCamera = 11;
    }
}
