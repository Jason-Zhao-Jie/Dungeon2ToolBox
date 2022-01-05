namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary> 技能效果类型 </summary>
    public enum SkillResultType
    {
        /// <summary> 无效果 </summary>
        None,
        /// <summary> 物理伤害 </summary>
        PhysicDamage,
        /// <summary> 法术伤害 </summary>
        MagicDamage,
        /// <summary> 真实伤害 </summary>
        RealDamage,
        /// <summary> 治疗 </summary>
        Heal,
    }

    /// <summary>
    /// 技能数据
    /// </summary>
    [System.Serializable]
    public struct SkillData
    {
        public string id;
        /// <summary> 技能图标 <seealso cref="ResourceData"/> </summary>
        public string icon;
        /// <summary> 技能名 <seealso cref="StringData"/> </summary>
        public string name;
        /// <summary> 技能等级 </summary>
        public int level;
        /// <summary> 技能效果类型 </summary>
        public SkillResultType type;
        /// <summary> 技能目标选取方式 </summary>
        public TargetChoosenType targetType;
        /// <summary> 技能目标数量 </summary>
        public TargetNumType targetNumType;
        /// <summary> 技能基础命中率 </summary>
        public double accuracy;
        /// <summary> 技能基础暴击率 </summary>
        public double criticalRate;
        /// <summary> 技能效果（如伤害、回复，不包含buff）额外提升的承受者种族 <seealso cref="RaceData"/> </summary>
        public string valueIncreaseRace;
        /// <summary> 技能效果额外提升的承受者种族受到的提升量 </summary>
        public double valueIncreased;
        /// <summary> 技能基础冷却值 </summary>
        public double countDown;
        /// <summary> 技能效果数值类型 </summary>
        public ValueType valueType;
        /// <summary> 技能效果固定数值（伤害值、回复值） </summary>
        public double value;
        /// <summary> 技能效果根据发动者属性加成的数值 </summary>
        public PropertyUseData[] sourcePropertyAddedValue;
        /// <summary> 技能效果根据承受者属性加成的数值 </summary>
        public PropertyUseData[] destinyPropertyAddedValue;
        /// <summary> 技能附带的buff效果 <seealso cref="BuffData"/> </summary>
        public string[] buffs;
    }
}
