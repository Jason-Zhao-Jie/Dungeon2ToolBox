namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary> 属性加成方式 </summary>
    public enum ValueType
    {
        /// <summary> 附加值 </summary>
        Additional,
        /// <summary> 基础值 </summary>
        Base,
        /// <summary> 附加百分比 </summary>
        Percent,
        /// <summary> 附加基础值百分比(仅按基础值乘以此百分比得到最终附加) </summary>
        PercentOfBase,
    }
}
