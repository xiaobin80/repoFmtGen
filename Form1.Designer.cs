namespace repoFmtGen
{
    partial class frmMain
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtInq = new System.Windows.Forms.TextBox();
            this.edtAck = new System.Windows.Forms.TextBox();
            this.btnCall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edtStation = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.edtInq);
            this.groupBox2.Controls.Add(this.edtAck);
            this.groupBox2.Location = new System.Drawing.Point(28, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1022, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出数组";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "INQ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ACK:";
            // 
            // edtInq
            // 
            this.edtInq.Location = new System.Drawing.Point(47, 86);
            this.edtInq.Name = "edtInq";
            this.edtInq.Size = new System.Drawing.Size(969, 20);
            this.edtInq.TabIndex = 3;
            // 
            // edtAck
            // 
            this.edtAck.Location = new System.Drawing.Point(48, 40);
            this.edtAck.Name = "edtAck";
            this.edtAck.Size = new System.Drawing.Size(968, 20);
            this.edtAck.TabIndex = 2;
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(76, 70);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(60, 38);
            this.btnCall.TabIndex = 1;
            this.btnCall.Text = "->";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "站点ID:";
            // 
            // edtStation
            // 
            this.edtStation.Location = new System.Drawing.Point(76, 41);
            this.edtStation.Name = "edtStation";
            this.edtStation.Size = new System.Drawing.Size(59, 20);
            this.edtStation.TabIndex = 0;
            this.edtStation.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 282);
            this.Controls.Add(this.edtStation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询和确认报文 － 生成";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.TextBox edtAck;
        private System.Windows.Forms.TextBox edtInq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtStation;
    }
}

