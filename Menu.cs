using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        if (PlayerPrefs.GetInt("NumberOfLoads") == 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            SceneManager.LoadScene(PlayerPrefs.GetInt("CurentLevel"));

        PlayerPrefs.SetInt("NumberOfLoads", PlayerPrefs.GetInt("NumberOfLoads") + 1);

        if (PlayerPrefs.GetInt("CurentLevel") >= 10)
            PlayerPrefs.DeleteAll();
    }
}
