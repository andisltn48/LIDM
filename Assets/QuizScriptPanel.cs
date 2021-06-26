using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

public class QuizScriptPanel : MonoBehaviour
{
    List<int> nilai = new List<int>();
    public int currSoal;
    public int a, b, c, d, e;
    public static int tempototal = 0;
    public static int fixtotal = 0;
    private int result;
    public static int benar = 0;
    public static int salah = 0;
    public GameObject soal1, soal2, soal3, soal4, soal5, next, submit, panelHasil;
    public Text nilaiAkhir, salahValue, benarValue;
    public int index = 0;
    private void Start()
    {
        currSoal = 0;
        nilai.Add(a);
        nilai.Add(b);
        nilai.Add(c);
        nilai.Add(d);
        nilai.Add(e);
    }
    public void Next()
    {
        
        for(int i = 0; i < nilai.Count; i++)
        {
            
            if (i == currSoal)
            {
                Debug.Log(RadioButtonScript.nums);
                Debug.Log(nilai[i]);
                if (RadioButtonScript.nums == nilai[i])
                {
                    benar = benar + 1;
                    tempototal = tempototal + 20;
                }
                else
                {
                    salah = salah + 1;
                }

                RadioButtonScript.nums = 9;
            }
        }
        Debug.Log("Nilai:" + tempototal);
        index = index + 1;
        if (index == 1)
        {
            soal1.SetActive(false);
            soal2.SetActive(true);
            currSoal = 1;
        }
        else if (index == 2)
        {
            soal1.SetActive(false);
            soal2.SetActive(false);
            soal3.SetActive(true);

            currSoal = 2;
        }
        else if (index == 3)
        {
            soal1.SetActive(false);
            soal2.SetActive(false);
            soal3.SetActive(false);
            soal4.SetActive(true);
            currSoal = 3;
        }
        else if (index == 4)
        {
            soal1.SetActive(false);
            soal2.SetActive(false);
            soal3.SetActive(false);
            soal4.SetActive(false);
            soal5.SetActive(true);
            next.SetActive(false);
            submit.SetActive(true);

            currSoal = 4;
        }


    }

    public void Submit()
    {
        if (RadioButtonScript.nums == nilai[index])
        {
            RadioButtonScript.nums = 0;
            tempototal = tempototal + 20;
            benar = benar + 1;
        }
        else
        {
            salah = salah + 1;
        }

        fixtotal = tempototal;
        Debug.Log(fixtotal);
        HasilScript.nameBooks.Add(BookController.nameBook);
        HasilScript.nilaiOfBook.Add(fixtotal);
        panelHasil.SetActive(true);
        nilaiAkhir.text = fixtotal.ToString();
        benarValue.text = benar.ToString();
        salahValue.text = salah.ToString();


    }
}
