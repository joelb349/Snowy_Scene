using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour
{

    public GameObject uIObject;
    // Start is called before the first frame update
    void Start()
    {

        uIObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf)
        {
            uIObject.SetActive(true);
            StartCoroutine("WaitForSec");
            StartCoroutine("Wait");
        }

    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        GameObject canvasObject = GameObject.FindGameObjectWithTag("Main Canvas");
        Transform text1 = canvasObject.transform.Find("Text1");
        Transform text2 = canvasObject.transform.Find("Text2");
        text1.GetComponent<Text>().enabled = false;
        text2.GetComponent<Text>().enabled = true;

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        uIObject.SetActive(false);
    }
}
