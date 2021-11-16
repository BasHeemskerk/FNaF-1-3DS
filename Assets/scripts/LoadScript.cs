using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour {

    public GameObject LowerCanvas;
    public GameObject AudioSources;
    public GameObject Loader;
    public GameObject DoorButtons_L;
    public GameObject DoorButtons_R;
    public GameObject Fan;

    public float WhereBonnie = 1;
    public float WhereChica = 1;
    public float WhereFreddy = 1;
    public float WhereFoxy = 1;

    void Start()
    {
        Resources.UnloadUnusedAssets();


        StartCoroutine(Update());
    }

    IEnumerator Update()
    {
        PlayerPrefs.SetFloat("WhereBonnie", WhereBonnie);
        PlayerPrefs.SetFloat("WhereChica", WhereChica);
        PlayerPrefs.SetFloat("WhereFreddy", WhereFreddy);
        PlayerPrefs.SetFloat("WhereFoxy", WhereFoxy);
        PlayerPrefs.Save();

        yield return new WaitForSeconds(0.3f);

        LowerCanvas.SetActive(true);

        yield return new WaitForSeconds(0.1f);

        AudioSources.SetActive(true);

        yield return new WaitForSeconds(0.1f);

        DoorButtons_L.SetActive(true);
        DoorButtons_R.SetActive(true);
        Fan.SetActive(true);

        yield return new WaitForSeconds(0.1f);

        Loader.SetActive(false);
    }
}
