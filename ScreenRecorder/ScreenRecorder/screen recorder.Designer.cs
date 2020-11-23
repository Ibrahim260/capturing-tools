namespace ScreenRecorder
{
    partial class screen_recorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(screen_recorder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.recordLabel = new System.Windows.Forms.Label();
            this.recordCloseLabel = new System.Windows.Forms.Label();
            this.audioRecordLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.btnPauseRecord = new System.Windows.Forms.Button();
            this.btnScreenRecord = new System.Windows.Forms.Button();
            this.btnStopRecord = new System.Windows.Forms.Button();
            this.btnSaveRecorder = new System.Windows.Forms.Button();
            this.tmrRecord = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.recordLabel);
            this.panel1.Controls.Add(this.recordCloseLabel);
            this.panel1.Controls.Add(this.audioRecordLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 35);
            this.panel1.TabIndex = 1;
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.recordLabel.Location = new System.Drawing.Point(4, 12);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(0, 20);
            this.recordLabel.TabIndex = 2;
            // 
            // recordCloseLabel
            // 
            this.recordCloseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recordCloseLabel.AutoSize = true;
            this.recordCloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordCloseLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.recordCloseLabel.Location = new System.Drawing.Point(286, 8);
            this.recordCloseLabel.Name = "recordCloseLabel";
            this.recordCloseLabel.Size = new System.Drawing.Size(19, 18);
            this.recordCloseLabel.TabIndex = 1;
            this.recordCloseLabel.Text = "X";
            this.recordCloseLabel.Click += new System.EventHandler(this.recordCloseLabel_Click);
            // 
            // audioRecordLabel
            // 
            this.audioRecordLabel.AutoSize = true;
            this.audioRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioRecordLabel.Location = new System.Drawing.Point(90, 8);
            this.audioRecordLabel.Name = "audioRecordLabel";
            this.audioRecordLabel.Size = new System.Drawing.Size(126, 16);
            this.audioRecordLabel.TabIndex = 0;
            this.audioRecordLabel.Text = "Screen Recorder";
            this.audioRecordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.audioRecordLabel.Click += new System.EventHandler(this.audioRecordLabel_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.timerLabel.Location = new System.Drawing.Point(112, 43);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(88, 24);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "00:00:00";
            // 
            // btnPauseRecord
            // 
            this.btnPauseRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnPauseRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPauseRecord.BackgroundImage")));
            this.btnPauseRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPauseRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPauseRecord.Location = new System.Drawing.Point(57, 85);
            this.btnPauseRecord.Name = "btnPauseRecord";
            this.btnPauseRecord.Size = new System.Drawing.Size(41, 33);
            this.btnPauseRecord.TabIndex = 4;
            this.btnPauseRecord.UseVisualStyleBackColor = false;
            // 
            // btnScreenRecord
            // 
            this.btnScreenRecord.BackColor = System.Drawing.Color.Gray;
            this.btnScreenRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScreenRecord.BackgroundImage")));
            this.btnScreenRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScreenRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScreenRecord.Location = new System.Drawing.Point(10, 85);
            this.btnScreenRecord.Name = "btnScreenRecord";
            this.btnScreenRecord.Size = new System.Drawing.Size(41, 33);
            this.btnScreenRecord.TabIndex = 3;
            this.btnScreenRecord.UseVisualStyleBackColor = false;
            this.btnScreenRecord.Click += new System.EventHandler(this.btnScreenRecord_Click);
            // 
            // btnStopRecord
            // 
            this.btnStopRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnStopRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStopRecord.BackgroundImage")));
            this.btnStopRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStopRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStopRecord.Location = new System.Drawing.Point(104, 85);
            this.btnStopRecord.Name = "btnStopRecord";
            this.btnStopRecord.Size = new System.Drawing.Size(41, 33);
            this.btnStopRecord.TabIndex = 5;
            this.btnStopRecord.UseVisualStyleBackColor = false;
            this.btnStopRecord.Click += new System.EventHandler(this.btnSaveRecord_Click);
            // 
            // btnSaveRecorder
            // 
            this.btnSaveRecorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSaveRecorder.BackgroundImage = global::ScreenRecorder.Properties.Resources.Save_256;
            this.btnSaveRecorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveRecorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRecorder.Location = new System.Drawing.Point(263, 87);
            this.btnSaveRecorder.Name = "btnSaveRecorder";
            this.btnSaveRecorder.Size = new System.Drawing.Size(41, 33);
            this.btnSaveRecorder.TabIndex = 6;
            this.btnSaveRecorder.UseVisualStyleBackColor = false;
            this.btnSaveRecorder.Click += new System.EventHandler(this.bt_Click);
            // 
            // tmrRecord
            // 
            this.tmrRecord.Interval = 15;
            this.tmrRecord.Tick += new System.EventHandler(this.tmrRecord_Tick);
            // 
            // screen_recorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(316, 132);
            this.Controls.Add(this.btnSaveRecorder);
            this.Controls.Add(this.btnStopRecord);
            this.Controls.Add(this.btnPauseRecord);
            this.Controls.Add(this.btnScreenRecord);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "screen_recorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "screen_recorder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label recordLabel;
        private System.Windows.Forms.Label recordCloseLabel;
        private System.Windows.Forms.Label audioRecordLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button btnScreenRecord;
        private System.Windows.Forms.Button btnPauseRecord;
        private System.Windows.Forms.Button btnStopRecord;
        private System.Windows.Forms.Button btnSaveRecorder;
        private System.Windows.Forms.Timer tmrRecord;
    }
}