using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberOfLevels : MonoBehaviour
{
    public Text numberOFLevels;
    void Start()
    {
        numberOFLevels.text = ("Level " + (SceneManager.GetActiveScene().buildIndex));
    }
}