using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PouseMenu : MonoBehaviour
{
    public static bool gameIsPoused = false;

    public GameObject pouseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {

            if (gameIsPoused)
            {
                Resume();
            }
            else {
                Pouse();
            }
        }
    }

    public void Resume() {
        pouseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPoused = false;
    }

    void Pouse()
    {

        pouseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPoused = true;
    }

    public void LoadMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void QuitGame() {
        Application.Quit();
    }
}
