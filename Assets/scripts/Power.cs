using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Power : MonoBehaviour {

    public GameObject FreddySongDarkOffice;
    public GameObject freddyJumpScare;
    public GameObject Song;

    //---FLOATS---------------------------
    public float WaitBeforeStart = 20f;
    public float PlayTime = 15f;
    public float JumpscarePlayTime = 0.2f;

    void Start()
    {
        SceneManager.UnloadSceneAsync("Office");
    }

    void Update ()
    {
        Resources.UnloadUnusedAssets();

        WaitBeforeStart -= UnityEngine.Time.deltaTime;

        if (WaitBeforeStart <= 0)
        {
            Song.SetActive(true);
            FreddySongDarkOffice.GetComponent<Animator>().enabled = true;
            PlayTime -= UnityEngine.Time.deltaTime;
            WaitBeforeStart = 0;

            if (PlayTime <= 0)
            {
                FreddySongDarkOffice.GetComponent<Animator>().enabled = false;
                FreddySongDarkOffice.SetActive(false);

                freddyJumpScare.SetActive(true);
                PlayTime = 0;

                JumpscarePlayTime -= UnityEngine.Time.deltaTime;

                if (JumpscarePlayTime <= 0)
                {
                    SceneManager.LoadScene("GameOver");
                    JumpscarePlayTime = 0;
                }
            }
        }
    }
}
