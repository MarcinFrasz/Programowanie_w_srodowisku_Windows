namespace Programowanie_w_srodowisku_Windows
{
    partial class Form1_serial_port_communication
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1_com_ports = new System.Windows.Forms.ComboBox();
            this.button_send_reset = new System.Windows.Forms.Button();
            this.richTextBox_text_to_send = new System.Windows.Forms.RichTextBox();
            this.button_send_text = new System.Windows.Forms.Button();
            this.groupbox_mode = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_open_com = new System.Windows.Forms.Button();
            this.button_com_close = new System.Windows.Forms.Button();
            this.radioButton_DL = new System.Windows.Forms.RadioButton();
            this.radioButton_PHY = new System.Windows.Forms.RadioButton();
            this.radioButton_BPSK = new System.Windows.Forms.RadioButton();
            this.radioButton_QPSK = new System.Windows.Forms.RadioButton();
            this.radioButton_8PSK = new System.Windows.Forms.RadioButton();
            this.checkBox_FEC = new System.Windows.Forms.CheckBox();
            this.groupbox_mode.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1_com_ports
            // 
            this.comboBox1_com_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_com_ports.FormattingEnabled = true;
            this.comboBox1_com_ports.Location = new System.Drawing.Point(32, 13);
            this.comboBox1_com_ports.Name = "comboBox1_com_ports";
            this.comboBox1_com_ports.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_com_ports.TabIndex = 0;
            this.comboBox1_com_ports.SelectedIndexChanged += new System.EventHandler(this.comboBox1_com_ports_SelectedIndexChanged);
            // 
            // button_send_reset
            // 
            this.button_send_reset.Location = new System.Drawing.Point(170, 11);
            this.button_send_reset.Name = "button_send_reset";
            this.button_send_reset.Size = new System.Drawing.Size(112, 23);
            this.button_send_reset.TabIndex = 1;
            this.button_send_reset.Text = "SEND RESET";
            this.button_send_reset.UseVisualStyleBackColor = true;
            this.button_send_reset.Click += new System.EventHandler(this.button_send_reset_Click);
            // 
            // richTextBox_text_to_send
            // 
            this.richTextBox_text_to_send.Location = new System.Drawing.Point(337, 13);
            this.richTextBox_text_to_send.Name = "richTextBox_text_to_send";
            this.richTextBox_text_to_send.Size = new System.Drawing.Size(309, 121);
            this.richTextBox_text_to_send.TabIndex = 2;
            this.richTextBox_text_to_send.Text = "";
            // 
            // button_send_text
            // 
            this.button_send_text.Location = new System.Drawing.Point(352, 140);
            this.button_send_text.Name = "button_send_text";
            this.button_send_text.Size = new System.Drawing.Size(129, 23);
            this.button_send_text.TabIndex = 3;
            this.button_send_text.Text = "SEND TEXT";
            this.button_send_text.UseVisualStyleBackColor = true;
            // 
            // groupbox_mode
            // 
            this.groupbox_mode.Controls.Add(this.radioButton_PHY);
            this.groupbox_mode.Controls.Add(this.radioButton_DL);
            this.groupbox_mode.Location = new System.Drawing.Point(32, 81);
            this.groupbox_mode.Name = "groupbox_mode";
            this.groupbox_mode.Size = new System.Drawing.Size(121, 100);
            this.groupbox_mode.TabIndex = 4;
            this.groupbox_mode.TabStop = false;
            this.groupbox_mode.Text = "MODE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_FEC);
            this.groupBox2.Controls.Add(this.radioButton_8PSK);
            this.groupBox2.Controls.Add(this.radioButton_QPSK);
            this.groupBox2.Controls.Add(this.radioButton_BPSK);
            this.groupBox2.Location = new System.Drawing.Point(179, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 105);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // button_open_com
            // 
            this.button_open_com.Location = new System.Drawing.Point(32, 41);
            this.button_open_com.Name = "button_open_com";
            this.button_open_com.Size = new System.Drawing.Size(75, 23);
            this.button_open_com.TabIndex = 6;
            this.button_open_com.Text = "COM OPEN";
            this.button_open_com.UseVisualStyleBackColor = true;
            this.button_open_com.Click += new System.EventHandler(this.button_open_com_Click);
            // 
            // button_com_close
            // 
            this.button_com_close.Location = new System.Drawing.Point(123, 41);
            this.button_com_close.Name = "button_com_close";
            this.button_com_close.Size = new System.Drawing.Size(85, 23);
            this.button_com_close.TabIndex = 7;
            this.button_com_close.Text = "COM CLOSE";
            this.button_com_close.UseVisualStyleBackColor = true;
            this.button_com_close.Click += new System.EventHandler(this.button_com_close_Click);
            // 
            // radioButton_DL
            // 
            this.radioButton_DL.AutoSize = true;
            this.radioButton_DL.Location = new System.Drawing.Point(0, 20);
            this.radioButton_DL.Name = "radioButton_DL";
            this.radioButton_DL.Size = new System.Drawing.Size(39, 17);
            this.radioButton_DL.TabIndex = 0;
            this.radioButton_DL.TabStop = true;
            this.radioButton_DL.Text = "DL";
            this.radioButton_DL.UseVisualStyleBackColor = true;
            // 
            // radioButton_PHY
            // 
            this.radioButton_PHY.AutoSize = true;
            this.radioButton_PHY.Location = new System.Drawing.Point(0, 44);
            this.radioButton_PHY.Name = "radioButton_PHY";
            this.radioButton_PHY.Size = new System.Drawing.Size(47, 17);
            this.radioButton_PHY.TabIndex = 1;
            this.radioButton_PHY.TabStop = true;
            this.radioButton_PHY.Text = "PHY";
            this.radioButton_PHY.UseVisualStyleBackColor = true;
            // 
            // radioButton_BPSK
            // 
            this.radioButton_BPSK.AutoSize = true;
            this.radioButton_BPSK.Location = new System.Drawing.Point(7, 13);
            this.radioButton_BPSK.Name = "radioButton_BPSK";
            this.radioButton_BPSK.Size = new System.Drawing.Size(53, 17);
            this.radioButton_BPSK.TabIndex = 0;
            this.radioButton_BPSK.TabStop = true;
            this.radioButton_BPSK.Text = "BPSK";
            this.radioButton_BPSK.UseVisualStyleBackColor = true;
            // 
            // radioButton_QPSK
            // 
            this.radioButton_QPSK.AutoSize = true;
            this.radioButton_QPSK.Location = new System.Drawing.Point(7, 37);
            this.radioButton_QPSK.Name = "radioButton_QPSK";
            this.radioButton_QPSK.Size = new System.Drawing.Size(54, 17);
            this.radioButton_QPSK.TabIndex = 1;
            this.radioButton_QPSK.TabStop = true;
            this.radioButton_QPSK.Text = "QPSK";
            this.radioButton_QPSK.UseVisualStyleBackColor = true;
            // 
            // radioButton_8PSK
            // 
            this.radioButton_8PSK.AutoSize = true;
            this.radioButton_8PSK.Location = new System.Drawing.Point(7, 57);
            this.radioButton_8PSK.Name = "radioButton_8PSK";
            this.radioButton_8PSK.Size = new System.Drawing.Size(52, 17);
            this.radioButton_8PSK.TabIndex = 2;
            this.radioButton_8PSK.TabStop = true;
            this.radioButton_8PSK.Text = "8PSK";
            this.radioButton_8PSK.UseVisualStyleBackColor = true;
            // 
            // checkBox_FEC
            // 
            this.checkBox_FEC.AutoSize = true;
            this.checkBox_FEC.Location = new System.Drawing.Point(7, 81);
            this.checkBox_FEC.Name = "checkBox_FEC";
            this.checkBox_FEC.Size = new System.Drawing.Size(46, 17);
            this.checkBox_FEC.TabIndex = 3;
            this.checkBox_FEC.Text = "FEC";
            this.checkBox_FEC.UseVisualStyleBackColor = true;
            // 
            // Form1_serial_port_communication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 280);
            this.Controls.Add(this.button_com_close);
            this.Controls.Add(this.button_open_com);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox_mode);
            this.Controls.Add(this.button_send_text);
            this.Controls.Add(this.richTextBox_text_to_send);
            this.Controls.Add(this.button_send_reset);
            this.Controls.Add(this.comboBox1_com_ports);
            this.Name = "Form1_serial_port_communication";
            this.Text = "Serial_port_communication";
            this.groupbox_mode.ResumeLayout(false);
            this.groupbox_mode.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1_com_ports;
        private System.Windows.Forms.Button button_send_reset;
        private System.Windows.Forms.RichTextBox richTextBox_text_to_send;
        private System.Windows.Forms.Button button_send_text;
        private System.Windows.Forms.GroupBox groupbox_mode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_DL;
        private System.Windows.Forms.Button button_open_com;
        private System.Windows.Forms.Button button_com_close;
        private System.Windows.Forms.RadioButton radioButton_PHY;
        private System.Windows.Forms.CheckBox checkBox_FEC;
        private System.Windows.Forms.RadioButton radioButton_8PSK;
        private System.Windows.Forms.RadioButton radioButton_QPSK;
        private System.Windows.Forms.RadioButton radioButton_BPSK;
    }
}

