namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 代表一项属性的加成取值范围数据，通常用于装备预设数据
    /// </summary>
    [System.Serializable]
    public struct PropertyRangeData
    {
        /// <summary> 属性类型 </summary>
        public BasePropertyType type;
        /// <summary> 属性数值类型 </summary>
        public ValueType valueType;
        /// <summary> 属性值 </summary>
        public double minValue;
        /// <summary> 属性值 </summary>
        public double maxValue;
    }
}
