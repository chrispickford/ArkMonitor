namespace ArkMonitor.Service
{
    public class GameUserSettingsIni
    {
        public const string Path = "ShooterGame\\Saved\\Config\\WindowsServer\\GameUserSettings.ini";

        public ServerSettings ServerSettings { get; set; }

        public EngineGameSession EngineGameSession { get; set; }

        public SessionSettings SessionSettings { get; set; }

        public MessageOfTheDay MessageOfTheDay { get; set; }
    }
}