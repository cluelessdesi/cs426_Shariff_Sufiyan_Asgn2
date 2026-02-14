using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
public class BillboardWithFinalQ : MonoBehaviour
{
    
    public TextMeshPro FinalTestQuestionText;
    public int randomNum = 0;

    private List<string> hints = new List<string>(){

        "A GPU (Graphics Processing Unit) is a specialized processor designed to handle many calculations at the same time.",
        "More hints to come :p",
        "Just want functionality for now"
    };

    

    public string[] ListOfTestQuestions = new string[] {
        "What is the point of RAM?",
        "Which component is responsible for rendering images & videos in a computer?",
        "Which unit is commonoly used to measure the clock speed of a CPU?"
        };

    public Dictionary<int, string[]> ListOfTestQs = new Dictionary<int, string[]> {
        //FORMAT: {randomIntNum, new string[] {"Question", "Hint"}},
        
        //RAM RELATED Q's W/ ASSOCIATED HINT
        {0, new string[] {"What does 'RAM' stand for?", "RAM is Random Access Memory"}},
        {1, new string[] { "Upgrading which component would help with multi-tasking software?", "More RAM in a computer helps with better multitasking of software"}},


        //GPU RELATED Q's W/ ASSOCIATED HINT
        {2, new string[] {"Which component is responsible for rendering images & videos in a computer?", "The GPU helps with rendering of images & videos"}},
        {3, new string[] { "Which component is specifically designed to handle the complex mathematical calculations required for 3D graphics?", "The GPU helps for rendering polygons and textures"}},

        //CPU RELATED Q's W/ ASSOCIATED HINT
        {4, new string[] {"Which unit is commonly used to measure the clock speed of a CPU?", "Gigahertz (GHz) is the measurement of CPU clock speed"}},
        {5, new string[] { "What is the term for a CPU that contains multiple processing units?", "CPUs that can multi process contain 'Multi-core' processors"}},
    };
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FinalTestQuestionText.enabled = false;
        randomNum = Random.Range(0, ListOfTestQs.Count);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void EnableFinalTestQuestion()
    {
        FinalTestQuestionText.text = ListOfTestQs[0][0];
        FinalTestQuestionText.enabled = true;
    }

    public void YouWinText()
    {
        FinalTestQuestionText.text = "You got the answer correct!! Your team has won!!";
    }

    
}

