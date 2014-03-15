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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.halfResetThreshold = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crystalCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.halfResetThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(201, 242);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(90, 47);
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
            this.groupBox1.Controls.Add(this.crystalCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "クリスタル個数";
            // 
            // crystalCount
            // 
            this.crystalCount.Location = new System.Drawing.Point(6, 18);
            this.crystalCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.crystalCount.Name = "crystalCount";
            this.crystalCount.Size = new System.Drawing.Size(120, 19);
            this.crystalCount.TabIndex = 0;
            this.crystalCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // resetThreshold
            // 
            this.resetThreshold.Location = new System.Drawing.Point(132, 123);
            this.resetThreshold.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.resetThreshold.Name = "resetThreshold";
            this.resetThreshold.Size = new System.Drawing.Size(120, 19);
            this.resetThreshold.TabIndex = 3;
            // 
            // setCount
            // 
            this.setCount.Location = new System.Drawing.Point(17, 18);
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
            this.setCount.Size = new System.Drawing.Size(120, 19);
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
            this.halfResetCheck.Location = new System.Drawing.Point(12, 101);
            this.halfResetCheck.Name = "halfResetCheck";
            this.halfResetCheck.Size = new System.Drawing.Size(104, 16);
            this.halfResetCheck.TabIndex = 5;
            this.halfResetCheck.Text = "中間リセット判定";
            this.halfResetCheck.UseVisualStyleBackColor = true;
            this.halfResetCheck.CheckedChanged += new System.EventHandler(this.halfResetCheck_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.setCount);
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 47);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "試行回数";
            // 
            // halfResetThreshold
            // 
            this.halfResetThreshold.Location = new System.Drawing.Point(132, 98);
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
            this.halfResetThreshold.Size = new System.Drawing.Size(120, 19);
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
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "無条件リセット閾値";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.halfResetThreshold);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.halfResetCheck);
            this.Controls.Add(this.resetThreshold);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.executeButton);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crystalCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.halfResetThreshold)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown halfResetThreshold;
        private System.Windows.Forms.Label label1;
    }
}

