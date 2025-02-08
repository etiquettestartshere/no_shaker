using HarmonyLib;
//using UnityEngine;

[HarmonyPatch]
public class RemoveShaking
{
  [HarmonyPrefix]
  [HarmonyPatch(typeof(Shaker), "ShakeCam")]
  private static bool Prefix()
  {
    //Debug.Log("SHAKE REMOVED");
    return false;
  }
}