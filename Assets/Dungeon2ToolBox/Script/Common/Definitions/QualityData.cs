namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 代表一个品质级别
    /// </summary>
    [System.Serializable]
    public struct QualityData
    {
        public string id;
        /// <summary> 品质名 <seealso cref="StringData"/> </summary>
        public string name;
        /// <summary> 颜色 <seealso cref="ColorData"/> </summary>
        public string color;
    }
}
