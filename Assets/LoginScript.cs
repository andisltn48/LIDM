using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoginScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Login()
    {
        var selectedRole = EventSystem.current.currentSelectedGameObject.name;

        SceneManager.LoadScene(selectedRole + " Scene");
    }
}
