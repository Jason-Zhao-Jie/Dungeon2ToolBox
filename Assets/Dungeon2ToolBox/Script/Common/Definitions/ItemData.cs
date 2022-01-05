namespace Dungeon2ToolBox.Common.Definitions
{
    public enum ItemType
    {
        Normal,
        Special,
    }

    [System.Serializable]
    public struct ItemData
    {
        public string id;
        /// <summary> 物品类型 </summary>
        public ItemType type;
        /// <summary> 品质 <seealso cref="QualityData"/> </summary>
        public string quality;
        /// <summary> 物品名称 <seealso cref="StringData"/> </summary>
        public string name;
        /// <summary> 物品图标 <seealso cref="ResourceData"/> </summary>
        public string icon;
        /// <summary> 物品描述 <seealso cref="StringData"/> </summary>
        public string comment;
        /// <summary> 物品来源 <seealso cref="StringData"/> </summary>
        public string from;
    }
}
