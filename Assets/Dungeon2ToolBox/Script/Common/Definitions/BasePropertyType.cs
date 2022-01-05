namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary> 独立的基础属性 </summary>
    public enum BasePropertyType
    {
        /// <summary> 力量 </summary>
        Power,
        /// <summary> 魔力 </summary>
        Mana,
        /// <summary> 技巧 </summary>
        Technique,
        /// <summary> 速度 </summary>
        Speed,
        /// <summary> 体制 </summary>
        Strong,
        /// <summary> 护甲 </summary>
        PhysicDefense,
        /// <summary> 抗性 </summary>
        MagicDefense,
        /// <summary> 武器威力 </summary>
        WeaponForce,
        /// <summary> 附加命中率 </summary>
        AddedAccuracy,
        /// <summary> 附加暴击率 </summary>
        AddedCriticalRate,
        /// <summary> 附加闪避率 </summary>
        AddedEvade,
        /// <summary> 回复效果 </summary>
        HealResult,
        /// <summary> 异常附加率 </summary>
        AddedDebuffRate,
        /// <summary> 无视护甲 </summary>
        PDThrough,
        /// <summary> 无视抗性 </summary>
        MDThrough,
        /// <summary> 吸血 </summary>
        HealthSteal,
        /// <summary> 物理吸血 </summary>
        PhysicHealthSteal,
        /// <summary> 物理单体吸血 </summary>
        PhysicSingleHealthSteal,
        /// <summary> 物理群体吸血 </summary>
        PhysicMutipleHealthSteal,
        /// <summary> 法术吸血 </summary>
        MagicHealthSteal,
        /// <summary> 法术单体吸血 </summary>
        MagicSingleHealthSteal,
        /// <summary> 法术群体吸血 </summary>
        MagicMutipleHealthSteal,
        /// <summary> 附加物理伤害 </summary>
        AddedPhysicDamage,
        /// <summary> 附加法术伤害 </summary>
        AddedMagicalDamage,
        /// <summary> 剩余生命值 </summary>
        Health,
        /// <summary> 已损失生命值 </summary>
        LostHealth,
    }
}
