using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Unit : MonoBehaviour
{

    private NavMeshAgent agent;

    private void Start()
    {
        GameManager.Instance.RegistUnit(this);

        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
        
            Touch touch = Input.GetTouch(0);
        
            if(touch.phase == TouchPhase.Began)
            {

                Ray ray = Camera.main.ScreenPointToRay(touch.position);

                RaycastHit hit;

                if(Physics.Raycast(ray, out hit))
                {
                    agent.destination = hit.point;  
                }

            }

        }
    }

}
