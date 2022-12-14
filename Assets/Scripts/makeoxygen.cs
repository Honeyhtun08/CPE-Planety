using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class makeoxygen : MonoBehaviour
{
    public GameObject Panel;

    public void StartBtn()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }
    [SerializeField]
    TextMeshProUGUI myText;
    public void StartOxygen()
    {

        StartCoroutine(OxygenVolume());
    }

    public void StopOxygen()

    {
        StopCoroutine(OxygenVolume());
    }

IEnumerator OxygenVolume()
{
    float a = 0;
    while( a < 1000000)
    {

        a = a + 10;
        myText.text = a.ToString();
        yield return null;
    }
 }


private void Update()
{

    if (Input.GetKeyDown(KeyCode.Space))
    {
        StartOxygen();
    }
}
}
