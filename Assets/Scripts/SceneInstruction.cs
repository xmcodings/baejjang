using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneInstruction : MonoBehaviour
{

    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;

    void Start()
    {

    }


    public void SceneSwitcher()
    {
        SceneManager.LoadScene("InstructionScene", LoadSceneMode.Single);

    }

}
