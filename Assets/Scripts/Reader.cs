using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reader : MonoBehaviour
{
    public Text finish_1;
    public Text finish_2;
    public Text finish_3;
    public void Update()
    {
        if (Info.last_finish_1 == 0)
        {
            finish_1.text = "Lvl1: Last finish " + '\n' + "The fastest finish ";
        }
        else
        {
            finish_1.text = "Lvl1: Last finish " + Info.last_finish_1.ToString() + '\n' + "The fastest finish " + Info.fast_finish_1.ToString();
        }
        if (Info.last_finish_2 == 0)
        {
            finish_2.text = "Lvl2: Last finish " + '\n' + "The fastest finish ";
        }
        else
        {
            finish_2.text = "Lvl2: Last finish " + Info.last_finish_2.ToString() + '\n' + "The fastest finish " + Info.fast_finish_2.ToString();
        }
        if (Info.last_finish_3 == 0)
        {
            finish_3.text = "Lvl3: Last finish " + '\n' + "The fastest finish ";
        }
        else
        {
            finish_3.text = "Lvl3: Last finish " + Info.last_finish_3.ToString() + '\n' + "The fastest finish " + Info.fast_finish_3.ToString();
        }
    }
}
