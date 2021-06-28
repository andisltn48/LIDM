using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class InputScript : MonoBehaviour
{
    public static string nameObject;
    public static int scene;
    public GameObject text;
    // Update is called once per frame
    public void Input()
    {
        nameObject = text.name;
        Debug.Log(nameObject);
        SceneManager.LoadScene(2);
        scene = SceneManager.GetActiveScene().buildIndex;
    }
}
