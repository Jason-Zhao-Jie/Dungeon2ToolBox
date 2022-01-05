namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary> 蓝图类型 </summary>
    public enum BluePrintType
    {
        /// <summary> 物品蓝图 </summary>
        Item,
        /// <summary> 装备蓝图 </summary>
        Equip,
        /// <summary> 特殊蓝图 </summary>
        Special,
    }

    /// <summary> 蓝图数据 </summary>
    [System.Serializable]
    public struct BluePrintData
    {
        public string id;
        /// <summary> 蓝图名 <seealso cref="StringData"/> </summary>
        public string name;
        /// <summary> 蓝图图标 <seealso cref="ResourceData"/> </summary>
        public string icon;
        /// <summary> 蓝图类型 </summary>
        public BluePrintType type;
        /// <summary> 蓝图目标 ID （装备/物品/特殊功能) 。
        /// <br/><seealso cref="EquipBaseData"/> : 如果是装备，则根据锭的品质决定是哪个装备
        /// <br/><seealso cref="ItemData"/> 
        /// </summary>
        public string[] target;
        /// <summary> 蓝图描述 <seealso cref="StringData"/> </summary>
        public string comment;
        /// <summary> 蓝图所需材料物品,不包含符文和锭 <seealso cref="ItemData"/> </summary>
        public string[] items;
        /// <summary> 所需锭数量 </summary>
        public int ingotNum;
        /// <summary> 所需符文数量 </summary>
        public int runesNum;
        /// <summary> 可以使用的锭，根据锭的品质决定装备 <seealso cref="ItemData"/> </summary>
        public string[] ingotItems;
        /// <summary> 物品来源 <seealso cref="StringData"/> </summary>
        public string from;
    }
}
