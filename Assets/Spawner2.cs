using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Spawner2 : MonoBehaviour
{
    void Start()
    {
        var name = InputScript.nameObject;
        //var objectName = Receiver.nameObject;
        Debug.Log(name);
        if (Count > 0)
        {
            Destroy(GameObject.Find(Object + "(Clone)"), 0);
        }
        //pos
        // Called via:
        var loadedPrefabResource = LoadPrefabFromFile(name);
        // Transform prefabResource = LoadPrefabFromFile(name) as Transform;
        Instantiate(loadedPrefabResource, transform);
        Object = name;
        Count = Count + 1;
    }

    private int Count = 0;
    public static string Object = "";
    // Start is called before the first frame update
    private UnityEngine.Object LoadPrefabFromFile(string filename)
    {
        Debug.Log("Trying to load LevelPrefab from file (" + filename + ")...");
        var loadedObject = Resources.Load("Prefabs/" + filename);
        if (loadedObject == null)
        {
            throw new FileNotFoundException("...no file found - please check the configuration");
        }
        return loadedObject;
    }

    public void Reset()
    {
        var name = InputScript.nameObject;
    //var objectName = Receiver.nameObject;
        Debug.Log(name);
        if (Count>0)
        {
            Destroy(GameObject.Find(Object+"(Clone)"), 0);
        }
        //pos
        // Called via:
        var loadedPrefabResource = LoadPrefabFromFile(name);
        // Transform prefabResource = LoadPrefabFromFile(name) as Transform;
        Instantiate(loadedPrefabResource, transform);
        Object = name;
        Count = Count + 1;
    }

    public void ChangeObject()
    {
        SceneManager.LoadScene(InputScript.scene);
    }

}
