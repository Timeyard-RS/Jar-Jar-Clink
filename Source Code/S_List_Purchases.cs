using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class S_List_Purchases {

    public string Desc;
    public int HammerAward;
    public int IceCubeAward;
    public int CurrencyAward;
    public int CurrencyCost;
    public int MTCost;

    public bool Repeatable;
    public bool Purchased;

    public string PurchaseType; //Advert, Micro, Currency

    public GameObject Button;
    public GameObject Unlockable;

    public Sprite Icon;

}
