namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 代表一个装备部位
    /// </summary>
    [System.Serializable]
    public struct EquipPosData
    {
        public string id;
        /// <summary> 装备部位名 <seealso cref="StringData"/> </summary>
        public string name;
        /// <summary> 计算属性时的优先级，数字越大，越晚计算 </summary>
        public int rank;
    }
}
