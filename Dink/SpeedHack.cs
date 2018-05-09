namespace Dink
{
    class SpeedHack
    {
        [Mod]
        public void OnEnable()
        {
            var moduleBase = Memory.GetModuleAddress("dink.exe");
            Memory.SetKeyword("dink.exe", moduleBase);
            Memory.SetKeyword("speed", 4);

            var entry = moduleBase + 0x58F9B;
            var code = @"sub dword [esi+<dink.exe>+0x4485C8], <speed>";
            Memory.CreateCodeCave(entry, code);

            entry = moduleBase + 0x3B397;
            code = @"add dword [eax+<dink.exe>+0x4485C8], <speed>";
            Memory.CreateCodeCave(entry, code);

            entry = moduleBase + 0x3B3AC;
            code = @"sub dword [eax+<dink.exe>+0x4485C8], <speed>";
            Memory.CreateCodeCave(entry, code); entry = moduleBase + 0x5904B;

            code = @"sub dword [esi+<dink.exe>+0x4485D0], <speed>";
            Memory.CreateCodeCave(entry, code); entry = moduleBase + 0x3B3C6;

            code = @"add dword [eax+<dink.exe>+0x4485D0], <speed>";
            Memory.CreateCodeCave(entry, code);

            entry = moduleBase + 0x3B3DB;
            code = @"sub dword [eax+<dink.exe>+0x4485D0], <speed>";
            Memory.CreateCodeCave(entry, code);
        }
    }
}
