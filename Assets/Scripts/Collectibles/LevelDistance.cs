using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public int disRun;
    public bool addingDis = false;
    public float disDelay = 0.25f;

    void Update()
    {
       if(addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }

    IEnumerator AddingDis()
    {
        disRun += 1;
        disDisplay.GetComponent<TextMeshProUGUI>().text = "" + disRun;
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
    }


}
