using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class TargetsWithAnswers : MonoBehaviour
{
    public BillboardWithFinalQ BillBoardWithFinalQScript;

    public GameObject TargetAObject;
    public GameObject TargetBObject;
    public GameObject TargetCObject;

    public Dictionary<int, string[]> ListOfTestAs = new Dictionary<int, string[]>
    {
        {0, new string[] { "A. Random Access Memory", "B. Radioactive Active Memory", "C. Railroad Active Marching"}},
        {1, new string[] { "A. RAM", "B. Power Supply", "C. GPU"}},

        {2, new string[] { "A. CPU", "B. GPU", "C. RAM"}},
        {3, new string[] { "A. RAM", "B. CPU", "C. GPU"}},

        {4, new string[] { "A. GHz", "B. MHz", "C. Bytes"}},
        {5, new string[] { "A. Overclocked", "B. Integrated", "C. Multi-core"}},
    };

    public Dictionary<int, string[]> CorrectTestA = new Dictionary<int, string[]>
    {
        //RAM Q' A's
        {0, new string[] { "Y", "N", "N" }},
        {1, new string[] { "Y", "N", "N" }},

        {2, new string[] { "N", "Y", "N" }},
        {3, new string[] { "N", "N", "Y" }},

        {4, new string[] { "Y", "N", "N" }},
        {5, new string[] { "N", "N", "Y" }},
    };

    //public

    public TextMeshPro AnswerAText;
    public TextMeshPro AnswerBText;
    public TextMeshPro AnswerCText;

    public string AnswerACorrectness = "";
    public string AnswerBCorrectness = "";
    public string AnswerCCorrectness = "";

    public int keyRandNum;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        BillBoardWithFinalQScript = FindAnyObjectByType<BillboardWithFinalQ>();
        //keyRandNum = BillBoardWithFinalQScript.randomNum;

        AnswerAText.text = ListOfTestAs[0][0];
        AnswerBText.text = ListOfTestAs[0][1];
        AnswerCText.text = ListOfTestAs[0][2];

        AnswerACorrectness = CorrectTestA[0][0];
        AnswerBCorrectness = CorrectTestA[0][1];
        AnswerCCorrectness = CorrectTestA[0][2];

        // Update is called once per frame
        

    }


   
    void Update()
    {

    }


}
















/*    public Dictionary<int, (string[], bool[])> ListOfTestAs = new Dictionary<int, (string[], bool[])>
    {
        //FORMAT: {0, new (new string[] { "x", "y" }, new bool[] { true, false })},

        //RAM RELATED Q's W/ ASSOCIATED HINT
        { 0, new(new string[] { "A. Random Access Memory", "B. E", "C. E" }, new bool[] { true, false, true }) },
        { 1, new(new string[] { "A. Random Access Memory", "B. E", "C. E" }, new bool[] { true, false, false }) },

        //GPU RELATED Q's W/ ASSOCIATED HINT
        { 2, new(new string[] { "A. Random Access Memory", "B. E", "C. E" }, new bool[] { true, false, false }) },
        { 3, new(new string[] { "A. Random Access Memory", "B. E", "C. E" }, new bool[] { true, false, false }) },

        //CPU RELATED Q's W/ ASSOCIATED HINT
        { 4, new(new string[] { "A. Random Access Memory", "B. E", "C. E" }, new bool[] { true, false, false }) },
        { 5, new(new string[] { "A. Random Access Memory", "B. E", "C. E" }, new bool[] { true, false, false }) },
    };*/