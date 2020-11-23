namespace ScreenRecorder
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.headingLabel = new System.Windows.Forms.Label();
            this.audioRecordButton = new ScreenRecorder.RoundButton();
            this.screenshotButton = new ScreenRecorder.RoundButton();
            this.videoRecordButton = new ScreenRecorder.RoundButton();
            this.exitButton = new ScreenRecorder.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // headingLabel
            // 
            this.headingLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.ForeColor = System.Drawing.Color.Gray;
            this.headingLabel.Location = new System.Drawing.Point(74, 43);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(144, 22);
            this.headingLabel.TabIndex = 4;
            this.headingLabel.Text = "Captured Tools";
            // 
            // audioRecordButton
            // 
            this.audioRecordButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.audioRecordButton.BackgroundImage = global::ScreenRecorder.Properties.Resources._115_mic_speaker_vocal_audio_record_recorder_256;
            this.audioRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.audioRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioRecordButton.Location = new System.Drawing.Point(119, 221);
            this.audioRecordButton.Name = "audioRecordButton";
            this.audioRecordButton.Size = new System.Drawing.Size(60, 53);
            this.audioRecordButton.TabIndex = 3;
            this.audioRecordButton.UseVisualStyleBackColor = true;
            this.audioRecordButton.Click += new System.EventHandler(this.audioRecordButton_Click);
            // 
            // screenshotButton
            // 
            this.screenshotButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.screenshotButton.BackgroundImage = global::ScreenRecorder.Properties.Resources.SEODevelopment__Marketing_087_256;
            this.screenshotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenshotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.screenshotButton.Location = new System.Drawing.Point(216, 112);
            this.screenshotButton.Name = "screenshotButton";
            this.screenshotButton.Size = new System.Drawing.Size(67, 59);
            this.screenshotButton.TabIndex = 2;
            this.screenshotButton.UseVisualStyleBackColor = true;
            // 
            // videoRecordButton
            // 
            this.videoRecordButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.videoRecordButton.BackgroundImage = global::ScreenRecorder.Properties.Resources.camera_video_film_record_256;
            this.videoRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.videoRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoRecordButton.Location = new System.Drawing.Point(3, 112);
            this.videoRecordButton.Name = "videoRecordButton";
            this.videoRecordButton.Size = new System.Drawing.Size(64, 59);
            this.videoRecordButton.TabIndex = 1;
            this.videoRecordButton.UseVisualStyleBackColor = true;
            this.videoRecordButton.Click += new System.EventHandler(this.videoRecordButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.exitButton.BackgroundImage = global::ScreenRecorder.Properties.Resources._59_256__1_;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitButton.Location = new System.Drawing.Point(119, 112);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(60, 59);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(290, 289);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.audioRecordButton);
            this.Controls.Add(this.screenshotButton);
            this.Controls.Add(this.videoRecordButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton exitButton;
        private RoundButton videoRecordButton;
        private RoundButton screenshotButton;
        private RoundButton audioRecordButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headingLabel;
    }
}

