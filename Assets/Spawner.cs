using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Spawner : MonoBehaviour
{
    public GameObject[] objectGame;
    private int Count = 0;
    public void Spawnit()
    {
        var selectedButton = EventSystem.current.currentSelectedGameObject.name;
        for (int i = 0; i < objectGame.Length; i++)
        {
            if (objectGame[i].transform.name == selectedButton)
            {
                if (Count > 0)
                {
                    for (int j = 0; j < objectGame.Length; j++)
                    {
                        Destroy(GameObject.Find(objectGame[j].transform.name + "(Clone)"), 0);
                    }
                       
                }
                transform.localPosition = new Vector3(0, 0, 5);
                //spawn our coin:
                Instantiate(objectGame[i], transform.localPosition, Quaternion.identity);
                Count = Count + 1;
            }



        }
    }
}
