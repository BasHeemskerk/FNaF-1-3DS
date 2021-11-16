using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Office : MonoBehaviour {

    public GameObject OfficeImage;
    public RectTransform OfficeBounds;

    public GameObject OfficeControllerObject;

    public float Max;

    public GameObject Door_L_closed;
    public GameObject Door_L_open;

    public GameObject Door_R_closed;
    public GameObject Door_R_open;

    public GameObject DoorButton_L1;
    public GameObject DoorButton_L2;
    public GameObject DoorButton_L3;
    public GameObject DoorButton_L4;

    public GameObject DoorButton_R1;
    public GameObject DoorButton_R2;
    public GameObject DoorButton_R3;
    public GameObject DoorButton_R4;

    public GameObject Light_L_No_Door;
    public GameObject Light_L_Door_Bonnie;

    public GameObject Light_R_No_Door;
    public GameObject Light_R_Door_Chica;

    public bool L_Door_Closed = false;
    public bool R_Door_Closed = false;

    public GameObject OriginalOfficeImage;

    public AudioSource DoorClose;
    public AudioSource Light;

    public float speed = 230f;


    public bool BonnieOutsideDoor = false;
    public bool ChicaOutsideDoor = false;
    public bool FreddyOutsideDoor = false;
    public bool FoxyRunningHallway = false;

    public bool LeftLightIsOn = false;
    public bool RightLightIsOn = false;

    public AudioSource Scare;

    void Start()
    {
        SceneManager.UnloadSceneAsync("MainMenu");
        SceneManager.UnloadSceneAsync("GameOver");
        SceneManager.UnloadSceneAsync("6AM");
        SceneManager.UnloadSceneAsync("NextNight");
        SceneManager.UnloadSceneAsync("Controlls");
        SceneManager.UnloadSceneAsync("Advertisement");
        SceneManager.UnloadSceneAsync("PowerOut");
        SceneManager.UnloadSceneAsync("TheEnd");
        SceneManager.UnloadSceneAsync("CostumNight");
    }

    void Update()
    {

        Resources.UnloadUnusedAssets();

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Max += 1 * Time.deltaTime;

            if (Max > 0.3495193f)
            {
                Max = 0.3495193f;
            }
            
            if (Max < 0.3495193f)
            {
                OfficeImage.transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.Keypad4))
        {
            Max += 1 * Time.deltaTime;

            if (Max > 0.3495193f)
            {
                Max = 0.3495193f;
            }

            if (Max < 0.3495193f)
            {
                OfficeImage.transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Max -= 1 * Time.deltaTime;

            if (Max < -0.5801594f)
            {
                Max = -0.5801594f;
            }

            if (Max > -0.5801594f)
            {
                OfficeImage.transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.Keypad6))
        {
            Max -= 1 * Time.deltaTime;

            if (Max < -0.5801594f)
            {
                Max = -0.5801594f;
            }

            if (Max > -0.5801594f)
            {
                OfficeImage.transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }


        //-----------------------------------------------
        if (Max == 0.3495193f)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (!L_Door_Closed)
                {
                    Door_L_closed.SetActive(true);
                    Door_L_open.SetActive(false);
                    L_Door_Closed = true;
                    DoorButton_L1.SetActive(false);
                    DoorButton_L2.SetActive(true);

                    DoorClose.Play();


                    OfficeControllerObject.GetComponent<GameScript>().PowerUsage += 1;

                    OfficeControllerObject.GetComponent<Movement>().LeftDoorClosed = true;

                    OfficeControllerObject.GetComponent<ChangeImages>().L_Door_Closed = true;

                }
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                if (L_Door_Closed)
                {
                    Door_L_closed.SetActive(false);
                    Door_L_open.SetActive(true);
                    L_Door_Closed = false;
                    DoorButton_L1.SetActive(true);
                    DoorButton_L2.SetActive(false);
                    DoorButton_R4.SetActive(false);

                    DoorClose.Play();

                    OfficeControllerObject.GetComponent<GameScript>().PowerUsage -= 1;

                    OfficeControllerObject.GetComponent<Movement>().LeftDoorClosed = false;
                    OfficeControllerObject.GetComponent<ChangeImages>().L_Door_Closed = false;

                }
            }

            //-------------------------------------LIGHT---------------------------------------------------------------------------------------------------

            if (Input.GetKeyDown(KeyCode.B))
            {
                LeftLightIsOn = true;

                if (!BonnieOutsideDoor)
                {
                    Light_L_No_Door.SetActive(true);
                    Light.Play();
                }

                if (BonnieOutsideDoor)
                {
                    Light_L_Door_Bonnie.SetActive(true);
                    Light.Play();

                    if (!L_Door_Closed)
                    {
                        Scare.Play();
                    }
                }

                OriginalOfficeImage.GetComponent<Image>().enabled = false;

                OfficeControllerObject.GetComponent<GameScript>().PowerUsage += 1;

                DoorButton_L3.SetActive(true);

                if (L_Door_Closed)
                {
                    DoorButton_L1.SetActive(false);
                    DoorButton_L4.SetActive(true);
                }
            }
        }
        //-----------------------------------------------

        //-----------------------------------------------
        if (Max == -0.5801594f)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (!R_Door_Closed)
                {
                    Door_R_closed.SetActive(true);
                    Door_R_open.SetActive(false);
                    R_Door_Closed = true;
                    DoorButton_R1.SetActive(false);
                    DoorButton_R2.SetActive(true);

                    DoorClose.Play();

                    OfficeControllerObject.GetComponent<GameScript>().PowerUsage += 1;

                    OfficeControllerObject.GetComponent<Movement>().RightDoorClosed = true;

                }
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                if (R_Door_Closed)
                {
                    Door_R_closed.SetActive(false);
                    Door_R_open.SetActive(true);
                    R_Door_Closed = false;
                    DoorButton_R1.SetActive(true);
                    DoorButton_R2.SetActive(false);
                    DoorButton_R4.SetActive(false);

                    DoorClose.Play();

                    OfficeControllerObject.GetComponent<GameScript>().PowerUsage -= 1;

                    OfficeControllerObject.GetComponent<Movement>().RightDoorClosed = false;
                }
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                RightLightIsOn = true;

                if (!ChicaOutsideDoor)
                {
                    Light_R_No_Door.SetActive(true);
                    Light.Play();
                }

                if (ChicaOutsideDoor)
                {
                    Light_R_Door_Chica.SetActive(true);
                    Light.Play();

                    if (!R_Door_Closed)
                    {
                        Scare.Play();
                    }
                }

                OfficeControllerObject.GetComponent<GameScript>().PowerUsage += 1;

                DoorButton_R3.SetActive(true);

                if (R_Door_Closed)
                {
                    DoorButton_R1.SetActive(false);
                    DoorButton_R4.SetActive(true);
                }
            }
        }
        //-----------------------------------------------

        //-----------------------------------------------
        if (Input.GetKeyUp(KeyCode.B))
        {
            if (LeftLightIsOn)
            {
                if (!BonnieOutsideDoor)
                {
                    Light_L_No_Door.SetActive(false);
                    Light.Pause();
                }

                if (BonnieOutsideDoor)
                {
                    Light_L_Door_Bonnie.SetActive(false);
                    Light.Pause();
                }

                OriginalOfficeImage.GetComponent<Image>().enabled = true;

                DoorButton_L3.SetActive(false);

                if (L_Door_Closed)
                {
                    DoorButton_L1.SetActive(true);
                    DoorButton_L4.SetActive(false);
                }

                OfficeControllerObject.GetComponent<GameScript>().PowerUsage -= 1;

                LeftLightIsOn = false;
            }


            if (RightLightIsOn)
            {
                if (!ChicaOutsideDoor)
                {
                    Light_R_No_Door.SetActive(false);
                    Light.Pause();
                }

                if (ChicaOutsideDoor)
                {
                    Light_R_Door_Chica.SetActive(false);
                    Light.Pause();
                }

                OriginalOfficeImage.GetComponent<Image>().enabled = true;

                DoorButton_R3.SetActive(false);

                if (R_Door_Closed)
                {
                    DoorButton_R1.SetActive(true);
                    DoorButton_R4.SetActive(false);
                }

                OfficeControllerObject.GetComponent<GameScript>().PowerUsage -= 1;

                RightLightIsOn = false;
            }


        }
        //----------------------------------------------

        //----------------------------------------------
        if (Input.GetKey(KeyCode.B))
        {
            if (BonnieOutsideDoor)
            {
                if (OfficeControllerObject.GetComponent<Movement>().BonnieOutsideDoorTime <= 2)
                {
                    OfficeControllerObject.GetComponent<Movement>().BonnieOutsideDoorTime = 1;
                }
            }

            if (ChicaOutsideDoor)
            {
                if (OfficeControllerObject.GetComponent<Movement>().ChicaOutsideDoorTime <= 2)
                {
                    OfficeControllerObject.GetComponent<Movement>().ChicaOutsideDoorTime = 1;
                }
            }

            if (FreddyOutsideDoor)
            {
                if (OfficeControllerObject.GetComponent<Movement>().FreddyOutsideDoorTime <= 2)
                {
                    OfficeControllerObject.GetComponent<Movement>().FreddyOutsideDoorTime = 1;
                }
            }
        }
        //-------------------------------------------------

        if (BonnieOutsideDoor)
        {
            if (L_Door_Closed)
            {
                OfficeControllerObject.GetComponent<Movement>().BonnieOutsideDoor = true;
                OfficeControllerObject.GetComponent<ChangeImages>().WhereBonnie = 2;
            }
        }

        if (ChicaOutsideDoor)
        {
            if (R_Door_Closed)
            {
                OfficeControllerObject.GetComponent<Movement>().ChicaOutsideDoor = true;
                OfficeControllerObject.GetComponent<ChangeImages>().WhereChica = 2;
            }
        }

        if (FreddyOutsideDoor)
        {
            if (R_Door_Closed)
            {
                OfficeControllerObject.GetComponent<Movement>().FreddyOutsideDoor = true;
                OfficeControllerObject.GetComponent<ChangeImages>().WhereFreddy = 1;
            }
        }
    }
}
