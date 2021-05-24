using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Script_clicker : MonoBehaviour
{
    public Text text_score;
    public Text text_price;
    public Text text_map1;
    public Text text_map2;
    public Text text_map3;
    public static int score;
    public static int price = 1;
    public static int mult = 1;
    public static bool avalueable_map1 = false;
    public static bool avalueable_map2 = false;
    public static bool avalueable_map3 = false;
    public void OnClick()
    {
        score += mult;
        text_score.text = score + " point(s)";
    }
    public void BuyMultiply()
    {
        if (score >= price)
        {
            score -= price;
            text_score.text = score + " point(s)";
            price *= 2;
            ++mult;
            text_price.text = "price: "+ price + '\n' + " point(s)" + '\n' + "X" + mult;
        }
    }
    public void BuyMap1()
    {
        if (avalueable_map1 == true)
        {
            SceneManager.LoadScene(2);
        }
        if (score >= 100 && avalueable_map1 == false)
        {
            score -= 100;
            avalueable_map1 = true;
            text_score.text = score + " point(s)";
            text_map1.text = "Play Lvl";
        }
    }
    public void BuyMap2()
    {
        if (avalueable_map2 == true)
        {
            SceneManager.LoadScene(3);
        }
        if (score >= 300 && avalueable_map2 == false)
        {
            score -= 300;
            avalueable_map2 = true;
            text_map2.text = "Play Lvl";
            text_score.text = score + " point(s)";
        }

    }
    public void BuyMap3()
    {
        if (avalueable_map3 == true)
        {
            SceneManager.LoadScene(4);
        }
        if (score >= 600 && avalueable_map3 == false)
        {
            score -= 600;
            avalueable_map3 = true;
            text_map3.text = "Play Lvl";
            text_score.text = score + " point(s)";
        }
    }
    public void Update()
    {
        text_score.text = score + " point(s)";
        text_price.text = "price: " + price + '\n' + " point(s)" + '\n' + "X" + mult;
        if (avalueable_map1)
        {
            text_map1.text = "Play Lvl";
        }
        if (avalueable_map2)
        {
            text_map2.text = "Play Lvl";
        }
        if (avalueable_map3)
        {
            text_map3.text = "Play Lvl";
        }
    }
}
