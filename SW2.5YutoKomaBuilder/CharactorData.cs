using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace SW2._5YutoKomaBuilder
{
    public class CharactorData
    {
        // キャラクター名
        public string characterName { get; set; }
        // 作成者名（PL名）
        public string playerName { get; set; }
        // 移動力
        public string mobilityTotal { get; set; }
        // 最終的な最大HP
        public string hpTotal { get; set; }
        // 最終的な最大MP
        public string mpTotal { get; set; }
        // 1番目の装備構成の回避力
        public string defenseTotal1Eva { get; set; }
        // 1番目の装備構成の防護点
        public string defenseTotal1Def { get; set; }


        // ステータス系
        // 生命抵抗力
        public string vitResistTotal { get; set; }
        // 精神抵抗力
        public string mndResistTotal { get; set; }
        // 器用度ボーナス
        public string bonusDex { get; set; }
        // 敏捷力ボーナス
        public string bonusAgi { get; set; }
        // 筋力ボーナス
        public string bonusStr { get; set; }
        // 生命力ボーナス
        public string bonusVit { get; set; }
        // 知力ボーナス
        public string bonusInt { get; set; }
        // 精神力ボーナス
        public string bonusMnd { get; set; }
    }
}