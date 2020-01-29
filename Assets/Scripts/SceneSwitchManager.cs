using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitchManager : MonoBehaviour
{

    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;

    void Start()
    {
       
    }


    public void SceneSwitcher()
    {
        SceneManager.LoadScene("mainPlayScene", LoadSceneMode.Single);
        
    }

}
