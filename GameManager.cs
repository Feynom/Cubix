using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameOver = false;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        PlayerPrefs.SetInt("CurentLevel", PlayerPrefs.GetInt("CurentLevel") + 1);
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            Invoke("RestartGame", 3);
        }
    }
    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
