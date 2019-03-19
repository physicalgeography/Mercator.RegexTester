namespace Mercator.RegexTester
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PatternTextBox = new System.Windows.Forms.TextBox();
            this.MatchButton = new System.Windows.Forms.Button();
            this.PatternLabel = new System.Windows.Forms.Label();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ReferenceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PatternTextBox
            // 
            this.PatternTextBox.Location = new System.Drawing.Point(78, 13);
            this.PatternTextBox.Name = "PatternTextBox";
            this.PatternTextBox.Size = new System.Drawing.Size(313, 21);
            this.PatternTextBox.TabIndex = 0;
            this.PatternTextBox.Text = "\\{(\\S+)\\}\\.\\[(文本|数字|日期|图片|表格)\\]";
            // 
            // MatchButton
            // 
            this.MatchButton.Location = new System.Drawing.Point(397, 12);
            this.MatchButton.Name = "MatchButton";
            this.MatchButton.Size = new System.Drawing.Size(75, 23);
            this.MatchButton.TabIndex = 1;
            this.MatchButton.Text = "匹配";
            this.MatchButton.UseVisualStyleBackColor = true;
            this.MatchButton.Click += new System.EventHandler(this.MatchButton_Click);
            // 
            // PatternLabel
            // 
            this.PatternLabel.AutoSize = true;
            this.PatternLabel.Location = new System.Drawing.Point(12, 16);
            this.PatternLabel.Name = "PatternLabel";
            this.PatternLabel.Size = new System.Drawing.Size(29, 12);
            this.PatternLabel.TabIndex = 2;
            this.PatternLabel.Text = "模式";
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.AcceptsReturn = true;
            this.SourceTextBox.Location = new System.Drawing.Point(78, 45);
            this.SourceTextBox.Multiline = true;
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SourceTextBox.Size = new System.Drawing.Size(475, 94);
            this.SourceTextBox.TabIndex = 3;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(78, 145);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultTextBox.Size = new System.Drawing.Size(475, 183);
            this.ResultTextBox.TabIndex = 4;
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(12, 48);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(41, 12);
            this.SourceLabel.TabIndex = 5;
            this.SourceLabel.Text = "源文本";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 148);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(53, 12);
            this.ResultLabel.TabIndex = 6;
            this.ResultLabel.Text = "匹配结果";
            // 
            // ReferenceButton
            // 
            this.ReferenceButton.Location = new System.Drawing.Point(478, 12);
            this.ReferenceButton.Name = "ReferenceButton";
            this.ReferenceButton.Size = new System.Drawing.Size(75, 23);
            this.ReferenceButton.TabIndex = 7;
            this.ReferenceButton.Text = "参考";
            this.ReferenceButton.UseVisualStyleBackColor = true;
            this.ReferenceButton.Click += new System.EventHandler(this.ReferenceButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 340);
            this.Controls.Add(this.ReferenceButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.SourceTextBox);
            this.Controls.Add(this.PatternLabel);
            this.Controls.Add(this.MatchButton);
            this.Controls.Add(this.PatternTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "正则表达式测试器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PatternTextBox;
        private System.Windows.Forms.Button MatchButton;
        private System.Windows.Forms.Label PatternLabel;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ReferenceButton;
    }
}

