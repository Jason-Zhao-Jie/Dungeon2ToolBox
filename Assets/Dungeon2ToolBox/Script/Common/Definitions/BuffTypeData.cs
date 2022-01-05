namespace Dungeon2ToolBox.Common.Definitions
{
    /// <summary> 状态效果类型 </summary>
    public enum BuffResultType
    {
        /// <summary> 属性增强 </summary>
        UpProperty,
        /// <summary> 属性减弱 </summary>
        DownProperty,
        /// <summary> 回复 </summary>
        Heal,
        /// <summary> 伤害 </summary>
        Damage,
        /// <summary> 免疫某类型状态 </summary>
        BuffInvalid,
    }

    /// <summary> DOT 伤害类型 </summary>
    public enum BuffDamageType
    {
        /// <summary> 真实伤害 </summary>
        Real,
        /// <summary> 瘟疫 </summary>
        Plague,
        /// <summary> 流血 </summary>
        Bleeding,
        /// <summary> 灼烧 </summary>
        Burning,
        /// <summary> 生命流失 </summary>
        LifeLossing,
        /// <summary> 夺魂 </summary>
        DistractionDriven,
    }

    /// <summary> 状态发动方式 </summary>
    public enum BuffStartType
    {
        /// <summary> 战斗开始时生效 </summary>
        OnStart,
        /// <summary> 攻击时发动 </summary>
        OnAttack,
        /// <summary> 物理攻击时发动 </summary>
        OnPhysicAttack,
        /// <summary> 法术攻击时发动 </summary>
        OnMagicAttack,
        /// <summary> 回复时发动 </summary>
        OnHealing,
        /// <summary> 受到攻击时发动 </summary>
        UnderAttack,
        /// <summary> 受到物理攻击时发动 </summary>
        UnderPhysicAttack,
        /// <summary> 受到法术攻击时发动 </summary>
        UnderMagicAttack,
        /// <summary> 受到回复时发动 </summary>
        UnderHealing,
    }

    /// <summary> 状态生效持续方式 </summary>
    public enum BuffDurationType
    {
        /// <summary> 永久生效 </summary>
        Forever,
        /// <summary> 永久生效直至重伤 </summary>
        BeforeHurt,
        /// <summary> 瞬间生效 </summary>
        Moment,
        /// <summary> 持续指定时间 </summary>
        Seconds,
        /// <summary> 持续直到（护盾量、总伤害量）耗尽 </summary>
        Values,
    }

    /// <summary>
    /// 增益基础类别属性，类别属性相同的两个增益只能互相覆盖
    /// </summary>
    [System.Serializable]
    public struct BuffTypeData
    {
        public string id;
        /// <summary> 增益图标 <seealso cref="ResourceData"/> </summary>
        public string icon;
        /// <summary> 增益名 <seealso cref="StringData"/> </summary>
        public string name;
        /// <summary> 增益效果类型 </summary>
        public BuffResultType type;
        /// <summary> 
        /// 增益效果子类型（Dot类型、属性类型）。
        /// <br/><seealso cref="BuffDamageType" />
        /// <br/><seealso cref="BasePropertyType" />
        /// </summary>
        public int subType;
        /// <summary> 增益发动方式 </summary>
        public BuffStartType startType;
        /// <summary> 增益有效期计算方式 </summary>
        public BuffDurationType durationType;
        /// <summary> 增益生效冷却计算组(组内有未冷却增益则视为未冷却，用于计算同名冲突增益) </summary>
        public int[] countDownGroup;
    }
}
