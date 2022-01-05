namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 代表一个种族的类型数据
    /// </summary>
    [System.Serializable]
    public struct RaceData
    {
        public string id;
        /// <summary> 种族图标 <seealso cref="ResourceData"/> </summary>
        public string icon;
        /// <summary> 种族名 <seealso cref="StringData"/> </summary>
        public string name;
    }
}
