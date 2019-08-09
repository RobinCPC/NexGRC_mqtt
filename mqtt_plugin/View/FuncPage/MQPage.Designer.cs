namespace mqtt_plugin
{
    partial class MQPage
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
            this.components = new System.ComponentModel.Container();
            this.label_ip = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label_port = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.btn_mqtt = new System.Windows.Forms.Button();
            this.textBox_Rec = new System.Windows.Forms.TextBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.mqtt_timer = new System.Windows.Forms.Timer(this.components);
            this.mLb_state = new System.Windows.Forms.Label();
            this.mLb_recive = new System.Windows.Forms.Label();
            this.mBt_Show_demo = new System.Windows.Forms.Button();
            this.mRb_External = new System.Windows.Forms.RadioButton();
            this.mRb_manual = new System.Windows.Forms.RadioButton();
            this.mLb_mode = new System.Windows.Forms.Label();
            this.mBt_reset_color = new System.Windows.Forms.Button();
            this.mLb_Color_index = new System.Windows.Forms.Label();
            this.mLB_facial = new System.Windows.Forms.Label();
            this.textBox_facial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ip.Location = new System.Drawing.Point(29, 17);
            this.label_ip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(116, 27);
            this.label_ip.TabIndex = 0;
            this.label_ip.Text = "Broker_IP:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ip.Location = new System.Drawing.Point(145, 14);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(283, 33);
            this.textBox_ip.TabIndex = 1;
            this.textBox_ip.Text = "broker.hivemq.com";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_port.Location = new System.Drawing.Point(463, 17);
            this.label_port.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(59, 27);
            this.label_port.TabIndex = 2;
            this.label_port.Text = "Port:";
            // 
            // textBox_port
            // 
            this.textBox_port.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_port.Location = new System.Drawing.Point(525, 14);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(84, 33);
            this.textBox_port.TabIndex = 3;
            this.textBox_port.Text = "1883";
            // 
            // btn_mqtt
            // 
            this.btn_mqtt.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mqtt.Location = new System.Drawing.Point(26, 150);
            this.btn_mqtt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mqtt.Name = "btn_mqtt";
            this.btn_mqtt.Size = new System.Drawing.Size(163, 43);
            this.btn_mqtt.TabIndex = 4;
            this.btn_mqtt.Text = "Connect MQTT";
            this.btn_mqtt.UseVisualStyleBackColor = true;
            this.btn_mqtt.Click += new System.EventHandler(this.btn_mqtt_Click);
            // 
            // textBox_Rec
            // 
            this.textBox_Rec.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Rec.Location = new System.Drawing.Point(26, 286);
            this.textBox_Rec.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Rec.Name = "textBox_Rec";
            this.textBox_Rec.Size = new System.Drawing.Size(623, 33);
            this.textBox_Rec.TabIndex = 7;
            this.textBox_Rec.Text = "0";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disconnect.Location = new System.Drawing.Point(228, 150);
            this.btn_disconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(163, 43);
            this.btn_disconnect.TabIndex = 8;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // mqtt_timer
            // 
            this.mqtt_timer.Interval = 500;
            this.mqtt_timer.Tick += new System.EventHandler(this.mqtt_timer_Tick);
            // 
            // mLb_state
            // 
            this.mLb_state.AutoSize = true;
            this.mLb_state.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLb_state.Location = new System.Drawing.Point(29, 105);
            this.mLb_state.Name = "mLb_state";
            this.mLb_state.Size = new System.Drawing.Size(81, 25);
            this.mLb_state.TabIndex = 9;
            this.mLb_state.Text = "State : ";
            // 
            // mLb_recive
            // 
            this.mLb_recive.AutoSize = true;
            this.mLb_recive.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLb_recive.Location = new System.Drawing.Point(29, 246);
            this.mLb_recive.Name = "mLb_recive";
            this.mLb_recive.Size = new System.Drawing.Size(143, 25);
            this.mLb_recive.TabIndex = 10;
            this.mLb_recive.Text = "Recive Data : ";
            // 
            // mBt_Show_demo
            // 
            this.mBt_Show_demo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mBt_Show_demo.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBt_Show_demo.Location = new System.Drawing.Point(578, 536);
            this.mBt_Show_demo.Margin = new System.Windows.Forms.Padding(2);
            this.mBt_Show_demo.Name = "mBt_Show_demo";
            this.mBt_Show_demo.Size = new System.Drawing.Size(211, 43);
            this.mBt_Show_demo.TabIndex = 12;
            this.mBt_Show_demo.Text = "Show Demo Page";
            this.mBt_Show_demo.UseVisualStyleBackColor = true;
            this.mBt_Show_demo.Click += new System.EventHandler(this.mBt_Show_demo_Click);
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
            this.mRb_External.Location = new System.Drawing.Point(288, 369);
            this.mRb_External.Name = "mRb_External";
            this.mRb_External.Size = new System.Drawing.Size(140, 49);
            this.mRb_External.TabIndex = 29;
            this.mRb_External.Text = "External";
            this.mRb_External.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mRb_External.UseVisualStyleBackColor = false;
            this.mRb_External.CheckedChanged += new System.EventHandler(this.mRb_External_CheckedChanged);
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
            this.mRb_manual.Location = new System.Drawing.Point(140, 369);
            this.mRb_manual.Name = "mRb_manual";
            this.mRb_manual.Size = new System.Drawing.Size(140, 49);
            this.mRb_manual.TabIndex = 28;
            this.mRb_manual.TabStop = true;
            this.mRb_manual.Text = "Manual";
            this.mRb_manual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mRb_manual.UseVisualStyleBackColor = false;
            this.mRb_manual.CheckedChanged += new System.EventHandler(this.mRb_manual_CheckedChanged);
            // 
            // mLb_mode
            // 
            this.mLb_mode.AutoSize = true;
            this.mLb_mode.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLb_mode.Location = new System.Drawing.Point(28, 376);
            this.mLb_mode.Name = "mLb_mode";
            this.mLb_mode.Size = new System.Drawing.Size(106, 33);
            this.mLb_mode.TabIndex = 27;
            this.mLb_mode.Text = "Mode : ";
            // 
            // mBt_reset_color
            // 
            this.mBt_reset_color.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBt_reset_color.Location = new System.Drawing.Point(26, 522);
            this.mBt_reset_color.Margin = new System.Windows.Forms.Padding(2);
            this.mBt_reset_color.Name = "mBt_reset_color";
            this.mBt_reset_color.Size = new System.Drawing.Size(211, 43);
            this.mBt_reset_color.TabIndex = 30;
            this.mBt_reset_color.Text = "Reset Color Index";
            this.mBt_reset_color.UseVisualStyleBackColor = true;
            this.mBt_reset_color.Click += new System.EventHandler(this.mBt_reset_color_Click);
            // 
            // mLb_Color_index
            // 
            this.mLb_Color_index.AutoSize = true;
            this.mLb_Color_index.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLb_Color_index.Location = new System.Drawing.Point(28, 475);
            this.mLb_Color_index.Name = "mLb_Color_index";
            this.mLb_Color_index.Size = new System.Drawing.Size(178, 33);
            this.mLb_Color_index.TabIndex = 31;
            this.mLb_Color_index.Text = "Color Index : ";
            // 
            // mLB_facial
            // 
            this.mLB_facial.AutoSize = true;
            this.mLB_facial.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLB_facial.Location = new System.Drawing.Point(283, 483);
            this.mLB_facial.Name = "mLB_facial";
            this.mLB_facial.Size = new System.Drawing.Size(146, 25);
            this.mLB_facial.TabIndex = 32;
            this.mLB_facial.Text = "Facial Index : ";
            // 
            // textBox_facial
            // 
            this.textBox_facial.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_facial.Location = new System.Drawing.Point(288, 522);
            this.textBox_facial.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_facial.Name = "textBox_facial";
            this.textBox_facial.Size = new System.Drawing.Size(181, 33);
            this.textBox_facial.TabIndex = 33;
            this.textBox_facial.Text = "-1";
            // 
            // MQPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_facial);
            this.Controls.Add(this.mLB_facial);
            this.Controls.Add(this.mLb_Color_index);
            this.Controls.Add(this.mBt_reset_color);
            this.Controls.Add(this.mRb_External);
            this.Controls.Add(this.mRb_manual);
            this.Controls.Add(this.mLb_mode);
            this.Controls.Add(this.mBt_Show_demo);
            this.Controls.Add(this.mLb_recive);
            this.Controls.Add(this.mLb_state);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.textBox_Rec);
            this.Controls.Add(this.btn_mqtt);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label_ip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MQPage";
            this.Size = new System.Drawing.Size(807, 597);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button btn_mqtt;
        private System.Windows.Forms.TextBox textBox_Rec;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Timer mqtt_timer;
        private System.Windows.Forms.Label mLb_state;
        private System.Windows.Forms.Label mLb_recive;
        private System.Windows.Forms.Button mBt_Show_demo;
        private System.Windows.Forms.RadioButton mRb_External;
        private System.Windows.Forms.RadioButton mRb_manual;
        private System.Windows.Forms.Label mLb_mode;
        private System.Windows.Forms.Button mBt_reset_color;
        private System.Windows.Forms.Label mLb_Color_index;
        private System.Windows.Forms.Label mLB_facial;
        private System.Windows.Forms.TextBox textBox_facial;
    }
}
