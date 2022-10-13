using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_Plant : MonoBehaviour
{
    private int cost;           // Custo inicial para comprar
    private int type;           // Tipo de combustível necessário       1-carvão 2-petróleo 3-lixo 4-nuclear 5-híbrido 6-ecológica
    private int generate_Cost;  // Custo para gerar energia
    private int generation;     // Quantas casas são abastecidas
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void chooser(int id)
    {
        switch(id)
        {
            case 1:
                cost = id;
                type = 1;
                generate_Cost = 3;
                generation = 1;
            break;

            case 2:
                cost = id;
                type = 2;
                generate_Cost = 2;
                generation = 1;
            break;

            case 3:
                cost = id;
                type = 1;
                generate_Cost = 1;
                generation = 1;
            break;

            case 4:
                cost = id;
                type = 5;
                generate_Cost = 1;
                generation = 1;
            break;

            case 5:
                cost = id;
                type = 5;
                generate_Cost = 3;
                generation = 2;
            break;

            case 6:
                cost = id;
                type = 3;
                generate_Cost = 1;
                generation = 2;
            break;

            case 7:
                cost = id;
                type = 2;
                generate_Cost = 2;
                generation = 2;
            break;

            case 8:
                cost = id;
                type = 4;
                generate_Cost = 1;
                generation = 2;
            break;

            case 9:
                cost = id;
                type = 1;
                generate_Cost = 3;
                generation = 3;
            break;

            case 10:
                cost = id;
                type = 6;
                generate_Cost = 0;
                generation = 1;
            break;

            case 11:
                cost = id;
                type = 6;
                generate_Cost = 0;
                generation = 1;
            break;

            case 12:
                cost = id;
                type = 2;
                generate_Cost = 1;
                generation = 2;
            break;

            case 13:
                cost = id;
                type = 5;
                generate_Cost = 1;
                generation = 2;
            break;

            case 14:
                cost = id;
                type = 1;
                generate_Cost = 3;
                generation = 4;
            break;

            case 15:
                cost = id;
                type = 6;
                generate_Cost = 0;
                generation = 2;
            break;

            case 16:
                cost = id;
                type = 6;
                generate_Cost = 0;
                generation = 2;
            break;

            case 19:
                cost = id;
                type = 4;
                generate_Cost = 1;
                generation = 3;
            break;

            case 20:
                cost = id;
                type = 6;
                generate_Cost = 0;
                generation = 1;
            break;
        }

        
        
    }
}
