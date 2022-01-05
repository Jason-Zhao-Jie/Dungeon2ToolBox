namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 装备固定数据
    /// </summary>
    [System.Serializable]
    public struct EquipBaseData
    {
        public string id;
        /// <summary> 装备图标 <seealso cref="ResourceData"/> </summary>
        public string icon;
        /// <summary> 装备名 <seealso cref="StringData"/> </summary>
        public string name;
        /// <summary> 装备部位 <seealso cref="EquipPosData"/> </summary>
        public string pos;
        /// <summary> 品质 <seealso cref="QualityData"/> </summary>
        public string quality;
        /// <summary> 必有加成属性 </summary>
        public PropertyRangeData[] mustProperties;
        /// <summary> 可选加成属性 </summary>
        public PropertyRangeData[] randomProperties;
        /// <summary> 可选加成数量 </summary>
        public int randomNum;
        /// <summary> 装备附带的buff效果 <seealso cref="BuffData"/> </summary>
        public string[] buffs;
    }
}
