namespace exerciseCheck
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
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputPathBox = new System.Windows.Forms.TextBox();
            this.outPutPathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkListPathBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tureBox = new System.Windows.Forms.TextBox();
            this.falseBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.outPutFileNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "参照";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputPathBox
            // 
            this.inputPathBox.Location = new System.Drawing.Point(33, 94);
            this.inputPathBox.Name = "inputPathBox";
            this.inputPathBox.Size = new System.Drawing.Size(347, 19);
            this.inputPathBox.TabIndex = 1;
            // 
            // outPutPathBox
            // 
            this.outPutPathBox.Location = new System.Drawing.Point(33, 160);
            this.outPutPathBox.Name = "outPutPathBox";
            this.outPutPathBox.Size = new System.Drawing.Size(143, 19);
            this.outPutPathBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "入力元パス";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "出力先パス";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(33, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "提出状況チェック";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "参照";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(430, 44);
            this.button3.TabIndex = 7;
            this.button3.Text = "実行";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkListPathBox
            // 
            this.checkListPathBox.Location = new System.Drawing.Point(33, 261);
            this.checkListPathBox.Name = "checkListPathBox";
            this.checkListPathBox.Size = new System.Drawing.Size(347, 19);
            this.checkListPathBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "課題チェック用リスト";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(386, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "参照";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tureBox
            // 
            this.tureBox.Location = new System.Drawing.Point(280, 162);
            this.tureBox.Name = "tureBox";
            this.tureBox.Size = new System.Drawing.Size(32, 19);
            this.tureBox.TabIndex = 11;
            // 
            // falseBox
            // 
            this.falseBox.Location = new System.Drawing.Point(352, 164);
            this.falseBox.Name = "falseBox";
            this.falseBox.Size = new System.Drawing.Size(28, 19);
            this.falseBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "一致";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "不一致";
            // 
            // outPutFileNameBox
            // 
            this.outPutFileNameBox.Location = new System.Drawing.Point(33, 212);
            this.outPutFileNameBox.Name = "outPutFileNameBox";
            this.outPutFileNameBox.Size = new System.Drawing.Size(100, 19);
            this.outPutFileNameBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "出力ファイル名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 366);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.outPutFileNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.falseBox);
            this.Controls.Add(this.tureBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkListPathBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outPutPathBox);
            this.Controls.Add(this.inputPathBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputPathBox;
        private System.Windows.Forms.TextBox outPutPathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox checkListPathBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tureBox;
        private System.Windows.Forms.TextBox falseBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox outPutFileNameBox;
        private System.Windows.Forms.Label label7;
    }
}

