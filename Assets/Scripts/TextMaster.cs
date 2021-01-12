using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMaster : MonoBehaviour
{
    //singleton pattern
    //one instance of build manager referencing itself
    public static TextMaster instance;

    public GameObject buildErrorTextObject;
    //public Text buildErrorText;
    //public GameObject mainCanvas;


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one TextMaster in scene");
            return;
        }
        instance = this;
    }


    public void spawnText(string newText, Vector2 position)
    {
        //buildErrorText.text = newText;
        //Text spawnedText = (Text)Instantiate(buildErrorText, position, Quaternion.identity);
        //spawnedText.transform.SetParent(mainCanvas.transform);
        GameObject spawnedText = (GameObject)Instantiate(buildErrorTextObject, position, Quaternion.identity);
        //TextMesh theText = spawnedText.transform.GetComponent<TextMesh>();
        TextMesh theText = spawnedText.transform.GetComponentInChildren<TextMesh>();
        theText.text = newText;
        
        Destroy(spawnedText, 3f);   //destroy after 3s
    }

}
