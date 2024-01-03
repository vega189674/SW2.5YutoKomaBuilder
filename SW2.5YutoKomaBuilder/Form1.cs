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
        private static Form1 form1 = null;


        public static Form1 GetInstance()
        {
            if (form1 == null)
            {
                form1 = new Form1();

            }
            return form1;
        }
        private Form1()
        {
            InitializeComponent();
        }

        private static string filename = "url.txt";

        public bool isUseFreeItemChecked
        {
            get { return isUseFreeItem.Checked; }
        }

        public int freeItemNumValue
        {
            get { return (int)freeItemNum.Value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.Text = "処理開始";
            var yutoURL = url.Text;

            try
            {
                YutoDataController yutoDataController = new YutoDataController();
                var yutoKomaJson = yutoDataController.ReadYutoJson(yutoURL);

                var jsonWriteData = JsonConvert.SerializeObject(yutoKomaJson);

                Clipboard.SetText(jsonWriteData);
                log.Text = "処理完了.クリップボードにコマ情報をコピーしました";
            }
            catch
            {
                log.Text = "無効なURLです";
            }


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

        private void isUseFreeItem_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void freeItemNum_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ファイルにTextAreaの値を保存する
            System.IO.File.WriteAllText(filename, url.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ファイルからTextAreaの値を読み込む
            if (System.IO.File.Exists(filename))
            {
                url.Text = System.IO.File.ReadAllText(filename);
            }
        }
    }
}
