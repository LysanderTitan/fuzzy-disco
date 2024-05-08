using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderDiStateMachine : MonoBehaviour
{
    public DefenderDiState defenderDiState;
    public float detectionRange = 6;
    public LayerMask enemyLayer;
    public DefenderMovement defenderMovement;
    public Blaster blaster;
    // Start is called before the first frame update
    void Start()
    {
        defenderDiState = DefenderDiState.Moveing;
        blaster.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, detectionRange, enemyLayer); 

        if (defenderDiState == DefenderDiState.Moveing)
        {
         if (hit.collider != null)
         {
            defenderDiState = DefenderDiState.Shooting;   
            blaster.enabled = true;
            defenderMovement.enabled = false;
         }
     }
        else if (defenderDiState == DefenderDiState.Shooting)
        {
            if (hit.collider == null) // No enemy detected
            {
                defenderDiState = DefenderDiState.Moveing;
                blaster.enabled = false;
                defenderMovement.enabled = true;
            }
        }
    }

    public enum DefenderDiState
    {
        Idle,
        Moveing,
        Shooting
    }
}