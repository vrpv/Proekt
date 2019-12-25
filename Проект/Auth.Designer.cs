using System.ComponentModel;

namespace Проект
{
    partial class Auth
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Регистрация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.BackColor = System.Drawing.Color.White;
            this.metroTextBox4.CustomBackground = true;
            this.metroTextBox4.CustomForeColor = true;
            this.metroTextBox4.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTextBox4.Location = new System.Drawing.Point(49, 125);
            this.metroTextBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PromptText = "asdsad";
            this.metroTextBox4.Size = new System.Drawing.Size(293, 35);
            this.metroTextBox4.TabIndex = 10;
            this.metroTextBox4.Text = "Пароль";
            this.metroTextBox4.UseStyleColors = true;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.BackColor = System.Drawing.Color.White;
            this.metroTextBox3.CustomBackground = true;
            this.metroTextBox3.CustomForeColor = true;
            this.metroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTextBox3.Location = new System.Drawing.Point(49, 82);
            this.metroTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PromptText = "asdsad";
            this.metroTextBox3.Size = new System.Drawing.Size(293, 35);
            this.metroTextBox3.TabIndex = 9;
            this.metroTextBox3.Text = "Почта";
            this.metroTextBox3.UseStyleColors = true;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.metroTextBox3);
            this.Name = "Auth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public MetroFramework.Controls.MetroTextBox metroTextBox4;
        public MetroFramework.Controls.MetroTextBox metroTextBox3;
    }
}