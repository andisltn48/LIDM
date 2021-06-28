using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavbarScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Book()
    {
        SceneManager.LoadScene("Harimau Scene");
        QuizScriptPanel.tempototal = 0; QuizScriptPanel.benar = 0; QuizScriptPanel.salah = 0; QuizScriptPanel.fixtotal = 0;
    }
    public void Quiz()
    {
        SceneManager.LoadScene("Hasil Scene");
    }
    public void nilai()
    {
        SceneManager.LoadScene("HasilOrtu Scene");
    }
    public void logout()
    {
        SceneManager.LoadScene("Login Scene");
    }
    public void halamanOrtu()
    {
        SceneManager.LoadScene("HalamanOrtu Scene");
    }
}
