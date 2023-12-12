using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SW2_5YutoKomaBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.Text = "処理開始";
            var yutoURL = url.Text;

            YutoDataController yutoDataController = new YutoDataController();
            var yutoKomaJson = yutoDataController.ReadYutoJson(yutoURL);

            var jsonWriteData = JsonConvert.SerializeObject(yutoKomaJson);

            Clipboard.SetText(jsonWriteData);
            log.Text = "処理完了.クリップボードにコマ情報をコピーしました";


            /*
            // C:¥work¥PersonJson.json.json を UTF-8 で書き込み用でオープン
            using (var sw = new StreamWriter(@"D:\work\Yutokoma.json", false, System.Text.Encoding.UTF8))
            {
                // JSON データをファイルに書き込み
                sw.Write(jsonWriteData);
            }
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private YutoKomaJson SetYutokomaJson(CharactorData charactorData)
        {
            YutoKomaJson ret = new YutoKomaJson();
            ret.kind = "character";
            ret.data.p_name = charactorData.playerName;
            ret.data.c_name = charactorData.characterName;
            ret.data.initiative = Convert.ToInt32(charactorData.mobilityTotal);

            Status hp = new Status()
            {
                label = "HP",
                value = charactorData.hpTotal,
                max = charactorData.hpTotal
            };
            ret.data.statuses.Add(hp);
            Status mp = new Status()
            {
                label = "MP",
                value = charactorData.mpTotal,
                max = charactorData.mpTotal
            };
            ret.data.statuses.Add(mp);
            Status def = new Status()
            {
                label = "防護点",
                value = charactorData.defenseTotal1Def,
                max = charactorData.defenseTotal1Def
            };
            ret.data.statuses.Add(def);
            Status eva = new Status()
            {
                label = "回避力",
                value = charactorData.defenseTotal1Eva,
                max = charactorData.defenseTotal1Eva
            };
            ret.data.statuses.Add(eva);
            ret.data.statuses.Add(new Status());
            ret.data.statuses.Add(new Status());
            ret.data.statuses.Add(new Status());
            ret.data.statuses.Add(new Status());
            ret.data.statuses.Add(new Status("魔力修正"));
            ret.data.statuses.Add(new Status("魔法C","10"));
            ret.data.statuses.Add(new Status("行使修正"));
            ret.data.statuses.Add(new Status("魔法D修正"));
            ret.data.statuses.Add(new Status("回復量修正"));
            ret.data.statuses.Add(new Status("命中修正"));
            ret.data.statuses.Add(new Status("C修正"));
            ret.data.statuses.Add(new Status("追加D修正"));
            ret.data.statuses.Add(new Status("必殺効果"));
            ret.data.statuses.Add(new Status("クリレイ"));
            ret.data.statuses.Add(new Status("生命抵抗修正"));
            ret.data.statuses.Add(new Status("精神抵抗修正"));
            ret.data.statuses.Add(new Status("回避修正"));

            Parameter vit = new Parameter()
            {
                label = "生命抵抗力",
                value = charactorData.vitResistTotal
            };
            ret.data.parameters.Add(vit);
            Parameter mnd = new Parameter()
            {
                label = "精神抵抗力",
                value = charactorData.mndResistTotal
            };
            ret.data.parameters.Add(mnd);

            return ret;
        }

        string DownloadString(string url)
        {
            using (var webClient = new System.Net.WebClient())
            {
                // WebClientのDownloadはANSIなのでUTF8に変換
                webClient.Encoding = System.Text.Encoding.UTF8;
                return webClient.DownloadString(url);
            }
        }
    }
}
