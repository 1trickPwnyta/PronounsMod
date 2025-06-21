namespace PronounsMod
{
    public static class Debug
    {
        public static void Log(object message)
        {
#if DEBUG
            Verse.Log.Message($"[{PronounsModMod.PACKAGE_NAME}] {message}");
#endif
        }
    }
}
