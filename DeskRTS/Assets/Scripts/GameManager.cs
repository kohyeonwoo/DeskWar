using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public List<Unit> allUnit;

    private void Start()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    public void RegistUnit(Unit units)
    {
          allUnit.Add(units);
    }
}
