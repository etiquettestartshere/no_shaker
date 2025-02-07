using BepInEx;
using HarmonyLib;

[BepInPlugin("no_shaker", "No Screen Shake", "0.23.81")]
public class NoShaker : BaseUnityPlugin
{
  /*private void Awake()
  {
    Logger.LogInfo("NO SHAKER LOADED");
  }*/

  private void Start()
  {
    var harmony = new Harmony("no_shaker");
    harmony.PatchAll(typeof(RemoveShaking));
  }
}