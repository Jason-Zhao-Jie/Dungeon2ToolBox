namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 装备实际数据
    /// </summary>
    [System.Serializable]
    public struct EquipData
    {
        public string id;
        /// <summary> 装备固定数据 <seealso cref="EquipBaseData"/> </summary>
        public string baseId;
        /// <summary> 是否唯一装备 </summary>
        public bool isOnlyOne;
        /// <summary> 能否重铸 </summary>
        public bool canRecast;
        /// <summary> 属性 </summary>
        public PropertyData[] properties;
    }
}
