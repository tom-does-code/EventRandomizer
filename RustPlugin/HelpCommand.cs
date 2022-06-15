namespace Oxide.Plugins
{
    [Info("HelpCommand", "Tom", "0.0.1")]
    class HelpCommand : RustPlugin
    {
        [ChatCommand("help")]
        void help (BasePlayer player)
        {
            SendReply(player, "Welcome to Rustooze.net. This server is still being worked on and is no way near done, join the discord server for more information.");
        }

        [ConsoleCommand("ConsoleTest")]
        
        void consoletest(ConsoleSystem.Arg args)
        {
            Puts("Hello");
        }
    }
}