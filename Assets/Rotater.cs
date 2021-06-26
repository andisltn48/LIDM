using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;
using UnityEngine.EventSystems;

public class Rotater : MonoBehaviour
{
    private string objects;

 
    public void RotateX()
    {

        objects = Spawner2.Object;
        var rotate = GameObject.Find(objects + "(Clone)");

        Debug.Log(objects + "(Clone)");
        rotate.transform.Rotate(10f, 0, 0);
        
    }

    public void RotateY()
    {
        objects = Spawner2.Object;
        var rotate = GameObject.Find(objects + "(Clone)");

        Debug.Log(objects + "(Clone)");
        rotate.transform.Rotate(0, 10f, 0);

    }

    public void RotateZ()
    {
        objects = Spawner2.Object;
        var rotate = GameObject.Find(objects + "(Clone)");

        Debug.Log(objects + "(Clone)");
        rotate.transform.Rotate(0, 0, 10f);

    }

}
