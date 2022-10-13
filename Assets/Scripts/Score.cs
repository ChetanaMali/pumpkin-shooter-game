using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour

{
    [SerializeField] Transform player;
    [SerializeField] Text scoreText;
    int convertPositionZ = 0;
    int score=0;
    public void scoreupd()
    {
         score++;
         scoreText.text = score.ToString();
         //Debug.Log(score);
    }

}