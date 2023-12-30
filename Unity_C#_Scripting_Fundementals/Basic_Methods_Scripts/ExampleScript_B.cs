using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript_B : MonoBehaviour
{
    private int enemyDistance = 6;
    private int enemyCount = 10; 
    private string[] enemies = new string[5];
    private int weaponId = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            //EnemySearch();
            //EnemyDestruction(); 
            //EnemyScan();
            //EnemyRoster(); 
            WeaponSearch(); 
        }
    }

    void EnemySearch()
    {
        for(int i = 0; i < 5; i++)
        {
            enemyDistance = Random.Range(1, 10); 

            if(enemyDistance >= 8)
            {
                print("Enemy is far away");
            }

            if (enemyDistance >= 4 && enemyDistance <= 7)
            {
                print("Enemy is at medium range");
            }

            if (enemyDistance < 4)
            {
                print("Enemy is very close");
            }
        }
    }

    void EnemyDestruction()
    {
        while(enemyCount > 0)
        {
            print("There is an enemy to be destroyed");
            enemyCount--; //without this condition, there would be an infinite loop
        }
    }

    void EnemyScan()
    {
        bool isAlive = false;

        do
        {
            print("Scanning For Enemies");
        }
        while (isAlive == true); 
    }

    void EnemyRoster()
    {
        enemies[0] = "Orc";
        enemies[1] = "Dragon";
        enemies[2] = "Orc";
        enemies[3] = "Dragon";
        enemies[4] = "Dragon";

        foreach(string enemy in enemies) 
        {
            print(enemy); 
        }
    }

    void WeaponSearch()
    {
        weaponId = Random.Range(0, 8);

        switch (weaponId)
        {
            case 1:
                print("You found a sword");
                break;
            case 2:
                print("You found an ax");
                break;
            case 3:
                print("You found a dagger");
                break;
            case 4:
                print("You found a bow");
                break;
            default:
                print("You found nothing");
                break;


        }

    }
}
