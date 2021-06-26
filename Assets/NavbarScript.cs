using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavbarScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Book()
    {
        SceneManager.LoadScene(0);
        QuizScriptPanel.tempototal = 0; QuizScriptPanel.benar = 0; QuizScriptPanel.salah = 0; QuizScriptPanel.fixtotal = 0;
    }
    public void Quiz()
    {
        SceneManager.LoadScene(2);
    }
}
