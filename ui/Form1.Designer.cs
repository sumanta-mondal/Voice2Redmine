namespace voice2redmine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IssueTitleRecButton = new System.Windows.Forms.Button();
            this.IssueTitleText = new System.Windows.Forms.TextBox();
            this.IssueTitleRecogniseStatus = new System.Windows.Forms.Panel();
            this.IssueTitleRecogniseBar = new System.Windows.Forms.ProgressBar();
            this.IssueTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // IssueTitleRecButton
            // 
            this.IssueTitleRecButton.Location = new System.Drawing.Point(351, 53);
            this.IssueTitleRecButton.Name = "IssueTitleRecButton";
            this.IssueTitleRecButton.Size = new System.Drawing.Size(75, 23);
            this.IssueTitleRecButton.TabIndex = 5;
            this.IssueTitleRecButton.Text = "Голос";
            this.IssueTitleRecButton.UseVisualStyleBackColor = true;
            this.IssueTitleRecButton.Click += new System.EventHandler(this.IssueTitleRecButton_Click);
            // 
            // IssueTitleText
            // 
            this.IssueTitleText.Location = new System.Drawing.Point(13, 27);
            this.IssueTitleText.Name = "IssueTitleText";
            this.IssueTitleText.Size = new System.Drawing.Size(505, 20);
            this.IssueTitleText.TabIndex = 0;
            // 
            // IssueTitleRecogniseStatus
            // 
            this.IssueTitleRecogniseStatus.Location = new System.Drawing.Point(320, 52);
            this.IssueTitleRecogniseStatus.Name = "IssueTitleRecogniseStatus";
            this.IssueTitleRecogniseStatus.Size = new System.Drawing.Size(25, 24);
            this.IssueTitleRecogniseStatus.TabIndex = 7;
            // 
            // IssueTitleRecogniseBar
            // 
            this.IssueTitleRecogniseBar.Location = new System.Drawing.Point(13, 52);
            this.IssueTitleRecogniseBar.Name = "IssueTitleRecogniseBar";
            this.IssueTitleRecogniseBar.Size = new System.Drawing.Size(301, 23);
            this.IssueTitleRecogniseBar.TabIndex = 9;
            // 
            // IssueTitleLabel
            // 
            this.IssueTitleLabel.AutoSize = true;
            this.IssueTitleLabel.Location = new System.Drawing.Point(2, 9);
            this.IssueTitleLabel.Name = "IssueTitleLabel";
            this.IssueTitleLabel.Size = new System.Drawing.Size(95, 13);
            this.IssueTitleLabel.TabIndex = 12;
            this.IssueTitleLabel.Text = "Название задачи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Описание задачи";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 139);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(301, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(320, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 24);
            this.panel1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Голос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Проект";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Трекер";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(224, 207);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 79);
            this.button2.TabIndex = 4;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(5, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 240);
            this.panel2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 260);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IssueTitleLabel);
            this.Controls.Add(this.IssueTitleRecogniseBar);
            this.Controls.Add(this.IssueTitleRecogniseStatus);
            this.Controls.Add(this.IssueTitleText);
            this.Controls.Add(this.IssueTitleRecButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Создадим задачу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IssueTitleRecButton;
        private System.Windows.Forms.TextBox IssueTitleText;
        private System.Windows.Forms.Panel IssueTitleRecogniseStatus;
        private System.Windows.Forms.ProgressBar IssueTitleRecogniseBar;
        private System.Windows.Forms.Label IssueTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

