namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 角色裸属性
    /// </summary>
    [System.Serializable]
    public struct RoleEmptyPropertyData
    {
        /// <summary> 角色姓名 <seealso cref="StringData"/> </summary>
        public string name;
        /// <summary> 角色等级 </summary>
        public int level;
        /// <summary> 
        /// 职业 <seealso cref="CareerData"/>。
        /// 此处指具体职业，覆盖 <see cref="RoleBaseData"/> 里的职业属性 <see cref="RoleBaseData.career"/> 
        /// </summary>
        public string career;
        /// <summary> 角色属性 </summary>
        public PropertyData[] properties;
    }
}
