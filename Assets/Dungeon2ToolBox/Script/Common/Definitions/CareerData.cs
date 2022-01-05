namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary>
    /// 代表一个职业的类型数据, 包含技能数据
    /// </summary>
    [System.Serializable]
    public struct CareerData
    {
        public string id;
        /// <summary> 职业图标 <seealso cref="ResourceData"/> </summary>
        public string icon;
        /// <summary> 职业名 <seealso cref="StringData"/> </summary>
        public string name;
        /// <summary> 品质 <seealso cref="QualityData"/> </summary>
        public string quality;
        /// <summary> 上一级职业 <seealso cref="CareerData"/> </summary>
        public string prevCareer;
        /// <summary> 下一级职业 <seealso cref="CareerData"/> </summary>
        public string[] nextCareers;
        /// <summary> 技能 <seealso cref="SkillData"/> </summary>
        public string[] skills;
    }
}
