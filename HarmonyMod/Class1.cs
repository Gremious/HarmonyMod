using System;
using System.Collections.Generic;
using HarmonyLib;
using HarmonyMod;
using UnityEngine;
using Object = UnityEngine.Object;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedVariable

[HarmonyPatch(typeof(FocusCtrl), "_AnimateCollectionC")]
internal class PatchFocusCtrl
{
    public static bool flag = true;
    private static void Prefix(FocusCtrl __instance, List<Brand> ___brandTypes)
    {
        LogHelper.GremyLogger("Init FocusCtrl Patch");
        
        var brandAmount = ___brandTypes.Capacity;
        if (flag)
        {
            BrandListCard brandListCard = Object.Instantiate(__instance.brandListCardPrefab);
        brandListCard.transform.SetParent( __instance.focusGrid);
        brandListCard.foCtrl = __instance;
        brandListCard.displayButton = false;
        brandListCard.parentList = __instance.brandListCards;
        brandListCard.SetBrand((Brand) brandAmount++);
        __instance.brandListCards.Add(brandListCard);
        flag = false;
        }

    }
}
