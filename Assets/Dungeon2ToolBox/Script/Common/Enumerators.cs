using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon2ToolBox.Common
{
    namespace Definitions
    {
        /// <summary> 独立的基础属性 </summary>
        public enum BasePropertyType
        {
            /// <summary> 力量 </summary>
            Power,
            /// <summary> 魔力 </summary>
            Mana,
            /// <summary> 技巧 </summary>
            Technique,
            /// <summary> 速度 </summary>
            Speed,
            /// <summary> 体制 </summary>
            Strong,
            /// <summary> 护甲 </summary>
            PhysicDefense,
            /// <summary> 抗性 </summary>
            MagicDefense,
            /// <summary> 武器威力 </summary>
            WeaponForce,
            /// <summary> 附加命中率 </summary>
            AddedAccuracy,
            /// <summary> 附加暴击率 </summary>
            AddedCriticalRate,
            /// <summary> 附加闪避率 </summary>
            AddedEvade,
            /// <summary> 回复效果 </summary>
            HealResult,
            /// <summary> 异常附加率 </summary>
            AddedDebuffRate,
            /// <summary> 无视护甲 </summary>
            PDThrough,
            /// <summary> 无视抗性 </summary>
            MDThrough,
            /// <summary> 吸血 </summary>
            HealthSteal,
            /// <summary> 物理吸血 </summary>
            PhysicHealthSteal,
            /// <summary> 物理单体吸血 </summary>
            PhysicSingleHealthSteal,
            /// <summary> 物理群体吸血 </summary>
            PhysicMutipleHealthSteal,
            /// <summary> 法术吸血 </summary>
            MagicHealthSteal,
            /// <summary> 法术单体吸血 </summary>
            MagicSingleHealthSteal,
            /// <summary> 法术群体吸血 </summary>
            MagicMutipleHealthSteal,
            /// <summary> 附加物理伤害 </summary>
            AddedPhysicDamage,
            /// <summary> 附加法术伤害 </summary>
            AddedMagicalDamage,
        }

        /// <summary> 目标类型 </summary>
        public enum TargetChoosenType
        {
            /// <summary> 自身 </summary>
            Self,
            /// <summary> 我方 </summary>
            Us,
            /// <summary> 敌方 </summary>
            Them,
            /// <summary> 我方及敌方 </summary>
            All,
        }

        /// <summary> 目标数量 </summary>
        public enum TargetNumType
        {
            /// <summary> 被动无目标 </summary>
            Passive,
            /// <summary> 单体 </summary>
            Single,
            /// <summary> 群体 </summary>
            Mutiple,
        }

        /// <summary> 技能效果类型 </summary>
        public enum SkillResultType
        {
            /// <summary> 无效果 </summary>
            None,
            /// <summary> 物理伤害 </summary>
            PhysicDamage,
            /// <summary> 法术伤害 </summary>
            MagicDamage,
            /// <summary> 真实伤害 </summary>
            RealDamage,
            /// <summary> 治疗 </summary>
            Heal,
        }

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

        public enum ValueType
        {
            Additional,
            Base,
            Percent,
            PercentOfBase,
        }
    }
}
