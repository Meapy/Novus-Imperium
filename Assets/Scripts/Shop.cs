﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject oneStoneMinerPurchase;
    public GameObject oneCopperMinerPurchase;
    public GameObject oneTinMinerPurchase;
    public GameObject oneIronMinerPurchase;
    public GameObject oneSilverMinerPurchase;
    public GameObject oneGoldMinerPurchase;

    public GameObject TotalStoneMinersDisplay;
    public GameObject TotalCopperMinersDisplay;
    public GameObject TotalTinMinersDisplay;
    public GameObject TotalIronMinersDisplay;
    public GameObject TotalSilverMinersDisplay;
    public GameObject TotalGoldMinersDisplay;

    public GameObject TextStoneMinerCost;
    public GameObject TextCopperMinerCost;
    public GameObject TextTinMinerCost;
    public GameObject TextIronMinerCost;
    public GameObject TextSilverMinerCost;
    public GameObject TextGoldMinerCost;


    public static double StoneMinerCost = 1000;
    public static double CopperMinerCost = 5000;
    public static double TinMinerCost = 10000;
    public static double IronMinerCost = 25000;
    public static double SilverMinerCost = 50000;
    public static double GoldMinerCost = 100000;

    public static int totalStoneMiners = 0;
    public static int totalCopperMiners = 0;
    public static int totalTinMiners = 0;
    public static int totalIronMiners = 0;
    public static int totalSilverMiners = 0;
    public static int totalGoldMiners = 0;

    // my tingz n' dat
    public GameObject OneEnhancedClickPurchase;
    public GameObject TotalEnhancedClickDisplay;
    public GameObject TextEnhancedClickCost;
    public static double EnhancedClickCost = 1000000;
    public static double TotalEnhancedClick = 0;

    void Start()
    {
        TotalStoneMinersDisplay.GetComponent<Text>().text = "Total Stone miners = " + totalStoneMiners;
        TotalCopperMinersDisplay.GetComponent<Text>().text = "Total Copper miners = " + totalCopperMiners;
        TotalTinMinersDisplay.GetComponent<Text>().text = "Total Tin miners = " + totalTinMiners;
        TotalIronMinersDisplay.GetComponent<Text>().text = "Total Iron miners = " + totalIronMiners;
        TotalSilverMinersDisplay.GetComponent<Text>().text = "Total Silver miners = " + totalSilverMiners;
        TotalGoldMinersDisplay.GetComponent<Text>().text = "Total Gold miners = " + totalGoldMiners;

        TextStoneMinerCost.GetComponent<Text>().text = "Stone Miner: " + StoneMinerCost;
        TextCopperMinerCost.GetComponent<Text>().text = "Copper Miner: " + CopperMinerCost;
        TextTinMinerCost.GetComponent<Text>().text = "Tin Miner: " + TinMinerCost;
        TextIronMinerCost.GetComponent<Text>().text = "Iron Miner: " + IronMinerCost;
        TextSilverMinerCost.GetComponent<Text>().text = "Silver Miner: " + SilverMinerCost;
        TextGoldMinerCost.GetComponent<Text>().text = "Gold Miner: " + GoldMinerCost;

        // niks shiz in tings bruv
        TotalEnhancedClickDisplay.GetComponent<Text>().text = "Total Enchanced Clicks = " + TotalEnhancedClick;
        TextEnhancedClickCost.GetComponent<Text>().text = "Enhanced Click: " + EnhancedClickCost;
    }


    // my tins ya get me fam
    // tis at top cuz me no want to scroll
    public void startOneEnhancedClickPurchase()
    { 
        if (VariablesToText.money >= EnhancedClickCost)
        {
            OneEnhancedClickPurchase.SetActive(true);
            VariablesToText.money += -EnhancedClickCost;
            VariablesToText.updatebox = "Enhanced Click bought for " + EnhancedClickCost;
            EnhancedClickCost += (EnhancedClickCost * 3);
            EnhancedClickCost = Math.Round(EnhancedClickCost, 2);
            TotalEnhancedClick = TotalEnhancedClick + 0.1;
            TotalEnhancedClickDisplay.GetComponent<Text>().text = "Enchanced Click Multiplier= " + TotalEnhancedClick;
        }
        else
        {
            VariablesToText.updatebox = "You do not have enough money to buy an enhanced click";
        }
        TextEnhancedClickCost.GetComponent<Text>().text = "Enhanced Click: " + EnhancedClickCost;
    }

    public void startOneStoneMinerPurchase()
    {
         if (VariablesToText.money >= StoneMinerCost)
         {

            oneStoneMinerPurchase.SetActive(true);
            VariablesToText.money += -StoneMinerCost;
            VariablesToText.updatebox = "Miner bought for " + StoneMinerCost;
            StoneMinerCost += (StoneMinerCost *0.1);
            StoneMinerCost = Math.Round(StoneMinerCost, 2);
            totalStoneMiners++;
            TotalStoneMinersDisplay.GetComponent<Text>().text = "Total stone miners = " + totalStoneMiners;

         }
         else
         {
             VariablesToText.updatebox = "You do not have enough money to buy a Stone Miner";
         }
         TextStoneMinerCost.GetComponent<Text>().text = "Stone Miner:" + StoneMinerCost;
        
    }

    public void StartOneCopperMinerPurchase()
    {
        if (VariablesToText.money >= CopperMinerCost)
        {

            oneCopperMinerPurchase.SetActive(true);
            VariablesToText.money += -CopperMinerCost;
            VariablesToText.updatebox = "Copper miner bought for " + CopperMinerCost;
            CopperMinerCost += (CopperMinerCost * 0.1);
            CopperMinerCost = Math.Round(CopperMinerCost, 2);
            totalCopperMiners++;
            TotalCopperMinersDisplay.GetComponent<Text>().text = "Total Copper miners = " + totalCopperMiners;

        }
        else
        {
            VariablesToText.updatebox = "You do not have enough money to buy a Copper Miner";
        }
        TextCopperMinerCost.GetComponent<Text>().text = "Copper Miner:" + CopperMinerCost;

    }
    public void StartOneTinMinerPurchase()
    {
        if (VariablesToText.money >= TinMinerCost)
        {

            oneTinMinerPurchase.SetActive(true);
            VariablesToText.money += -TinMinerCost;
            VariablesToText.updatebox = "Tine miner bought for " + TinMinerCost;
            TinMinerCost += (TinMinerCost * 0.1);
            TinMinerCost = Math.Round(TinMinerCost, 2);
            totalTinMiners++;
            TotalTinMinersDisplay.GetComponent<Text>().text = "Total Tin miners = " + totalTinMiners;

        }
        else
        {
            VariablesToText.updatebox = "You do not have enough money to buy a Tin Miner";
        }
        TextTinMinerCost.GetComponent<Text>().text = "Tin Miner:" + TinMinerCost;

    }

    public void StartOneIronMinerPurchase()
    {
        if (VariablesToText.money >= IronMinerCost)
        {
    
            oneIronMinerPurchase.SetActive(true);
            VariablesToText.money += -IronMinerCost;
            VariablesToText.updatebox = "Irone miner bought for " + IronMinerCost;
            IronMinerCost += (IronMinerCost * 0.1);
            IronMinerCost = Math.Round(IronMinerCost, 2);
            totalIronMiners++;
            TotalIronMinersDisplay.GetComponent<Text>().text = "Total Iron miners = " + totalIronMiners;
    
        }
        else
        {
            VariablesToText.updatebox = "You do not have enough money to buy a Iron Miner";
        }
        TextIronMinerCost.GetComponent<Text>().text = "Iron Miner:" + IronMinerCost;
    
    }

    public void StartOneSilverMinerPurchase()
    {
        if (VariablesToText.money >= SilverMinerCost)
        {

            oneSilverMinerPurchase.SetActive(true);
            VariablesToText.money += -SilverMinerCost;
            VariablesToText.updatebox = "Silvere miner bought for " + SilverMinerCost;
            SilverMinerCost += (SilverMinerCost * 0.1);
            SilverMinerCost = Math.Round(SilverMinerCost, 2);
            totalSilverMiners++;
            TotalSilverMinersDisplay.GetComponent<Text>().text = "Total Silver miners = " + totalSilverMiners;

        }
        else
        {
            VariablesToText.updatebox = "You do not have enough money to buy a Silver Miner";
        }
        TextSilverMinerCost.GetComponent<Text>().text = "Silver Miner:" + SilverMinerCost;

    }

    public void StartOneGoldMinerPurchase()
    {
        if (VariablesToText.money >= GoldMinerCost)
        {

            oneGoldMinerPurchase.SetActive(true);
            VariablesToText.money += -GoldMinerCost;
            VariablesToText.updatebox = "Golde miner bought for " + GoldMinerCost;
            GoldMinerCost += (GoldMinerCost * 0.1);
            GoldMinerCost = Math.Round(GoldMinerCost, 2);
            totalGoldMiners++;
            TotalGoldMinersDisplay.GetComponent<Text>().text = "Total Gold miners = " + totalGoldMiners;

        }
        else
        {
            VariablesToText.updatebox = "You do not have enough money to buy a Gold Miner";
        }
        TextGoldMinerCost.GetComponent<Text>().text = "Gold Miner:" + GoldMinerCost;

    }
}
