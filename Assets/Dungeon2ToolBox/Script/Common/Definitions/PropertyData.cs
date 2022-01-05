namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 代表一项属性的数据
    /// </summary>
    [System.Serializable]
    public struct PropertyData
    {
        /// <summary> 属性类型 </summary>
        public BasePropertyType type;
        /// <summary> 属性数值类型 </summary>
        public ValueType valueType;
        /// <summary> 属性值 </summary>
        public double value;
    }
}
