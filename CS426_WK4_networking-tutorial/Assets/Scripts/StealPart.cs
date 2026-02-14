using UnityEngine;
using TMPro;
using Unity.Netcode;

public class StealPart : NetworkBehaviour
{
    [SerializeField] private TMP_Text stolenText;
    [SerializeField] private int maxSteal = 3;

    private NetworkVariable<int> stolen = new NetworkVariable<int>(0);

    public RemainingItemsLeft RemainingItemsLeftScript;

    private void Awake()
    {
        stolenText = GetComponent<TMP_Text>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void Start()
    {
        RemainingItemsLeftScript = FindAnyObjectByType<RemainingItemsLeft>();
    }
    public override void OnNetworkSpawn()
    {
        UpdateUI(stolen.Value);

        stolen.OnValueChanged += OnStolenChanged;
    }

    private void OnStolenChanged(int oldValue, int newValue)
    {
        UpdateUI(newValue);
    }

    
    private void UpdateUI(int value)
    {
        if (value >= maxSteal)
            stolenText.text = $"{maxSteal}/{maxSteal} Head to Finish!";
        else
            stolenText.text = $"Parts Stolen: {value}/{maxSteal}";

    }
    public void AddPoint()
    {

        stolen.Value++;
        RemainingItemsLeftScript.UpdateItemsLeftCounter();
    }
    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
