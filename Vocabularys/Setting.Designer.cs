namespace Vocabularys
{
    partial class Setting
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
            this.ChineseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EnglishNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChineseNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnglishNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ChineseNumericUpDown
            // 
            this.ChineseNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChineseNumericUpDown.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChineseNumericUpDown.Location = new System.Drawing.Point(468, 48);
            this.ChineseNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChineseNumericUpDown.Name = "ChineseNumericUpDown";
            this.ChineseNumericUpDown.Size = new System.Drawing.Size(120, 49);
            this.ChineseNumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time of show Chinese:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time of show English:";
            // 
            // EnglishNumericUpDown
            // 
            this.EnglishNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnglishNumericUpDown.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EnglishNumericUpDown.Location = new System.Drawing.Point(468, 152);
            this.EnglishNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnglishNumericUpDown.Name = "EnglishNumericUpDown";
            this.EnglishNumericUpDown.Size = new System.Drawing.Size(120, 58);
            this.EnglishNumericUpDown.TabIndex = 3;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(22, 264);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(160, 60);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 344);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.EnglishNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChineseNumericUpDown);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.ChineseNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnglishNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ChineseNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown EnglishNumericUpDown;
        private System.Windows.Forms.Button OKButton;
    }
}