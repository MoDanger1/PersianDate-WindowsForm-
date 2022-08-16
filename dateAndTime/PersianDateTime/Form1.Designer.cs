namespace PersianDateTime
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
            this.components = new System.ComponentModel.Container();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDayDate = new System.Windows.Forms.Label();
            this.lblMonthDate = new System.Windows.Forms.Label();
            this.lblFullDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.lblDate.Location = new System.Drawing.Point(20, 33);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(243, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "YYYY/MM/DD  HH:MM:SS";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(113, 103);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDayDate
            // 
            this.lblDayDate.AutoSize = true;
            this.lblDayDate.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.lblDayDate.Location = new System.Drawing.Point(183, 158);
            this.lblDayDate.Name = "lblDayDate";
            this.lblDayDate.Size = new System.Drawing.Size(17, 21);
            this.lblDayDate.TabIndex = 0;
            this.lblDayDate.Text = "1";
            this.lblDayDate.Visible = false;
            // 
            // lblMonthDate
            // 
            this.lblMonthDate.AutoSize = true;
            this.lblMonthDate.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.lblMonthDate.Location = new System.Drawing.Point(83, 158);
            this.lblMonthDate.Name = "lblMonthDate";
            this.lblMonthDate.Size = new System.Drawing.Size(17, 21);
            this.lblMonthDate.TabIndex = 0;
            this.lblMonthDate.Text = "2";
            this.lblMonthDate.Visible = false;
            // 
            // lblFullDate
            // 
            this.lblFullDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullDate.BackColor = System.Drawing.Color.Transparent;
            this.lblFullDate.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.lblFullDate.Location = new System.Drawing.Point(0, 0);
            this.lblFullDate.Name = "lblFullDate";
            this.lblFullDate.Size = new System.Drawing.Size(282, 149);
            this.lblFullDate.TabIndex = 0;
            this.lblFullDate.Text = "یکم فروردین";
            this.lblFullDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(282, 149);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMonthDate);
            this.Controls.Add(this.lblDayDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFullDate);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTime";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDayDate;
        private System.Windows.Forms.Label lblMonthDate;
        private System.Windows.Forms.Label lblFullDate;
    }
}

