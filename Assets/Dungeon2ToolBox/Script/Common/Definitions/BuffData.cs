namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 增益数据
    /// </summary>
    [System.Serializable]
    public struct BuffData
    {
        public string id;
        /// <summary> 增益基础类别属性 <seealso cref="BuffTypeData"/> </summary>
        public string type;
        /// <summary> 增益目标选取方式 </summary>
        public TargetChoosenType targetType;
        /// <summary> 增益目标数量 </summary>
        public TargetNumType targetNumType;
        /// <summary> 增益发动几率 </summary>
        public int startRate;
        /// <summary> 是否受发动者"异常附加率"属性增加几率效果 </summary>
        public bool rateIncByProperty;
        /// <summary> 是否受承受者"抗性"属性降低几率效果 </summary>
        public bool rateDecByProperty;
        /// <summary> 增益有效期计算值（毫秒或其他） </summary>
        public int durationValue;
        /// <summary> 增益效果数值类型 </summary>
        public ValueType valueType;
        /// <summary> 增益效果固定数值（伤害值、回复值、属性升降值） </summary>
        public double value;
        /// <summary> 增益效果根据发动者属性加成的数值 </summary>
        public PropertyUseData[] sourcePropertyAddedValue;
        /// <summary> 增益效果根据承受者属性加成的数值 </summary>
        public PropertyUseData[] destinyPropertyAddedValue;
        /// <summary> 增益生效冷却值 </summary>
        public double countDown;
    }
}
