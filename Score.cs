using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform possitionPlayer;
    public Text score;

    void Update()
    {
        score.text =  ((int)possitionPlayer.position.z).ToString();
    }
}
