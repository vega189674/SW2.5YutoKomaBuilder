
namespace SW2_5YutoKomaBuilder
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ScrapingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.isUseFreeItem = new System.Windows.Forms.CheckBox();
            this.freeItemNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.freeItemNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrapingButton
            // 
            this.ScrapingButton.Location = new System.Drawing.Point(652, 12);
            this.ScrapingButton.Name = "ScrapingButton";
            this.ScrapingButton.Size = new System.Drawing.Size(257, 112);
            this.ScrapingButton.TabIndex = 0;
            this.ScrapingButton.Text = "ゆとシートから読み込み";
            this.ScrapingButton.UseVisualStyleBackColor = true;
            this.ScrapingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(65, 55);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(519, 28);
            this.url.TabIndex = 2;
            this.url.Text = "https://yutorize.2-d.jp/ytsheet/sw2.5/?id=L6w31Q";
            this.url.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(65, 560);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(519, 28);
            this.log.TabIndex = 3;
            // 
            // isUseFreeItem
            // 
            this.isUseFreeItem.AutoSize = true;
            this.isUseFreeItem.Checked = true;
            this.isUseFreeItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isUseFreeItem.Location = new System.Drawing.Point(16, 208);
            this.isUseFreeItem.Name = "isUseFreeItem";
            this.isUseFreeItem.Size = new System.Drawing.Size(256, 25);
            this.isUseFreeItem.TabIndex = 4;
            this.isUseFreeItem.Text = "フリー枠を使用する/枠数：";
            this.isUseFreeItem.UseVisualStyleBackColor = true;
            this.isUseFreeItem.CheckedChanged += new System.EventHandler(this.isUseFreeItem_CheckedChanged);
            // 
            // freeItemNum
            // 
            this.freeItemNum.Location = new System.Drawing.Point(278, 205);
            this.freeItemNum.Name = "freeItemNum";
            this.freeItemNum.Size = new System.Drawing.Size(120, 28);
            this.freeItemNum.TabIndex = 5;
            this.freeItemNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.freeItemNum.ValueChanged += new System.EventHandler(this.freeItemNum_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 623);
            this.Controls.Add(this.freeItemNum);
            this.Controls.Add(this.isUseFreeItem);
            this.Controls.Add(this.log);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScrapingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.freeItemNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScrapingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox isUseFreeItem;
        private System.Windows.Forms.NumericUpDown freeItemNum;
    }
}

