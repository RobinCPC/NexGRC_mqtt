namespace mqtt_plugin
{
    partial class DemoPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mBt_back = new System.Windows.Forms.Button();
            this.mLb_mode = new System.Windows.Forms.Label();
            this.mRb_manual = new System.Windows.Forms.RadioButton();
            this.mRb_External = new System.Windows.Forms.RadioButton();
            this.mBt_red = new System.Windows.Forms.Button();
            this.mBt_green = new System.Windows.Forms.Button();
            this.mBt_blue = new System.Windows.Forms.Button();
            this.mBt_yellow = new System.Windows.Forms.Button();
            this.mLb_msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mBt_back
            // 
            this.mBt_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mBt_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mBt_back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mBt_back.FlatAppearance.BorderSize = 2;
            this.mBt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mBt_back.Location = new System.Drawing.Point(878, 595);
            this.mBt_back.Name = "mBt_back";
            this.mBt_back.Size = new System.Drawing.Size(103, 46);
            this.mBt_back.TabIndex = 0;
            this.mBt_back.Text = "Back";
            this.mBt_back.UseVisualStyleBackColor = false;
            this.mBt_back.Click += new System.EventHandler(this.mBt_back_Click);
            // 
            // mLb_mode
            // 
            this.mLb_mode.AutoSize = true;
            this.mLb_mode.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLb_mode.Location = new System.Drawing.Point(31, 28);
            this.mLb_mode.Name = "mLb_mode";
            this.mLb_mode.Size = new System.Drawing.Size(106, 33);
            this.mLb_mode.TabIndex = 10;
            this.mLb_mode.Text = "Mode : ";
            // 
            // mRb_manual
            // 
            this.mRb_manual.Appearance = System.Windows.Forms.Appearance.Button;
            this.mRb_manual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(212)))), ((int)(((byte)(207)))));
            this.mRb_manual.Checked = true;
            this.mRb_manual.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mRb_manual.FlatAppearance.BorderSize = 2;
            this.mRb_manual.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(138)))), ((int)(((byte)(130)))));
            this.mRb_manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mRb_manual.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mRb_manual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.mRb_manual.Location = new System.Drawing.Point(135, 22);
            this.mRb_manual.Name = "mRb_manual";
            this.mRb_manual.Size = new System.Drawing.Size(140, 45);
            this.mRb_manual.TabIndex = 25;
            this.mRb_manual.TabStop = true;
            this.mRb_manual.Text = "Manual";
            this.mRb_manual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mRb_manual.UseVisualStyleBackColor = false;
            this.mRb_manual.CheckedChanged += new System.EventHandler(this.mRb_manual_CheckedChanged);
            // 
            // mRb_External
            // 
            this.mRb_External.Appearance = System.Windows.Forms.Appearance.Button;
            this.mRb_External.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(212)))), ((int)(((byte)(207)))));
            this.mRb_External.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mRb_External.FlatAppearance.BorderSize = 2;
            this.mRb_External.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(138)))), ((int)(((byte)(130)))));
            this.mRb_External.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mRb_External.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mRb_External.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.mRb_External.Location = new System.Drawing.Point(281, 22);
            this.mRb_External.Name = "mRb_External";
            this.mRb_External.Size = new System.Drawing.Size(140, 45);
            this.mRb_External.TabIndex = 26;
            this.mRb_External.Text = "External";
            this.mRb_External.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mRb_External.UseVisualStyleBackColor = false;
            this.mRb_External.CheckedChanged += new System.EventHandler(this.mRb_External_CheckedChanged);
            // 
            // mBt_red
            // 
            this.mBt_red.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mBt_red.BackColor = System.Drawing.Color.Red;
            this.mBt_red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mBt_red.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mBt_red.FlatAppearance.BorderSize = 2;
            this.mBt_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mBt_red.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBt_red.ForeColor = System.Drawing.Color.White;
            this.mBt_red.Location = new System.Drawing.Point(265, 148);
            this.mBt_red.Name = "mBt_red";
            this.mBt_red.Size = new System.Drawing.Size(200, 200);
            this.mBt_red.TabIndex = 27;
            this.mBt_red.Text = "Red";
            this.mBt_red.UseVisualStyleBackColor = false;
            this.mBt_red.Click += new System.EventHandler(this.mBt_red_Click);
            // 
            // mBt_green
            // 
            this.mBt_green.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mBt_green.BackColor = System.Drawing.Color.Green;
            this.mBt_green.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mBt_green.FlatAppearance.BorderSize = 2;
            this.mBt_green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mBt_green.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBt_green.ForeColor = System.Drawing.Color.White;
            this.mBt_green.Location = new System.Drawing.Point(487, 148);
            this.mBt_green.Name = "mBt_green";
            this.mBt_green.Size = new System.Drawing.Size(200, 200);
            this.mBt_green.TabIndex = 28;
            this.mBt_green.Text = "Green";
            this.mBt_green.UseVisualStyleBackColor = false;
            this.mBt_green.Click += new System.EventHandler(this.mBt_green_Click);
            // 
            // mBt_blue
            // 
            this.mBt_blue.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mBt_blue.BackColor = System.Drawing.Color.Blue;
            this.mBt_blue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mBt_blue.FlatAppearance.BorderSize = 2;
            this.mBt_blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mBt_blue.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBt_blue.ForeColor = System.Drawing.Color.White;
            this.mBt_blue.Location = new System.Drawing.Point(265, 379);
            this.mBt_blue.Name = "mBt_blue";
            this.mBt_blue.Size = new System.Drawing.Size(200, 200);
            this.mBt_blue.TabIndex = 29;
            this.mBt_blue.Text = "Blue";
            this.mBt_blue.UseVisualStyleBackColor = false;
            this.mBt_blue.Click += new System.EventHandler(this.mBt_blue_Click);
            // 
            // mBt_yellow
            // 
            this.mBt_yellow.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mBt_yellow.BackColor = System.Drawing.Color.Yellow;
            this.mBt_yellow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mBt_yellow.FlatAppearance.BorderSize = 2;
            this.mBt_yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mBt_yellow.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBt_yellow.ForeColor = System.Drawing.Color.Black;
            this.mBt_yellow.Location = new System.Drawing.Point(487, 379);
            this.mBt_yellow.Name = "mBt_yellow";
            this.mBt_yellow.Size = new System.Drawing.Size(200, 200);
            this.mBt_yellow.TabIndex = 30;
            this.mBt_yellow.Text = "Yellow";
            this.mBt_yellow.UseVisualStyleBackColor = false;
            this.mBt_yellow.Click += new System.EventHandler(this.mBt_yellow_Click);
            // 
            // mLb_msg
            // 
            this.mLb_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mLb_msg.AutoSize = true;
            this.mLb_msg.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLb_msg.Location = new System.Drawing.Point(31, 608);
            this.mLb_msg.Name = "mLb_msg";
            this.mLb_msg.Size = new System.Drawing.Size(97, 33);
            this.mLb_msg.TabIndex = 31;
            this.mLb_msg.Text = "Msg  : ";
            // 
            // DemoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(212)))), ((int)(((byte)(207)))));
            this.Controls.Add(this.mLb_msg);
            this.Controls.Add(this.mBt_yellow);
            this.Controls.Add(this.mBt_blue);
            this.Controls.Add(this.mBt_green);
            this.Controls.Add(this.mBt_red);
            this.Controls.Add(this.mRb_External);
            this.Controls.Add(this.mRb_manual);
            this.Controls.Add(this.mLb_mode);
            this.Controls.Add(this.mBt_back);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DemoPanel";
            this.Size = new System.Drawing.Size(1000, 663);
            this.Load += new System.EventHandler(this.DemoPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mBt_back;
        private System.Windows.Forms.Label mLb_mode;
        private System.Windows.Forms.RadioButton mRb_manual;
        private System.Windows.Forms.RadioButton mRb_External;
        private System.Windows.Forms.Button mBt_red;
        private System.Windows.Forms.Button mBt_green;
        private System.Windows.Forms.Button mBt_blue;
        private System.Windows.Forms.Button mBt_yellow;
        private System.Windows.Forms.Label mLb_msg;
    }
}
