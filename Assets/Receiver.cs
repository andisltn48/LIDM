using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    // Start is called before the first frame update
    public static string nameObject;

    void receiveObject(string name)
    {
        nameObject = name;
    }
}
