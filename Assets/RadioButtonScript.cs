using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class RadioButtonScript : MonoBehaviour
{
    [SerializeField] private Toggle toggle1, toggle2, toggle3, toggle4;
    public static int nums;
    public int index = 0;
    // Start is called before the first frame update
     

    public void toggle1Selected()
    {
        nums = 0;
    }

    public void toggle2Selected()
    {
        nums = 1;
    }

    public void toggle3Selected()
    {
        nums = 2;
    }

    public void toggle4Selected()
    {
        nums = 3;
    }

    // Update is called once per frame
    
}
