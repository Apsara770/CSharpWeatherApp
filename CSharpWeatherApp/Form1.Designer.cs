using System.Drawing;
using System.Windows.Forms;

namespace CSharpWeatherApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.PictureBox pictureBoxWeather;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtHum = new System.Windows.Forms.TextBox();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.pictureBoxWeather = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxCity.Location = new System.Drawing.Point(30, 60);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(200, 25);
            this.textBoxCity.TabIndex = 1;
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGetWeather.FlatAppearance.BorderSize = 0;
            this.btnGetWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetWeather.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGetWeather.ForeColor = System.Drawing.Color.White;
            this.btnGetWeather.Location = new System.Drawing.Point(240, 55);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(140, 40);
            this.btnGetWeather.TabIndex = 2;
            this.btnGetWeather.Text = "Get Weather";
            this.btnGetWeather.UseVisualStyleBackColor = false;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(100, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🌤 Weather App";
            // 
            // txtTemp
            // 
            this.txtTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTemp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtTemp.ForeColor = System.Drawing.Color.Black;
            this.txtTemp.Location = new System.Drawing.Point(30, 110);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.txtTemp.Size = new System.Drawing.Size(180, 32);
            this.txtTemp.TabIndex = 3;
            this.txtTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCon
            // 
            this.txtCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCon.Location = new System.Drawing.Point(30, 150);
            this.txtCon.Name = "txtCon";
            this.txtCon.ReadOnly = true;
            this.txtCon.Size = new System.Drawing.Size(180, 29);
            this.txtCon.TabIndex = 4;
            this.txtCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHum
            // 
            this.txtHum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtHum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHum.Location = new System.Drawing.Point(30, 190);
            this.txtHum.Name = "txtHum";
            this.txtHum.ReadOnly = true;
            this.txtHum.Size = new System.Drawing.Size(180, 29);
            this.txtHum.TabIndex = 5;
            this.txtHum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWind
            // 
            this.txtWind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtWind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtWind.Location = new System.Drawing.Point(30, 230);
            this.txtWind.Name = "txtWind";
            this.txtWind.ReadOnly = true;
            this.txtWind.Size = new System.Drawing.Size(180, 29);
            this.txtWind.TabIndex = 6;
            this.txtWind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.Location = new System.Drawing.Point(240, 110);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeather.TabIndex = 7;
            this.pictureBoxWeather.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(420, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.txtHum);
            this.Controls.Add(this.txtWind);
            this.Controls.Add(this.pictureBoxWeather);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.TextBox txtHum;
        private System.Windows.Forms.TextBox txtWind;
    }
}