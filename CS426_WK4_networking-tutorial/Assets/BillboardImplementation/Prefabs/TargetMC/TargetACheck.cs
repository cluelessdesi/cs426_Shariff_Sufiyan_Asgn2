using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TargetACheck : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public TargetsWithAnswers TargetsWithAnswersScript;
    public BillboardWithFinalQ BillboardWithFinalQScript;
    public string CorrectnessValue = "";

    
    
    void Start()
    {

        TargetsWithAnswersScript = FindAnyObjectByType<TargetsWithAnswers>();
        BillboardWithFinalQScript = FindAnyObjectByType<BillboardWithFinalQ>();

        SetTargetACorrectnessValue();

        if(gameObject.name == "TargetA")
        {
            CorrectnessValue = "Y";
        } 
        else if(gameObject.name == "TargetB")
        {
            CorrectnessValue = "N";
        }
        else
        {
            CorrectnessValue = "N";
        }
    }

    // Update is called once per frame
    void Update()
    {
        //SetTargetACorrectnessValue();
    }

    public void SetTargetACorrectnessValue()
    {
        CorrectnessValue = "Y";
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Bullet"))
        {
            if (CorrectnessValue.Equals("Y"))
            {
                BillboardWithFinalQScript.YouWinText();
                Destroy(gameObject, 2f);
                return;
            }

            if(CorrectnessValue.Equals("N"))
            {
                if (gameObject.name == "TargetB")
                {
                    TargetsWithAnswersScript.AnswerBText.text = "Wrong answer! try again!";
                    Destroy(gameObject, 2f);
                }
                else
                {
                    TargetsWithAnswersScript.AnswerCText.text = "Wrong answer! try again!";
                    Destroy(gameObject, 2f);
                }
                
                
            }
        }
    }
}   

