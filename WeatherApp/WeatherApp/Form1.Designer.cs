
namespace WeatherApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_close = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lab_condition = new System.Windows.Forms.Label();
            this.lab_detail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_sunset = new System.Windows.Forms.Label();
            this.lab_sunrise = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_pressure = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lab_windspeend = new System.Windows.Forms.Label();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_close.Location = new System.Drawing.Point(370, 19);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "City";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(258, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_condition
            // 
            this.lab_condition.AutoSize = true;
            this.lab_condition.BackColor = System.Drawing.Color.Transparent;
            this.lab_condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lab_condition.ForeColor = System.Drawing.Color.White;
            this.lab_condition.Location = new System.Drawing.Point(21, 141);
            this.lab_condition.Name = "lab_condition";
            this.lab_condition.Size = new System.Drawing.Size(51, 13);
            this.lab_condition.TabIndex = 4;
            this.lab_condition.Text = "Condition";
            // 
            // lab_detail
            // 
            this.lab_detail.AutoSize = true;
            this.lab_detail.BackColor = System.Drawing.Color.Transparent;
            this.lab_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lab_detail.ForeColor = System.Drawing.Color.White;
            this.lab_detail.Location = new System.Drawing.Point(21, 169);
            this.lab_detail.Name = "lab_detail";
            this.lab_detail.Size = new System.Drawing.Size(34, 13);
            this.lab_detail.TabIndex = 5;
            this.lab_detail.Text = "Detail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sunrise";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sunset";
            // 
            // lab_sunset
            // 
            this.lab_sunset.AutoSize = true;
            this.lab_sunset.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lab_sunset.ForeColor = System.Drawing.Color.White;
            this.lab_sunset.Location = new System.Drawing.Point(125, 225);
            this.lab_sunset.Name = "lab_sunset";
            this.lab_sunset.Size = new System.Drawing.Size(27, 13);
            this.lab_sunset.TabIndex = 8;
            this.lab_sunset.Text = "N/A";
            // 
            // lab_sunrise
            // 
            this.lab_sunrise.AutoSize = true;
            this.lab_sunrise.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lab_sunrise.ForeColor = System.Drawing.Color.White;
            this.lab_sunrise.Location = new System.Drawing.Point(125, 196);
            this.lab_sunrise.Name = "lab_sunrise";
            this.lab_sunrise.Size = new System.Drawing.Size(27, 13);
            this.lab_sunrise.TabIndex = 9;
            this.lab_sunrise.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pressure";
            // 
            // lab_pressure
            // 
            this.lab_pressure.AutoSize = true;
            this.lab_pressure.BackColor = System.Drawing.Color.Transparent;
            this.lab_pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lab_pressure.ForeColor = System.Drawing.Color.White;
            this.lab_pressure.Location = new System.Drawing.Point(125, 279);
            this.lab_pressure.Name = "lab_pressure";
            this.lab_pressure.Size = new System.Drawing.Size(27, 13);
            this.lab_pressure.TabIndex = 11;
            this.lab_pressure.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Wind Speend";
            // 
            // lab_windspeend
            // 
            this.lab_windspeend.AutoSize = true;
            this.lab_windspeend.BackColor = System.Drawing.Color.Transparent;
            this.lab_windspeend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lab_windspeend.ForeColor = System.Drawing.Color.White;
            this.lab_windspeend.Location = new System.Drawing.Point(125, 251);
            this.lab_windspeend.Name = "lab_windspeend";
            this.lab_windspeend.Size = new System.Drawing.Size(27, 13);
            this.lab_windspeend.TabIndex = 13;
            this.lab_windspeend.Text = "N/A";
            // 
            // pic_icon
            // 
            this.pic_icon.BackColor = System.Drawing.Color.Transparent;
            this.pic_icon.Location = new System.Drawing.Point(24, 71);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(100, 50);
            this.pic_icon.TabIndex = 14;
            this.pic_icon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 316);
            this.Controls.Add(this.pic_icon);
            this.Controls.Add(this.lab_windspeend);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lab_pressure);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lab_sunrise);
            this.Controls.Add(this.lab_sunset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_detail);
            this.Controls.Add(this.lab_condition);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab_condition;
        private System.Windows.Forms.Label lab_detail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_sunset;
        private System.Windows.Forms.Label lab_sunrise;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_pressure;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lab_windspeend;
        private System.Windows.Forms.PictureBox pic_icon;
    }
}

