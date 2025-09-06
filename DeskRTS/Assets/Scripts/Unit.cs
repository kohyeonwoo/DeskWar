using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Unit : MonoBehaviour
{

    private NavMeshAgent agent;

    private Animator animator;

    public GameObject chooseUI;

    public bool bChoose;

  //  private bool bMove;

    private void Start()
    {
        GameManager.Instance.RegistUnit(this);

        agent = GetComponent<NavMeshAgent>();

        animator = GetComponent<Animator>();

        chooseUI.SetActive(false);

     //   bChoose = false;
    }

    private void Update()
    {

        if(bChoose)
        {
            chooseUI.SetActive(true);

            if (Input.touchCount > 0)
            {

                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {

                    Ray ray = Camera.main.ScreenPointToRay(touch.position);

                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit))
                    {
                        agent.destination = hit.point;

                        animator.SetBool("bMove", true);

                       // bMove = true;
                    }

                }

            }
        }
     
    }

}
