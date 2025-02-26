using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanagement : MonoBehaviour
{
    public GameObject settingsPanel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadLevelOne(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    public void CloseSettings()
    {
        PlayerPrefs.Save();
        settingsPanel.SetActive(false);
    }
    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }
    public void LoadSkins()
    {
        SceneManager.LoadScene("Skins");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("has quit");
    }
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
