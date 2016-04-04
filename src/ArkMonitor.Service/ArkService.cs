using System;
using System.IO;
using System.Reflection;

namespace ArkMonitor.Service
{
    public class ArkService : IArkService
    {
        private readonly string _serverPath;

        public ArkService(string serverPath)
        {
            if (!Directory.Exists(serverPath))
                throw new ArgumentException("Path does not exist!", nameof(serverPath));

            _serverPath = serverPath;
        }

        public ArkServerConfiguration GetArkServerConfiguration()
        {
            return LoadConfiguration();
        }

        private ArkServerConfiguration LoadConfiguration()
        {
            return new ArkServerConfiguration
            {
                GameIni = LoadGameIni(),
                GameUserSettings = LoadGameUserSettingsIni()
            };
        }

        private GameUserSettingsIni LoadGameUserSettingsIni()
        {
            var file = Path.Combine(_serverPath, GameUserSettingsIni.Path);
            if (!File.Exists(file))
                throw new Exception("Unable to locate settings file");
            //throw new FileNotFoundException("Unable to locate settings file", "GameUserSettings.ini");

            var iniFile = new IniFile(file);

            return new GameUserSettingsIni
            {
                ServerSettings = (ServerSettings) LoadFromFile(typeof (ServerSettings), iniFile, "ServerSettings"),
                MessageOfTheDay = (MessageOfTheDay) LoadFromFile(typeof (MessageOfTheDay), iniFile, "MessageOfTheDay"),
                EngineGameSession =
                    (EngineGameSession) LoadFromFile(typeof (EngineGameSession), iniFile, "/script/engine.gamesession"),
                SessionSettings = (SessionSettings) LoadFromFile(typeof (SessionSettings), iniFile, "SessionSettings")
            };
        }

        private GameIni LoadGameIni()
        {
            var file = Path.Combine(_serverPath, GameIni.Path);
            if (!File.Exists(file))
                throw new Exception("Unable to locate settings file");
            //throw new FileNotFoundException("Unable to locate settings file", "GameUserSettings.ini");

            var iniFile = new IniFile(file);

            return (GameIni) LoadFromFile(typeof (GameIni), iniFile, "/script/shootergame.shootergamemode");
        }

        private static object LoadFromFile(Type type, IniFile iniFile, string section = null)
        {
            var obj = Activator.CreateInstance(type);

            foreach (var property in type.GetProperties())
            {
                var strVal = iniFile.Read(property.Name, section);

                if (string.IsNullOrEmpty(strVal)) continue;

                if (property.PropertyType == typeof(string))
                    property.SetValue(obj, strVal);

                else if (property.PropertyType == typeof(int))
                    property.SetValue(obj, int.Parse(strVal));

                else if (property.PropertyType == typeof(float))
                    property.SetValue(obj, float.Parse(strVal));

                else if (property.PropertyType == typeof (bool))
                {
                    bool val;
                    if (!bool.TryParse(strVal, out val))
                        val = (int.Parse(strVal) != 0);

                    property.SetValue(obj, val);
                }
            }

            return obj;
        }
    }
}