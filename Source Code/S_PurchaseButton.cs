using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_PurchaseButton : MonoBehaviour {

    public enum PurchaseType { RemoveAds, Gold50 };
    public PurchaseType purchaseType;

    public Text PriceText;

    public void Start()
    {
        StartCoroutine(LoadPriceRoutine());
    }

    public void ClickPurchaseButton ()
    {
        switch (purchaseType)
        {
            case PurchaseType.RemoveAds:
                IAPManager.instance.BuyRemoveAds();
                break;
            case PurchaseType.Gold50:
                IAPManager.instance.BuyGold50();
                break;
        }
    }

    private IEnumerator LoadPriceRoutine()
    {
        while(!IAPManager.instance.IsInitialized())
        {
            yield return null;
        }

        string loadedPrice = "";

        switch (purchaseType)
        {
            case PurchaseType.RemoveAds:
                loadedPrice = IAPManager.instance.GetProducePriceFromStore(IAPManager.instance.RemoveAds);
                
                break;
            case PurchaseType.Gold50:
               loadedPrice  = IAPManager.instance.GetProducePriceFromStore(IAPManager.instance.Gold50);
                break;
        }

        PriceText.text = loadedPrice;
    }
}
