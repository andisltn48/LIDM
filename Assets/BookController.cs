using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BookController : MonoBehaviour
{
    public static string nameBook;
    public static List<string> nameQuiz = new List<string>();
    public GameObject quizPanel;
    // Start is called before the first frame update
    public void selectedBook()
    {
        var selectedBook = EventSystem.current.currentSelectedGameObject.name;
        nameBook = selectedBook;
        Debug.Log(nameBook);
        SceneManager.LoadScene(nameBook+" Scene");

    }
    public void takeQuiz()
    {

        string nameBook = BookController.nameBook;
        nameQuiz.Add(nameBook);
        quizPanel.SetActive(true);
    }

    public void back2Book()
    {
        quizPanel.SetActive(false);
    }
}
