namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 角色基础数据
    /// </summary>
    [System.Serializable]
    public struct RoleBaseData
    {
        public string id;
        /// <summary> 统一称呼 <seealso cref="StringData"/> </summary>
        public string called;
        /// <summary> 头像 <seealso cref="ResourceData"/> </summary>
        public string avatar;
        /// <summary> 半身像 <seealso cref="ResourceData"/> </summary>
        public string halfBodyPhoto;
        /// <summary> 全身像 <seealso cref="ResourceData"/> </summary>
        public string wholeBodyPhoto;
        /// <summary> 种族 <seealso cref="RaceData"/> </summary>
        public string race;
        /// <summary> 职业 <seealso cref="CareerData"/> </summary>
        public string career;
        /// <summary> 简介 <seealso cref="StringData"/> </summary>
        public string story;
    }
}
