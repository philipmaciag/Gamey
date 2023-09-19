using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCS : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



class Player {

    int Cash = 10;

    int Power = 300;

    List<Pet> pets = new List<Pet>();

    public bool IsAdmin = false;

    public Player(bool isAdmin)
    {
        IsAdmin = isAdmin;
    }
}


class Pet
{
    private readonly int Bonus;

    public Pet(int Bonus)
    {
        this.Bonus = Bonus;
    }
}
