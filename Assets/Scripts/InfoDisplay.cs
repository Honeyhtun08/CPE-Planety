using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;




public class InfoDisplay : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI myText;
    // Start is called before the first frame update
    public void SetTypeFromIndex(int index)
    {
        if (index == 0)
        {
            myText.text = "Welcome to Planety.";
        }

        if (index == 1)
        {

            myText.text = "Mercury\nTemperature: 167°C\nDay length: 1408 h\nRadius: 2440 km";
        }


        if (index == 2)
        {

            myText.text = "Venus\nTemperature: 464°C\nDay length: 5832 h\nRadius: 6052 km";
        }


        if (index == 3)
        {

            myText.text = "Earth\nTemperature: 15°C\nDay length: 24 h\nRadius: 6371 km";
        }


        if (index == 4)
        {

            myText.text = "Mars\nTemperature: -65°C\nDay length: 25 h\nRadius: 6371 km";
        }

        if (index == 5)
        {

            myText.text = "Jupiter\nTemperature: -110°C\nDay length: 10 h\nRadius: 69911 km";
        }

        if (index == 6)
        {

            myText.text = "Saturn\nTemperature: -140°C\nDay length: 11 h\nRadius: 58232 km";
        }

        if (index == 7)
        {

            myText.text = "Uranus\nTemperature: -195°C\nDay length: 17 h\nRadius: 25362 km";
        }

        if (index == 8)
        {

            myText.text = "Neptune\nTemperature: -200°C\nDay length: 16 h\nRadius: 24622 km";
        }


    }



}

