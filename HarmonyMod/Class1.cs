using System;
using System.Xml;
using UnityEngine;
using HarmonyLib;
using HarmonyMod;
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Local

[HarmonyPatch(typeof(FocusCtrl))]
[HarmonyPatch("Start")]
class Patch
{
    private static void Postfix()
    {
        LogHelper.GremyLogger("Test log!! aaaa");
    }
}