namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 代表以一项属性作为加成参数时的数据
    /// </summary>
    [System.Serializable]
    public struct PropertyUseData
    {
        /// <summary> 属性类型 </summary>
        public BasePropertyType type;
        /// <summary> 加成系数 </summary>
        public double value;
    }
}
