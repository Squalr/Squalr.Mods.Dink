using Squalr.Engine.Scripting;

public class NoClip : ModScript
{
    [Mod]
    public void OnEnable()
    {
        var moduleBase = Memory.GetModuleAddress("dink.exe");
        Memory.SetKeyword("dink.exe", moduleBase);
        var code = "nop";
        var entry = moduleBase + 0x594DA;
        Memory.InjectCode(entry, code);
        entry = moduleBase + 0x5964C;
        Memory.InjectCode(entry, code);
        entry = moduleBase + 0x59716;
        Memory.InjectCode(entry, code);
        entry = moduleBase + 0x59593;
        Memory.InjectCode(entry, code);
        entry = moduleBase + 0x5968C;
        Memory.InjectCode(entry, code);
        entry = moduleBase + 0x5951A;
        Memory.InjectCode(entry, code);
        entry = moduleBase + 0x595D3;
        Memory.InjectCode(entry, code);
        entry = moduleBase + 0x59710;
        Memory.InjectCode(entry, code);
        entry = moduleBase + 0x3B28B;
        Memory.InjectCode(entry, code);
        entry = moduleBase + 0x3B297;
        Memory.InjectCode(entry, code);
    }
}