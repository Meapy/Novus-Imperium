﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;



public class MainClickBehaviour : MonoBehaviour
{
    public static int minrandom = 1;
    public static int maxrandom = 10;


    public void Clicker()
    { 
        var Random = new System.Random();
        int oreCheck = 0;
        long count = 0;

        oreCheck = Random.Next(minrandom, 100);

        switch (oreCheck)
        {

            case 1:
                count = Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.stone = VariablesToText.stone + count;
                VariablesToText.updatebox = "Bonus Stone +" + count;
                break;
            case 5:
                count = Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.copper = VariablesToText.copper + Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.updatebox = "Copper +" + count;
                break;
            case 9:
                count = Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.tin = VariablesToText.tin + Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.updatebox = "Tin +" + count;
                break;
            case 11:
                count = Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.iron = VariablesToText.iron + Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.updatebox = "Iron +" + count;
                break;
            case 25:
                count = Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.silver = VariablesToText.silver + Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.updatebox = "Silver +" + count;
                break;
            case 58:
                count = Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.gold = VariablesToText.gold + Random.Next(minrandom, maxrandom) + minrandom;
                VariablesToText.updatebox = "Gold +" + count;
                break;
            default:
                VariablesToText.stone += minrandom;
                count = minrandom;
                VariablesToText.updatebox = "Stone +" + count;
                break;
        }
            
         

    }

}
