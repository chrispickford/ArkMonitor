namespace ArkMonitor.Service
{
    public class GameIni
    {
        public const string Path = "ShooterGame\\Saved\\Config\\WindowsServer\\Game.ini";

        /// <summary>
        /// Higher number decreases (by percentage) the speed that baby dinos eat their food
        /// </summary>
        public float BabyFoodConsumptionSpeedMultiplier { get; set; }

        /// <summary>
        /// Higher number decreases (by percentage) time needed for baby dino to mature 
        /// </summary>
        public float BabyMatureSpeedMultiplier { get; set; }

        /// <summary>
        /// Allow switching from PvE to PvP mode at pre-specified in-game times OR a pre-specified real-world (server-side) times
        /// </summary>
        public bool bAutoPvETimer { get; set; }

        /// <summary>
        /// </summary>
        public bool bAutoPvEUseSystemTime { get; set; }

        /// <summary>
        /// </summary>
        public int AutoPvEStartTimeSeconds { get; set; }

        /// <summary>
        /// </summary>
        public int AutoPvEStopTimeSeconds { get; set; }

        /// <summary>
        /// True prevent spawning of Loot crates (artifact creates will still spawn) 
        /// </summary>
        public bool bDisableLootCrates { get; set; }

        /// <summary>
        /// PvP servers have an optional +1 minute additonal respawn (<value3>) that doubles (<value2>) each time if you are killed by a team within 5 minutes (<value1>) of your previous death to that team (timer indicated on Spawn UI). Is enabled in pvp by default, and on all the official pvp servers. Helps prevent PvP ammo-wasting of auto turrets by repeatedly throwing sacrificial players at them.
        /// </summary>
        public bool bIncreasePvPRespawnInterval { get; set; }

        /// <summary>
        /// </summary>
        public bool IncreasePvPRespawnIntervalCheckPeriod { get; set; }

        /// <summary>
        /// </summary>
        public float IncreasePvPRespawnIntervalMultiplier { get; set; }

        /// <summary>
        /// </summary>
        public float IncreasePvPRespawnIntervalBaseAmount { get; set; }

        /// <summary>
        /// True allow spike walls to damage wild/riderless Dinos 
        /// </summary>
        public bool bPassiveDefensesDamageRiderlessDinos { get; set; }

        /// <summary>
        /// False disables capability for Tribes to officially declare war on each other for mutually-agreed-upon period of time
        /// </summary>
        public bool bPvEAllowTribeWar { get; set; }

        /// <summary>
        /// True allows cancellation of an agreed-upon war before it has actually started
        /// </summary>
        public bool bPvEAllowTribeWarCancel { get; set; }

        /// <summary>
        /// Prevent-Friendly-Fire (among tribesmates/tribesdinos/tribesstructures) option for PvE servers
        /// </summary>
        public bool bPvEDisableFriendlyFire { get; set; }

        /// <summary>
        /// Higher number decrease (by percentage) speed of crop decay in plots 
        /// </summary>
        public float CropDecaySpeedMultiplier { get; set; }

        /// <summary>
        /// Higher number increases (by percentage) speed of crop growth 
        /// </summary>
        public float CropGrowthSpeedMultiplier { get; set; }

        /// <summary>
        /// Higher number increases (by percentage) the effectiveness of a custom recipe 
        /// </summary>
        public float CustomRecipeEffectivenessMultiplier { get; set; }

        /// <summary>
        /// Higher number increases (by percentage) the effect of the players crafting speed level that is used as a base for the formula in creating a custom recipe
        /// </summary>
        public float CustomRecipeSkillMultiplier { get; set; }

        /// <summary>
        /// Higher number increases (by percentage) the damage done to a harvestable item/entity by a Dino. The higher number, the faster you collect
        /// </summary>
        public float DinoHarvestingDamageMultiplier { get; set; }

        /// <summary>
        /// Customizes the spawning rate for a given dinosaur type (at all dinosaur spawn points). Types with a larger SpawnWeightMultiplier are selected more often when spawning new dinosaurs than types with lower multipliers. When OverrideSpawnLimitPercentage is specified (and true), the type will never be spawned more than SpawnLimitPercentage * 100 percent of the time, regardless of multiplier.
        /// </summary>
        public string DinoSpawnWeightMultipliers { get; set; }

        /// <summary>
        /// Higher number increases (by percentage) the damage done by Turrets towards a Dino
        /// </summary>
        public float DinoTurretDamageMultiplier { get; set; }

        /// <summary>
        /// Higher number decreases (by percentage) time needed for fertilized egg to hatch 
        /// </summary>
        public float EggHatchSpeedMultiplier { get; set; }

        /// <summary>
        /// Scales the decomposition time of corpses, (player and dinosaur), globally. Higher values prolong the time
        /// </summary>
        public float GlobalCorpseDecompositionTimeMultiplier { get; set; }

        /// <summary>
        /// Scales the decomposition time of dropped items, loot bags etc. globally. Higher values prolong the time.
        /// </summary>
        public float GlobalItemDecompositionTimeMultiplier { get; set; }

        /// <summary>
        /// Scales the spoiling time of perishables globally. Higher values prolong the time. (Note: As of patch 196.0 there is still an issue whereby items moved to the player's inventory have their spoilage times reset to normal (value 1.0) despite what this value is set at)
        /// </summary>
        public float GlobalSpoilingTimeMultiplier { get; set; }

        /// <summary>
        /// Scales on a per-resource type basis, the amount of resources harvested. Higher values increase the amount per swing/attack
        /// </summary>
        public string HarvestResourceItemAmountClassMultipliers { get; set; }


        /// <summary>
        /// Higher number increases (by percentage) time between eggs spawning / being laid
        /// </summary>
        public float LayEggIntervalMultiplier { get; set; }

        /// <summary>
        /// Configure the total number of levels available to players and dinosaurs and the experience points required to reach each level.
        /// This directive can be specified twice in the configuration file.The first time it appears, the values provided will configure player levels.The second time it appears, the values provided will configure dinosaur levels.
        /// Because of this, each time the directive is used, it must list all of the levels players (or dinosaurs) can reach on the server. One ExperiencePointsForLevel argument must appear for each desired level. Values for <n> must be sequential, starting from zero.
        /// </summary>
        public string LevelExperienceRampOverrides { get; set; }

        /// <summary>
        /// Higher number increases (on a percentage scale) interval between which dinosaurs can mate
        /// </summary>
        public float MatingIntervalMultiplie { get; set; }

        /// <summary>
        /// This can be used to disable specific Alpha predators, replace the spawns of a particular NPC with that of a different NPC, or completely disable any specific NPC spawn
        /// </summary>
        public string NPCReplacements { get; set; }

        /// <summary>
        /// Configure the status and requirements for learning an engram. The EngramIndex argument is always required; the rest are optional, but at least one must be provided in order for the option to have any effect. The option may be repeated in GameUserSettings.ini once for each engram to be configured.
        /// </summary>
        public string OverrideEngramEntries { get; set; }

        /// <summary>
        /// Overrides the Max XP cap of player characters by exact specified amount.
        /// </summary>
        public int OverrideMaxExperiencePointsDino { get; set; }

        /// <summary>
        /// Overrides the Max XP cap of dinosaur characters by exact specified amount.
        /// </summary>
        public int OverrideMaxExperiencePointsPlayer { get; set; }

        /// <summary>
        /// Configure the number of engram points granted to players for each level gained.
        /// This option must be repeated for each player level configured on the server; if there are 65 player levels available, this option should appear in the configuration file 65 times.
        /// </summary>
        public int OverridePlayerLevelEngramPoints { get; set; }

        /// <summary>
        /// Higher number increases (by percentage) the damage done to a harvestable item/entity by a Player. The higher number, the faster you collect 
        /// </summary>
        public float PlayerHarvestingDamageMultiplier { get; set; }

        /// <summary>
        /// Higher number increases (by percentage) how frequently you can poop
        /// </summary>
        public float PoopIntervalMultiplier { get; set; }

        /// <summary>
        /// Prevents taming of specific dinosaurs via classname
        /// </summary>
        public string PreventDinoTameClassNames { get; set; }

        /// <summary>
        /// Allow resources to regrow closer or farther away from players. Values higher than 1 increase the distance around players where resources are allowed to grow back. Values between 0 and 1 will reduce it.
        /// </summary>
        public float ResourceNoReplenishRadiusPlayers { get; set; }

        /// <summary>
        /// Allow resources to regrow closer or farther away from structures. Values higher than 1 increase the distance around structures where resources are allowed to grow back. Values between 0 and 1 will reduce it.
        /// </summary>
        public float ResourceNoReplenishRadiusStructures { get; set; }

        /// <summary>
        /// Option for cooldown period on structure repair from the last time damaged. Set to 180 seconds by default, 0 to disable it 
        /// </summary>
        public int StructureDamageRepairCooldown { get; set; }
    }
}