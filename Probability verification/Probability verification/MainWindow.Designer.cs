namespace Probability_verification
{
    partial class MainWindow
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
            this.executeButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crystalCount = new System.Windows.Forms.NumericUpDown();
            this.resetThreshold = new System.Windows.Forms.NumericUpDown();
            this.setCount = new System.Windows.Forms.NumericUpDown();
            this.halfResetCheck = new System.Windows.Forms.CheckBox();
            this.halfResetThreshold = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crystalCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.halfResetThreshold)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(196, 29);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(77, 33);
            this.executeButton.TabIndex = 0;
            this.executeButton.Text = "実行";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(297, 12);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(250, 277);
            this.resultTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.setCount);
            this.groupBox1.Controls.Add(this.crystalCount);
            this.groupBox1.Controls.Add(this.executeButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "試験設定";
            // 
            // crystalCount
            // 
            this.crystalCount.Location = new System.Drawing.Point(97, 18);
            this.crystalCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.crystalCount.Name = "crystalCount";
            this.crystalCount.Size = new System.Drawing.Size(82, 19);
            this.crystalCount.TabIndex = 0;
            this.crystalCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // resetThreshold
            // 
            this.resetThreshold.Location = new System.Drawing.Point(143, 43);
            this.resetThreshold.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.resetThreshold.Name = "resetThreshold";
            this.resetThreshold.Size = new System.Drawing.Size(36, 19);
            this.resetThreshold.TabIndex = 3;
            // 
            // setCount
            // 
            this.setCount.Location = new System.Drawing.Point(97, 43);
            this.setCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.setCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setCount.Name = "setCount";
            this.setCount.Size = new System.Drawing.Size(82, 19);
            this.setCount.TabIndex = 4;
            this.setCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // halfResetCheck
            // 
            this.halfResetCheck.AutoSize = true;
            this.halfResetCheck.Location = new System.Drawing.Point(9, 20);
            this.halfResetCheck.Name = "halfResetCheck";
            this.halfResetCheck.Size = new System.Drawing.Size(128, 16);
            this.halfResetCheck.TabIndex = 5;
            this.halfResetCheck.Text = "中間リセット閾値 残り";
            this.halfResetCheck.UseVisualStyleBackColor = true;
            this.halfResetCheck.CheckedChanged += new System.EventHandler(this.halfResetCheck_CheckedChanged);
            // 
            // halfResetThreshold
            // 
            this.halfResetThreshold.Location = new System.Drawing.Point(143, 19);
            this.halfResetThreshold.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.halfResetThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.halfResetThreshold.Name = "halfResetThreshold";
            this.halfResetThreshold.Size = new System.Drawing.Size(36, 19);
            this.halfResetThreshold.TabIndex = 7;
            this.halfResetThreshold.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "無条件リセット閾値 残り";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "クリスタル個数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "試行回数";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.resetThreshold);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.halfResetCheck);
            this.groupBox2.Controls.Add(this.halfResetThreshold);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 68);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "リセット閾値設定";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "以上";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "以下";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultTextBox);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crystalCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.halfResetThreshold)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown crystalCount;
        private System.Windows.Forms.NumericUpDown resetThreshold;
        private System.Windows.Forms.NumericUpDown setCount;
        private System.Windows.Forms.CheckBox halfResetCheck;
        private System.Windows.Forms.NumericUpDown halfResetThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

