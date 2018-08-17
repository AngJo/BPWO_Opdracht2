using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class ClickToMove : MonoBehaviour {

    public NavMeshAgent navMeshAgent;
    private Transform targetedEnemy;

    public float inputHoldDelay = 0.5f;
    public float speedDampTime = 0.1f;
    public float slowingSpeed = 0.175f;
    public float turnSmoothing = 15f;
    private WaitForSeconds inputHoldWait;
    private Vector3 destinationPosition;
    private const float stopDistanceProportion = 0.1f;
    public float turnSpeedThreshold = 0.5f;

    private readonly int speed = 5;


    private void Start()
    {
        navMeshAgent.updateRotation = false;
        inputHoldWait = new WaitForSeconds(inputHoldDelay);
        destinationPosition = transform.position;
    }

    private void Update()
    {
        if (navMeshAgent.pathPending)
        {
            return;
        }

        float speed = navMeshAgent.desiredVelocity.magnitude;

        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance*stopDistanceProportion)
        {
            Stopping(out speed);
        }
        else if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            Slowing(out speed, navMeshAgent.remainingDistance);
        }
        else if (speed > turnSpeedThreshold )
        {
            Moving();
        }


    }

    private void Stopping(out float speed)
    {
        navMeshAgent.Stop();
        transform.position = destinationPosition;
        speed = 0f; 
    }

    private void Slowing(out float speed, float distanceToDestination)
    {
        navMeshAgent.Stop();
        transform.position = Vector3.MoveTowards(transform.position, destinationPosition, slowingSpeed*Time.deltaTime);

        float proportionalDistance = 1f - distanceToDestination / navMeshAgent.stoppingDistance ;
        speed = Mathf.Lerp(slowingSpeed, 0f, proportionalDistance);
    }

    private void Moving()
    {
        Quaternion targetRotation = Quaternion.LookRotation(navMeshAgent.desiredVelocity);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, turnSmoothing*Time.deltaTime);
    }

    public void OnGroundClick(BaseEventData data)
    {
        PointerEventData pData = (PointerEventData)data;
        NavMeshHit hit;

    }

}
