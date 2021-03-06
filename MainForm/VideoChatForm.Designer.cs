﻿namespace NIMDemo.MainForm
{
    partial class VideoChatForm
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.peerPicBox = new System.Windows.Forms.PictureBox();
			this.cb_setquality = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.bt_setting = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnSetMute = new System.Windows.Forms.Button();
			this.btnRecord = new System.Windows.Forms.Button();
			this.minePicBox = new System.Windows.Forms.PictureBox();
			this.btn_beauty = new System.Windows.Forms.Button();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.peerPicBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minePicBox)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.peerPicBox);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btn_beauty);
			this.splitContainer1.Panel2.Controls.Add(this.cb_setquality);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.bt_setting);
			this.splitContainer1.Panel2.Controls.Add(this.button1);
			this.splitContainer1.Panel2.Controls.Add(this.btnSetMute);
			this.splitContainer1.Panel2.Controls.Add(this.btnRecord);
			this.splitContainer1.Panel2.Controls.Add(this.minePicBox);
			this.splitContainer1.Size = new System.Drawing.Size(383, 523);
			this.splitContainer1.SplitterDistance = 302;
			this.splitContainer1.TabIndex = 0;
			// 
			// peerPicBox
			// 
			this.peerPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.peerPicBox.Location = new System.Drawing.Point(0, 0);
			this.peerPicBox.Name = "peerPicBox";
			this.peerPicBox.Size = new System.Drawing.Size(383, 302);
			this.peerPicBox.TabIndex = 0;
			this.peerPicBox.TabStop = false;
			// 
			// cb_setquality
			// 
			this.cb_setquality.FormattingEnabled = true;
			this.cb_setquality.Location = new System.Drawing.Point(161, 156);
			this.cb_setquality.Name = "cb_setquality";
			this.cb_setquality.Size = new System.Drawing.Size(201, 20);
			this.cb_setquality.TabIndex = 6;
			this.cb_setquality.SelectedIndexChanged += new System.EventHandler(this.cb_setquality_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 159);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "分辨率设置";
			// 
			// bt_setting
			// 
			this.bt_setting.Location = new System.Drawing.Point(22, 119);
			this.bt_setting.Name = "bt_setting";
			this.bt_setting.Size = new System.Drawing.Size(89, 23);
			this.bt_setting.TabIndex = 4;
			this.bt_setting.Text = "音视频设置";
			this.bt_setting.UseVisualStyleBackColor = true;
			this.bt_setting.Click += new System.EventHandler(this.bt_setting_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(22, 15);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(89, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "挂断";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnSetMute
			// 
			this.btnSetMute.Location = new System.Drawing.Point(22, 86);
			this.btnSetMute.Name = "btnSetMute";
			this.btnSetMute.Size = new System.Drawing.Size(89, 23);
			this.btnSetMute.TabIndex = 2;
			this.btnSetMute.Text = "设置静音";
			this.btnSetMute.UseVisualStyleBackColor = true;
			this.btnSetMute.Click += new System.EventHandler(this.btnSetMute_Click_1);
			// 
			// btnRecord
			// 
			this.btnRecord.Location = new System.Drawing.Point(22, 51);
			this.btnRecord.Name = "btnRecord";
			this.btnRecord.Size = new System.Drawing.Size(89, 23);
			this.btnRecord.TabIndex = 3;
			this.btnRecord.Text = "开始录音";
			this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
			// 
			// minePicBox
			// 
			this.minePicBox.Location = new System.Drawing.Point(161, 10);
			this.minePicBox.Name = "minePicBox";
			this.minePicBox.Size = new System.Drawing.Size(201, 135);
			this.minePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.minePicBox.TabIndex = 0;
			this.minePicBox.TabStop = false;
			// 
			// btn_beauty
			// 
			this.btn_beauty.Location = new System.Drawing.Point(22, 182);
			this.btn_beauty.Name = "btn_beauty";
			this.btn_beauty.Size = new System.Drawing.Size(89, 23);
			this.btn_beauty.TabIndex = 7;
			this.btn_beauty.Text = "美颜（开）";
			this.btn_beauty.UseVisualStyleBackColor = true;
			this.btn_beauty.Click += new System.EventHandler(this.btn_beauty_Click);
			// 
			// VideoChatForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 523);
			this.Controls.Add(this.splitContainer1);
			this.Name = "VideoChatForm";
			this.Text = "音视频通话";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.peerPicBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minePicBox)).EndInit();
			this.ResumeLayout(false);

        }

		private void BtnSetMute_Click(object sender, System.EventArgs e)
		{
			NIM.VChatAPI.SetAudioMute(true);
		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox peerPicBox;
        private System.Windows.Forms.PictureBox minePicBox;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnSetMute;
		private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button bt_setting;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_setquality;
		private System.Windows.Forms.Button btn_beauty;
	}
}