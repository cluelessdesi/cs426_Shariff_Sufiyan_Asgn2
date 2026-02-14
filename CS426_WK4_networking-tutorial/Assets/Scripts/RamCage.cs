using UnityEngine;
using Unity.Netcode;

public class RamCage : NetworkBehaviour
{
    // // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
        
    // }
    [SerializeField] private RamTarget target;
    // Update is called once per frame
    void Update()
    {
        if(target.TargetsLeft() == 0)
        {
            GetComponent<NetworkObject>().Despawn(true);
        }
    }

}
