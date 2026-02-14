using UnityEngine;
using Unity.Netcode;

public class StealablePart : NetworkBehaviour
{
    [SerializeField] private StealPart stealPartManager;

    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<NetworkObject>().Despawn(true);
        stealPartManager.AddPoint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
