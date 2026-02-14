using UnityEngine;
using TMPro;
public class RemainingItemsLeft : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int itemsLeftCounter = 3;
    public TextMeshPro ItemsReaminingLeftText;
    public BillboardWithFinalQ BillBoardWithFinalQScript;

    public StealPart StealPartScript;
    void Start()
    {
        BillBoardWithFinalQScript = FindAnyObjectByType<BillboardWithFinalQ>();
        //itemsLeftCounter = 1; //TESTING
        //UpdateItemsLeftCounter();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            itemsLeftCounter--;
            ItemsReaminingLeftText.text = itemsLeftCounter + "/3 items left";

        }

        if(itemsLeftCounter == 0)
        {
            ItemsReaminingLeftText.enabled = false;
            BillBoardWithFinalQScript.EnableFinalTestQuestion();


        }
    }

    public void UpdateItemsLeftCounter()
    {
        itemsLeftCounter--;
        ItemsReaminingLeftText.text = itemsLeftCounter + "/3 items remaining";

        if (itemsLeftCounter == 0)
        {
            ItemsReaminingLeftText.enabled = false;
            BillBoardWithFinalQScript.EnableFinalTestQuestion();
        }
    }
}
