using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Character> listCharacter= new List<Character>();
        Warrior warrior = new Warrior("Artoria", 100);
        Mage mage = new Mage("Merlin", 60);
        Archer archer = new Archer("Emiya", 80);
        listCharacter.Add(warrior);
        listCharacter.Add(mage);
        listCharacter.Add(archer);
        Character dummy = new Character("Dummy", 100);
        foreach (Character character in listCharacter) 
        {
            character.Attack(dummy);
            Debug.Log($"{dummy.GetName()} have {dummy.GetHP()} HP");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
