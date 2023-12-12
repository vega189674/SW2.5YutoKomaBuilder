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

    }
}
