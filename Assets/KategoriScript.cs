using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class KategoriScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Kategori()
    {
        var selectedKategory = EventSystem.current.currentSelectedGameObject.name;

        SceneManager.LoadScene(selectedKategory + " Scene");
    }
    public void SubKategori()
    {
        var selectedKategory = EventSystem.current.currentSelectedGameObject.name;

        SceneManager.LoadScene(selectedKategory + " Scene");
    }
}
