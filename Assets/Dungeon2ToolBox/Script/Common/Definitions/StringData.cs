namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 字符串配置
    /// </summary>
    [System.Serializable]
    public struct StringData
    {
        public string id;
        /// <summary> 字符串内容，不同语言下内容不同 </summary>
        public string value;
    }
}
