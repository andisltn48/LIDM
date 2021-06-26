﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HasilScript : MonoBehaviour
{
    public static List<string> nameBooks = new List<string>();
    public static List<int> nilaiOfBook = new List<int>();
    public GameObject child, parent;
    private int y = 430;
    public Text text; 
    // Start is called before the first frame update
    private void Awake()
    {
        for(int i=0; i < nameBooks.Count; i++)
        {
            for(int j = 0; j<nilaiOfBook.Count; j++)
                if(i == j)
                {

                    var childern = Instantiate(child);
                    childern.transform.parent = parent.transform;
                    childern.transform.localPosition = new Vector3(0, 0, 0);
                    childern.transform.localScale = new Vector3(3, 3, 3);
                    childern.GetComponentInChildren<Text>().text = nameBooks[i] + "     (" +nilaiOfBook[j] +")";
                }
        }
    }
}
