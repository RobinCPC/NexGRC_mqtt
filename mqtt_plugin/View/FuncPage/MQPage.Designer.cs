namespace mqtt_plugin.View.FuncPage
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
            this.timer_mqtt = new System.Windows.Forms.Timer(this.components);
            this.textBox_sec = new System.Windows.Forms.TextBox();
            this.label_sec = new System.Windows.Forms.Label();
            this.textBox_Rec = new System.Windows.Forms.TextBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.label_wait = new System.Windows.Forms.Label();
            this.textBox_wait = new System.Windows.Forms.TextBox();
            this.btn_UdPnt = new System.Windows.Forms.Button();
            this.textBox_LED = new System.Windows.Forms.TextBox();
            this.label_LED = new System.Windows.Forms.Label();
            this.timer_wait_cloud_cmd = new System.Windows.Forms.Timer(this.components);
            this.mLB_state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ip.Location = new System.Drawing.Point(43, 28);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(168, 39);
            this.label_ip.TabIndex = 0;
            this.label_ip.Text = "Broker_IP:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ip.Location = new System.Drawing.Point(217, 24);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(423, 46);
            this.textBox_ip.TabIndex = 1;
            this.textBox_ip.Text = "127.0.0.1";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_port.Location = new System.Drawing.Point(695, 28);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(86, 39);
            this.label_port.TabIndex = 2;
            this.label_port.Text = "Port:";
            // 
            // textBox_port
            // 
            this.textBox_port.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_port.Location = new System.Drawing.Point(787, 24);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(124, 46);
            this.textBox_port.TabIndex = 3;
            this.textBox_port.Text = "1883";
            // 
            // btn_mqtt
            // 
            this.btn_mqtt.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mqtt.Location = new System.Drawing.Point(50, 194);
            this.btn_mqtt.Name = "btn_mqtt";
            this.btn_mqtt.Size = new System.Drawing.Size(244, 67);
            this.btn_mqtt.TabIndex = 4;
            this.btn_mqtt.Text = "Connect MQTT";
            this.btn_mqtt.UseVisualStyleBackColor = true;
            this.btn_mqtt.Click += new System.EventHandler(this.btn_mqtt_Click);
            // 
            // timer_mqtt
            // 
            this.timer_mqtt.Interval = 1000;
            this.timer_mqtt.Tick += new System.EventHandler(this.timer_mqtt_Tick);
            // 
            // textBox_sec
            // 
            this.textBox_sec.Enabled = false;
            this.textBox_sec.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sec.Location = new System.Drawing.Point(330, 282);
            this.textBox_sec.Name = "textBox_sec";
            this.textBox_sec.Size = new System.Drawing.Size(124, 46);
            this.textBox_sec.TabIndex = 6;
            this.textBox_sec.Text = "5";
            this.textBox_sec.Visible = false;
            // 
            // label_sec
            // 
            this.label_sec.AutoSize = true;
            this.label_sec.Enabled = false;
            this.label_sec.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sec.Location = new System.Drawing.Point(53, 285);
            this.label_sec.Name = "label_sec";
            this.label_sec.Size = new System.Drawing.Size(247, 39);
            this.label_sec.TabIndex = 5;
            this.label_sec.Text = "Set Count (sec):";
            this.label_sec.Visible = false;
            // 
            // textBox_Rec
            // 
            this.textBox_Rec.Enabled = false;
            this.textBox_Rec.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Rec.Location = new System.Drawing.Point(41, 506);
            this.textBox_Rec.Name = "textBox_Rec";
            this.textBox_Rec.Size = new System.Drawing.Size(933, 46);
            this.textBox_Rec.TabIndex = 7;
            this.textBox_Rec.Text = "0";
            this.textBox_Rec.Visible = false;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disconnect.Location = new System.Drawing.Point(396, 194);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(244, 67);
            this.btn_disconnect.TabIndex = 8;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // label_wait
            // 
            this.label_wait.AutoSize = true;
            this.label_wait.Enabled = false;
            this.label_wait.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wait.Location = new System.Drawing.Point(53, 337);
            this.label_wait.Name = "label_wait";
            this.label_wait.Size = new System.Drawing.Size(172, 39);
            this.label_wait.TabIndex = 9;
            this.label_wait.Text = "Wait (sec):";
            this.label_wait.Visible = false;
            // 
            // textBox_wait
            // 
            this.textBox_wait.Enabled = false;
            this.textBox_wait.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_wait.Location = new System.Drawing.Point(330, 334);
            this.textBox_wait.Name = "textBox_wait";
            this.textBox_wait.ReadOnly = true;
            this.textBox_wait.Size = new System.Drawing.Size(124, 46);
            this.textBox_wait.TabIndex = 10;
            this.textBox_wait.Text = "0";
            this.textBox_wait.Visible = false;
            // 
            // btn_UdPnt
            // 
            this.btn_UdPnt.Enabled = false;
            this.btn_UdPnt.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UdPnt.Location = new System.Drawing.Point(537, 282);
            this.btn_UdPnt.Name = "btn_UdPnt";
            this.btn_UdPnt.Size = new System.Drawing.Size(437, 67);
            this.btn_UdPnt.TabIndex = 11;
            this.btn_UdPnt.Text = "Run GetUdPnt";
            this.btn_UdPnt.UseVisualStyleBackColor = true;
            this.btn_UdPnt.Visible = false;
            this.btn_UdPnt.Click += new System.EventHandler(this.btn_UdPnt_Click);
            // 
            // textBox_LED
            // 
            this.textBox_LED.Enabled = false;
            this.textBox_LED.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LED.Location = new System.Drawing.Point(739, 380);
            this.textBox_LED.Name = "textBox_LED";
            this.textBox_LED.ReadOnly = true;
            this.textBox_LED.Size = new System.Drawing.Size(172, 46);
            this.textBox_LED.TabIndex = 13;
            this.textBox_LED.Text = "Default";
            this.textBox_LED.Visible = false;
            // 
            // label_LED
            // 
            this.label_LED.AutoSize = true;
            this.label_LED.Enabled = false;
            this.label_LED.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LED.Location = new System.Drawing.Point(540, 383);
            this.label_LED.Name = "label_LED";
            this.label_LED.Size = new System.Drawing.Size(166, 39);
            this.label_LED.TabIndex = 12;
            this.label_LED.Text = "LED Color:";
            this.label_LED.Visible = false;
            // 
            // timer_wait_cloud_cmd
            // 
            this.timer_wait_cloud_cmd.Interval = 1000;
            this.timer_wait_cloud_cmd.Tick += new System.EventHandler(this.timer_wait_cloud_cmd_Tick);
            // 
            // mLB_state
            // 
            this.mLB_state.AutoSize = true;
            this.mLB_state.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLB_state.Location = new System.Drawing.Point(53, 129);
            this.mLB_state.Name = "mLB_state";
            this.mLB_state.Size = new System.Drawing.Size(102, 39);
            this.mLB_state.TabIndex = 14;
            this.mLB_state.Text = "State:";
            // 
            // MQPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mLB_state);
            this.Controls.Add(this.textBox_LED);
            this.Controls.Add(this.label_LED);
            this.Controls.Add(this.btn_UdPnt);
            this.Controls.Add(this.textBox_wait);
            this.Controls.Add(this.label_wait);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.textBox_Rec);
            this.Controls.Add(this.textBox_sec);
            this.Controls.Add(this.label_sec);
            this.Controls.Add(this.btn_mqtt);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label_ip);
            this.Name = "MQPage";
            this.Size = new System.Drawing.Size(1211, 619);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button btn_mqtt;
        private System.Windows.Forms.Timer timer_mqtt;
        private System.Windows.Forms.TextBox textBox_sec;
        private System.Windows.Forms.Label label_sec;
        private System.Windows.Forms.TextBox textBox_Rec;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Label label_wait;
        private System.Windows.Forms.TextBox textBox_wait;
        private System.Windows.Forms.Button btn_UdPnt;
        private System.Windows.Forms.TextBox textBox_LED;
        private System.Windows.Forms.Label label_LED;
        private System.Windows.Forms.Timer timer_wait_cloud_cmd;
        private System.Windows.Forms.Label mLB_state;
    }
}
