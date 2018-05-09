using Squalr.Engine.Memory;
using Squalr.Engine.Scripting;

public class GodMode : ModScript
{
    [Mod]
    public void OnEnable()
    {
        var moduleBase = Query.GetModuleAddress("dink.exe");
        var entry = moduleBase + 0x58995;
        var code = "nop";

        Memory.InjectCode(entry, code);
    }
}