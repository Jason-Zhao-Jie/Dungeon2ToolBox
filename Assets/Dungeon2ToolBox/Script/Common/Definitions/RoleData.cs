namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 角色具体数据, 包含固有资料、属性、装备
    /// </summary>
    [System.Serializable]
    public struct RoleData
    {
        public string id;
        /// <summary> 角色基础资料 <seealso cref="RoleBaseData"/> </summary>
        public string baseData;
        /// <summary> 角色裸属性 </summary>
        public RoleEmptyPropertyData emptyData;
        /// <summary> 角色装备 <seealso cref="EquipData"/> </summary>
        public string[] equips;
    }
}
