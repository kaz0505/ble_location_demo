namespace WindowsFormsApp1
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
            this.map = new System.Windows.Forms.PictureBox();
            this.buttonSetBLE = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLocation1 = new System.Windows.Forms.Label();
            this.textBoxRSSI1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRSSI2 = new System.Windows.Forms.TextBox();
            this.labelLocation2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxRSSI3 = new System.Windows.Forms.TextBox();
            this.labelLocation3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Location = new System.Drawing.Point(173, 12);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(837, 551);
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            // 
            // buttonSetBLE
            // 
            this.buttonSetBLE.Location = new System.Drawing.Point(12, 12);
            this.buttonSetBLE.Name = "buttonSetBLE";
            this.buttonSetBLE.Size = new System.Drawing.Size(155, 36);
            this.buttonSetBLE.TabIndex = 1;
            this.buttonSetBLE.Text = "BLE位置設定";
            this.buttonSetBLE.UseVisualStyleBackColor = true;
            this.buttonSetBLE.Click += new System.EventHandler(this.buttonSetBLE_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(12, 71);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(155, 36);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "位置計算";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRSSI1);
            this.groupBox1.Controls.Add(this.labelLocation1);
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "受信RSSI-1";
            // 
            // labelLocation1
            // 
            this.labelLocation1.AutoSize = true;
            this.labelLocation1.Location = new System.Drawing.Point(6, 32);
            this.labelLocation1.Name = "labelLocation1";
            this.labelLocation1.Size = new System.Drawing.Size(98, 15);
            this.labelLocation1.TabIndex = 0;
            this.labelLocation1.Text = "labelLocation1";
            // 
            // textBoxRSSI1
            // 
            this.textBoxRSSI1.Location = new System.Drawing.Point(6, 64);
            this.textBoxRSSI1.Name = "textBoxRSSI1";
            this.textBoxRSSI1.Size = new System.Drawing.Size(143, 22);
            this.textBoxRSSI1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxRSSI2);
            this.groupBox2.Controls.Add(this.labelLocation2);
            this.groupBox2.Location = new System.Drawing.Point(12, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 109);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "受信RSSI-2";
            // 
            // textBoxRSSI2
            // 
            this.textBoxRSSI2.Location = new System.Drawing.Point(6, 64);
            this.textBoxRSSI2.Name = "textBoxRSSI2";
            this.textBoxRSSI2.Size = new System.Drawing.Size(143, 22);
            this.textBoxRSSI2.TabIndex = 1;
            // 
            // labelLocation2
            // 
            this.labelLocation2.AutoSize = true;
            this.labelLocation2.Location = new System.Drawing.Point(6, 32);
            this.labelLocation2.Name = "labelLocation2";
            this.labelLocation2.Size = new System.Drawing.Size(98, 15);
            this.labelLocation2.TabIndex = 0;
            this.labelLocation2.Text = "labelLocation2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxRSSI3);
            this.groupBox3.Controls.Add(this.labelLocation3);
            this.groupBox3.Location = new System.Drawing.Point(12, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 109);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "受信RSSI-3";
            // 
            // textBoxRSSI3
            // 
            this.textBoxRSSI3.Location = new System.Drawing.Point(6, 64);
            this.textBoxRSSI3.Name = "textBoxRSSI3";
            this.textBoxRSSI3.Size = new System.Drawing.Size(143, 22);
            this.textBoxRSSI3.TabIndex = 1;
            // 
            // labelLocation3
            // 
            this.labelLocation3.AutoSize = true;
            this.labelLocation3.Location = new System.Drawing.Point(6, 32);
            this.labelLocation3.Name = "labelLocation3";
            this.labelLocation3.Size = new System.Drawing.Size(98, 15);
            this.labelLocation3.TabIndex = 0;
            this.labelLocation3.Text = "labelLocation3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 575);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonSetBLE);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.Text = "位置推定（3点）";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.Button buttonSetBLE;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRSSI1;
        private System.Windows.Forms.Label labelLocation1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxRSSI2;
        private System.Windows.Forms.Label labelLocation2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxRSSI3;
        private System.Windows.Forms.Label labelLocation3;
    }
}

