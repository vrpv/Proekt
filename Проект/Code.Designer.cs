namespace Проект
{
    partial class Code
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
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.BackColor = System.Drawing.Color.White;
            this.metroTextBox5.CustomBackground = true;
            this.metroTextBox5.CustomForeColor = true;
            this.metroTextBox5.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTextBox5.Location = new System.Drawing.Point(72, 75);
            this.metroTextBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PromptText = "asdsad";
            this.metroTextBox5.Size = new System.Drawing.Size(293, 35);
            this.metroTextBox5.TabIndex = 8;
            this.metroTextBox5.Text = "Код";
            this.metroTextBox5.UseStyleColors = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 197);
            this.Controls.Add(this.metroTextBox5);
            this.Controls.Add(this.button1);
            this.Name = "Code";
            this.Text = "Подтверждение регистрации";
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTextBox metroTextBox5;
        private System.Windows.Forms.Button button1;
    }
}