using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public List<Unit> allUnit;

    public List<SpecialUnit> allSpecialUnit;

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

     public void RegistSpecialUnit(SpecialUnit specialUnits)
    {
         allSpecialUnit.Add(specialUnits);
    }

    public void ChooseUnit(int chooseIndex)
    {
       allUnit[chooseIndex].bChoose = true;
    }

     public void ChooseSpecialUnit(int chooseSpecialUnitIndex)
    {
       allSpecialUnit[chooseSpecialUnitIndex].bChoose = true;
    }

}
