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
            this.textBox_ip.Text = "broker.hivemq.com";
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
            this.btn_mqtt.Location = new System.Drawing.Point(50, 116);
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
            // MQPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
