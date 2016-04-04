namespace ArkMonitor.Service
{
    public class ServerSettings
    {
        /// <summary>
        ///     Enables the output of cheat commands that admins used (will be shown in chat)
        /// </summary>
        public bool AdminLogging { get; set; }

        /// <summary>
        ///     If set to True, allows building in caves when PvE mode is also enabled.
        /// </summary>
        public bool AllowCaveBuildingPvE { get; set; }

        /// <summary>
        ///     Enables 3rd Person view
        /// </summary>
        public bool allowThirdPersonPlayer { get; set; }

        /// <summary>
        ///     Players will always get notified if someone joins the server
        /// </summary>
        public bool alwaysNotifyPlayerJoined { get; set; }

        /// <summary>
        ///     Players will always get notified if someone leaves the server
        /// </summary>
        public bool alwaysNotifyPlayerLeft { get; set; }

        /// <summary>
        ///     Server Option to allow Auto-Destroying Structures after sufficient "no nearby Tribe" time has passed (defined as a
        ///     multiplier of the Allow Claim period)
        /// </summary>
        public float AutoDestroyOldStructuresMultiplier { get; set; }

        /// <summary>
        ///     Allows flyers to pick up players and dinos
        /// </summary>
        public bool bAllowFlyerCarryPvE { get; set; }

        /// <summary>
        ///     Uses the global banlist of ARK to disallow players' access who have been identified as cheaters
        /// </summary>
        public string Banlist { get; set; }

        /// <summary>
        ///     SOTF setting: Defines the length of the countdown before match begins
        /// </summary>
        public int BattleAutoStartGameInterval { get; set; }

        /// <summary>
        ///     SOTF setting: Defines how many tribes must have been created before the countdown for game start begins
        /// </summary>
        public int BattleNumOfTribestoStartGame { get; set; }

        /// <summary>
        ///     SOTF setting: Defines the time before sudden death starts
        /// </summary>
        public int BattleSuddenDeathInterval { get; set; }

        /// <summary>
        ///     Disable the gradual (7 days) decay of player structures
        /// </summary>
        public bool bDisableStructureDecayPvE { get; set; }

        /// <summary>
        ///     Server Option to allow Locking All Item Containers
        /// </summary>
        public bool bForceAllStructureLocking { get; set; }

        /// <summary>
        ///     Wild dinos or dinos without a rider can take damage from defense structures like spikewalls if this setting is
        ///     activated
        /// </summary>
        public bool bPassiveDefensesDamageRiderlessDinos { get; set; }

        /// <summary>
        ///     Deactivates the VSync setting (can reduce GPU problems in some cases)
        /// </summary>
        public bool bUseVSync { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for the passage of time in the ARK, controlling how often day changes to night and
        ///     night changes to day. The default value 1 provides the same cycle speed as the singleplayer experience (and the
        ///     official public servers). Values lower than 1 slow down the cycle; higher values accelerate it. Base time when
        ///     value is 1 appears to be 1 minute real time equals approx. 28 minutes game time. Thus, for an approximate 24 hour
        ///     day/night cycle in game, use .035 for the value.
        /// </summary>
        public float DayCycleSpeedScale { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for the passage of time in the ARK during the day. This value determines the length of
        ///     each day, relative to the length of each night (as specified by NightTimeSpeedScale. Lowering this value increases
        ///     the length of each day.
        /// </summary>
        public float DayTimeSpeedScale { get; set; }

        /// <summary>
        ///     Specifies the difficulty level.
        /// </summary>
        public float DifficultyOffset { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for dinosaurs' food consumption. Higher values increase food consumption (dinosaurs
        ///     get hungry faster).
        /// </summary>
        public float DinoCharacterFoodDrainMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for dinosaurs' health recovery. Higher values increase the recovery rate (dinosaurs
        ///     heal faster).
        /// </summary>
        public float DinoCharacterHealthRecoveryMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for dinosaurs' stamina consumption. Higher values increase stamina consumption
        ///     (dinosaurs get tired faster).
        /// </summary>
        public float DinoCharacterStaminaDrainMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for dinosaur spawns. Higher values increase the number of dinosaurs spawned throughout
        ///     the ARK.
        /// </summary>
        public float DinoCountMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for the damage dinosaurs deal with their attacks. The default value 1 provides normal
        ///     damage. Higher values increase damage. Lower values decrease it.
        /// </summary>
        public float DinoDamageMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for the resistance to damage dinosaurs receive when attacked. The default value 1
        ///     provides normal damage. Higher values decrease resistance, increasing damage per attack. Lower values increase it,
        ///     reducing damage per attack. A value of 0.5 results in a dino taking half damage while a value of 2.0 would result
        ///     in a dino taking double normal damage.
        /// </summary>
        public float DinoResistanceMultiplier { get; set; }

        /// <summary>
        ///     Deactivates the unclaiming functions for dinosaurs on PVE servers
        /// </summary>
        public bool DisableDinoDecayPvE { get; set; }

        /// <summary>
        ///     Allows or disallows usage of gamma on PVE servers
        /// </summary>
        public bool EnablePVEGamma { get; set; }

        /// <summary>
        ///     Allows or disallows usage of gamma on PVP servers
        /// </summary>
        public bool EnablePVPGamma { get; set; }

        /// <summary>
        ///     Voice chat turns global
        /// </summary>
        public bool globalVoiceChat { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for yields from all harvesting activities (chopping down trees, picking berries,
        ///     carving carcasses, mining rocks, etc.). Higher values increase the amount of materials harvested with each strike.
        /// </summary>
        public float HarvestAmountMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for the "health" of items that can be harvested (trees, rocks, carcasses, etc.).
        ///     Higher values increase the amount of damage (i.e. "number of strikes") such objects can withstand before being
        ///     destroyed, which results in higher overall harvest yields.
        /// </summary>
        public float HarvestHealthMultiplier { get; set; }

        /// <summary>
        ///     Time period until an idling player will be kicked from server
        /// </summary>
        public int KickIdlePlayersPeriod { get; set; }

        /// <summary>
        ///     SOTF setting: Defines the maximum player limit per tribe
        /// </summary>
        public int MaxNumbersofPlayersInTribe { get; set; }

        /// <summary>
        ///     Defines the maximum number of structures on top of the saddle platform
        /// </summary>
        public int MaxPlatformSaddleStructureLimit { get; set; }

        /// <summary>
        ///     Specifies the maximum number of structures that can be constructed within a certain (currently hard-coded) range.
        /// </summary>
        public int MaxStructuresInRange { get; set; }

        /// <summary>
        ///     Defines the maximum amount of tamed dinos on the island
        /// </summary>
        public int MaxTamedDinos { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for the passage of time in the ARK during night time. This value determines the length
        ///     of each night, relative to the length of each day (as specified by DayTimeSpeedScale. Lowering this value increases
        ///     the length of each night.
        /// </summary>
        public float NightTimeSpeedScale { get; set; }

        /// <summary>
        ///     Disables downloading characters from other servers
        /// </summary>
        public bool noTributeDownloads { get; set; }

        /// <summary>
        ///     Defines the multiplicator for structures on saddle plattforms (Please use with caution - too high values may lead
        ///     to a massive lack of performance)
        /// </summary>
        public float PerPlatformMaxStructuresMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for player characters' food consumption. Higher values increase food consumption
        ///     (player characters get hungry faster).
        /// </summary>
        public float PlayerCharacterFoodDrainMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for player characters' health recovery. Higher values increase the recovery rate
        ///     (player characters heal faster).
        /// </summary>
        public float PlayerCharacterHealthRecoveryMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for player characters' stamina consumption. Higher values increase stamina consumption
        ///     (player characters get tired faster).
        /// </summary>
        public float PlayerCharacterStaminaDrainMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for player characters' water consumption. Higher values increase water consumption
        ///     (player characters get thirsty faster).
        /// </summary>
        public float PlayerCharacterWaterDrainMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for the damage players deal with their attacks. The default value 1 provides normal
        ///     damage. Higher values increase damage. Lower values decrease it.
        /// </summary>
        public float PlayerDamageMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for the resistance to damage players receive when attacked. The default value 1
        ///     provides normal damage. Higher values decrease resistance, increasing damage per attack. Lower values increase it,
        ///     reducing damage per attack. A value of 0.5 results in a player taking half damage while a value of 2.0 would result
        ///     in taking double normal damage.
        /// </summary>
        public float PlayerResistanceMultiplier { get; set; }

        /// <summary>
        ///     Prevents the download of dinos
        /// </summary>
        public bool PreventDownloadDinos { get; set; }

        /// <summary>
        ///     Prevents the download of items
        /// </summary>
        public bool PreventDownloadItems { get; set; }

        /// <summary>
        ///     Prevents the download of survivors
        /// </summary>
        public bool PreventDownloadSurvivors { get; set; }

        /// <summary>
        ///     Only players near each other can see their chat messages
        /// </summary>
        public bool proximityChat { get; set; }

        /// <summary>
        ///     Multiplier value for the unclaiming speed of dinosaurs
        /// </summary>
        public float PvEDinoDecayPeriodMultiplier { get; set; }

        /// <summary>
        ///     Specifies the time required for player structures to decay in PvE mode. The specific effect(s) of this option and
        ///     its range of valid values are unknown as of this writing.
        /// </summary>
        public float PvEStructureDecayDestructionPeriod { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for the decay rate of player structures in PvE mode. The specific effect(s) of this
        ///     option and its range of valid values are unknown as of this writing.
        /// </summary>
        public float PvEStructureDecayPeriodMultiplier { get; set; }

        /// <summary>
        ///     Activates (true) oder deactivates (false) the structure decay on PVP servers
        /// </summary>
        public bool PvPStructureDecay { get; set; }

        /// <summary>
        ///     Defines the distance where there are no resources respawning when being close to a player
        /// </summary>
        public float ResourceNoReplenishRadiusPlayers { get; set; }

        /// <summary>
        ///     Defines the distance where there are no resources respawning when being close to a structure
        /// </summary>
        public float ResourceNoReplenishRadiusStructures { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for the respawn rate for resource nodes (trees, rocks, bushes, etc.). Lower values
        ///     cause nodes to respawn more frequently.
        /// </summary>
        public float ResourcesRespawnPeriodMultiplier { get; set; }

        /// <summary>
        ///     If specified, players must provide this password (via the in-game console) to gain access to administrator commands
        ///     on the server.
        /// </summary>
        public string ServerAdminPassword { get; set; }

        /// <summary>
        ///     Shows crosshair
        /// </summary>
        public bool ServerCrosshair { get; set; }

        /// <summary>
        ///     HUD always disabled
        /// </summary>
        public bool serverForceNoHud { get; set; }

        /// <summary>
        ///     Enables hardcore mode (player characters revert to level 1 upon death)
        /// </summary>
        public bool serverHardcore { get; set; }

        /// <summary>
        ///     If specified, players must provide this password to join the server.
        /// </summary>
        public string ServerPassword { get; set; }

        /// <summary>
        ///     Disables PvP, enables PvE
        /// </summary>
        public bool serverPVE { get; set; }

        /// <summary>
        ///     Show each player their own precise position when they view their map
        /// </summary>
        public bool ShowMapPlayerLocation { get; set; }

        /// <summary>
        ///     To use non-admin spectator, the server must specify a spectator password. Then any client can use these console
        ///     commands: requestspectator and stopspectating. See patch 191.0 for more information and hotkeys.
        /// </summary>
        public string SpectatorPassword { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for the damage structures deal with their attacks (i.e. spiked walls). The default
        ///     value 1 provides normal damage. Higher values increase damage. Lower values decrease it.
        /// </summary>
        public float StructureDamageMultiplier { get; set; }

        /// <summary>
        ///     Defines the cooldown time when a previously damaged structure can be repaired again. (0 allows the structure to be
        ///     always repaired)
        /// </summary>
        public int StructureDamageRepairCooldown { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for the resistance to damage structures receive when attacked. The default value 1
        ///     provides normal damage. Higher values decrease resistance, increasing damage per attack. Lower values increase it,
        ///     reducing damage per attack. A value of 0.5 results in a structure taking half damage while a value of 2.0 would
        ///     result in a structure taking double normal damage.
        /// </summary>
        public float StructureResistanceMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for tamed dinosaurs damage. A value of 2.0 doubles the inital amount, a value of 0.5
        ///     halfes it.
        /// </summary>
        public float TamedDinoDamageMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for dinosaurs fortitude. A value of 2.0 doubles the inital amount, a value of 0.5
        ///     halfes it.
        /// </summary>
        public float TamedDinoResistanceMultiplier { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for dinosaur taming speed. A value of 2.0 doubles the inital amount, a value of 0.5
        ///     halfes it.
        /// </summary>
        public float TamingSpeedMultiplier { get; set; }

        /// <summary>
        ///     SOTF setting: Defines the time period for the force field to collapse
        /// </summary>
        public int TimeToCollapseROD { get; set; }

        /// <summary>
        ///     Specifies the scaling factor for the experience received by players, tribes and dinosaurs for various actions. The
        ///     default value 1 provides the same amounts of experience as in the singleplayer experience (and official public
        ///     servers). Higher values increase XP amounts awarded for various actions; lower values decrease it.
        /// </summary>
        public float XPMultiplier { get; set; }
    }
}