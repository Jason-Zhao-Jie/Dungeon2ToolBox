namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 代表一个颜色, 不同事物(人物潜力,装备)的品质级别数据不一样, 但用同一套颜色系统。
    /// 由于读取配置不能以 byte 类型处理整型，所以只能采用 <see cref="int"/>
    /// </summary>
    [System.Serializable]
    public struct ColorData
    {
        public string id;
        /// <summary> 颜色名 <seealso cref="StringData"/> </summary>
        public string name;
        /// <summary> R红色值 0-255 </summary>
        public int colorR;
        /// <summary> G绿色值 0-255 </summary>
        public int colorG;
        /// <summary> B蓝色值 0-255 </summary>
        public int colorB;
        /// <summary> A透明通道值 0-255 </summary>
        public int colorA;
    }
}
