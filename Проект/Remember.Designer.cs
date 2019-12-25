using System.ComponentModel;

namespace Проект
{
    partial class Remember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Восстановить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.BackColor = System.Drawing.Color.White;
            this.metroTextBox3.CustomBackground = true;
            this.metroTextBox3.CustomForeColor = true;
            this.metroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTextBox3.Location = new System.Drawing.Point(47, 84);
            this.metroTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PromptText = "asdsad";
            this.metroTextBox3.Size = new System.Drawing.Size(293, 35);
            this.metroTextBox3.TabIndex = 12;
            this.metroTextBox3.Text = "Почта";
            this.metroTextBox3.UseStyleColors = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Remember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroTextBox3);
            this.Name = "Remember";
            this.Text = "Восстановление пароля";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public MetroFramework.Controls.MetroTextBox metroTextBox3;
        private System.Windows.Forms.Button button2;
    }
}