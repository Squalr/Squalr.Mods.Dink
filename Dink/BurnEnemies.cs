using Squalr.Engine.Scripting;

public class BurnEnemies : ModScript
{
    [Mod]
    public void OnEnable()
    {
        var moduleBase = Memory.GetModuleAddress("dink.exe");
        Memory.SetKeyword("dink.exe", moduleBase);
        Memory.SetKeyword("damage", 1);

        // Set display damage to 0
        var entry = moduleBase + 0x54686; var code = "nop";
        Memory.InjectCode(entry, code);

        // Set actual damage
        entry = moduleBase + 0x546B8; code = @"sub dword [esi+<dink.exe>+0x4487FC], <damage>";
        Memory.CreateCodeCave(entry, code);
    }
}