using UnityEngine;
using UnityEngine.AI;

public class Pet : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent petAgent; 

    void Start()
    {
        petAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (player != null)
        {
            petAgent.SetDestination(player.position);
        }
    }
}