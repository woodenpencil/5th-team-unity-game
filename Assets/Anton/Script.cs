using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Script : MonoBehaviour
{
    public Text text_score;
    public int score;
    public void OnClickChicken()
    {
        score++;
        text_score.text = score + " point(s)";
    }
    
}
