namespace Weather
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.latBox = new System.Windows.Forms.TextBox();
            this.lonBox = new System.Windows.Forms.TextBox();
            this.maxtemCheckBox = new System.Windows.Forms.CheckBox();
            this.mintemCheckBox = new System.Windows.Forms.CheckBox();
            this.winspCheckBox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.rainFallParCheckBox = new System.Windows.Forms.CheckBox();
            this.wetherCodeCheckBox = new System.Windows.Forms.CheckBox();
            this.uvCheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.timezoneComboBox = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGS明朝E", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(122, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "☺たくくんのおてんきよほう☺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(14, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "緯度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(14, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "経度";
            // 
            // latBox
            // 
            this.latBox.Location = new System.Drawing.Point(59, 114);
            this.latBox.Margin = new System.Windows.Forms.Padding(2);
            this.latBox.Name = "latBox";
            this.latBox.Size = new System.Drawing.Size(129, 19);
            this.latBox.TabIndex = 3;
            this.latBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lonBox
            // 
            this.lonBox.Location = new System.Drawing.Point(59, 154);
            this.lonBox.Margin = new System.Windows.Forms.Padding(2);
            this.lonBox.Name = "lonBox";
            this.lonBox.Size = new System.Drawing.Size(129, 19);
            this.lonBox.TabIndex = 4;
            this.lonBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maxtemCheckBox
            // 
            this.maxtemCheckBox.AutoSize = true;
            this.maxtemCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxtemCheckBox.Location = new System.Drawing.Point(195, 113);
            this.maxtemCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.maxtemCheckBox.Name = "maxtemCheckBox";
            this.maxtemCheckBox.Size = new System.Drawing.Size(94, 20);
            this.maxtemCheckBox.TabIndex = 8;
            this.maxtemCheckBox.Text = "最高気温";
            this.maxtemCheckBox.UseVisualStyleBackColor = true;
            // 
            // mintemCheckBox
            // 
            this.mintemCheckBox.AutoSize = true;
            this.mintemCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mintemCheckBox.Location = new System.Drawing.Point(195, 154);
            this.mintemCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.mintemCheckBox.Name = "mintemCheckBox";
            this.mintemCheckBox.Size = new System.Drawing.Size(94, 20);
            this.mintemCheckBox.TabIndex = 9;
            this.mintemCheckBox.Text = "最低気温";
            this.mintemCheckBox.UseVisualStyleBackColor = true;
            // 
            // winspCheckBox
            // 
            this.winspCheckBox.AutoSize = true;
            this.winspCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.winspCheckBox.Location = new System.Drawing.Point(291, 113);
            this.winspCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.winspCheckBox.Name = "winspCheckBox";
            this.winspCheckBox.Size = new System.Drawing.Size(60, 20);
            this.winspCheckBox.TabIndex = 10;
            this.winspCheckBox.Text = "風速";
            this.winspCheckBox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(17, 187);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(185, 40);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "実行";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resetButton.Location = new System.Drawing.Point(232, 187);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(104, 41);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "リセット";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // rainFallParCheckBox
            // 
            this.rainFallParCheckBox.AutoSize = true;
            this.rainFallParCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rainFallParCheckBox.Location = new System.Drawing.Point(291, 154);
            this.rainFallParCheckBox.Name = "rainFallParCheckBox";
            this.rainFallParCheckBox.Size = new System.Drawing.Size(94, 20);
            this.rainFallParCheckBox.TabIndex = 13;
            this.rainFallParCheckBox.Text = "降水確率";
            this.rainFallParCheckBox.UseVisualStyleBackColor = true;
            // 
            // wetherCodeCheckBox
            // 
            this.wetherCodeCheckBox.AutoSize = true;
            this.wetherCodeCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.wetherCodeCheckBox.Location = new System.Drawing.Point(392, 154);
            this.wetherCodeCheckBox.Name = "wetherCodeCheckBox";
            this.wetherCodeCheckBox.Size = new System.Drawing.Size(60, 20);
            this.wetherCodeCheckBox.TabIndex = 14;
            this.wetherCodeCheckBox.Text = "天気";
            this.wetherCodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // uvCheckBox
            // 
            this.uvCheckBox.AutoSize = true;
            this.uvCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uvCheckBox.Location = new System.Drawing.Point(392, 116);
            this.uvCheckBox.Name = "uvCheckBox";
            this.uvCheckBox.Size = new System.Drawing.Size(77, 20);
            this.uvCheckBox.TabIndex = 15;
            this.uvCheckBox.Text = "紫外線";
            this.uvCheckBox.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exitButton.Location = new System.Drawing.Point(368, 188);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 40);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "終了";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // timezoneComboBox
            // 
            this.timezoneComboBox.FormattingEnabled = true;
            this.timezoneComboBox.Location = new System.Drawing.Point(331, 72);
            this.timezoneComboBox.Name = "timezoneComboBox";
            this.timezoneComboBox.Size = new System.Drawing.Size(121, 20);
            this.timezoneComboBox.TabIndex = 17;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 333);
            this.Controls.Add(this.timezoneComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.uvCheckBox);
            this.Controls.Add(this.wetherCodeCheckBox);
            this.Controls.Add(this.rainFallParCheckBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.winspCheckBox);
            this.Controls.Add(this.mintemCheckBox);
            this.Controls.Add(this.maxtemCheckBox);
            this.Controls.Add(this.lonBox);
            this.Controls.Add(this.latBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "天気予報";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox latBox;
        private System.Windows.Forms.TextBox lonBox;
        private System.Windows.Forms.CheckBox maxtemCheckBox;
        private System.Windows.Forms.CheckBox mintemCheckBox;
        private System.Windows.Forms.CheckBox winspCheckBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox rainFallParCheckBox;
        private System.Windows.Forms.CheckBox wetherCodeCheckBox;
        private System.Windows.Forms.CheckBox uvCheckBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox timezoneComboBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

