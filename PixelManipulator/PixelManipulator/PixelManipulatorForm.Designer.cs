namespace PixelManipulator
{
    partial class PixelManipulatorForm
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
            this.startbutton = new System.Windows.Forms.Button();
            this.pictureBoxLoadedPic = new System.Windows.Forms.PictureBox();
            this.pictureBoxEffect = new System.Windows.Forms.PictureBox();
            this.loadPicButton = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadedPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEffect)).BeginInit();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(148, 135);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(83, 27);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // pictureBoxLoadedPic
            // 
            this.pictureBoxLoadedPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxLoadedPic.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLoadedPic.Name = "pictureBoxLoadedPic";
            this.pictureBoxLoadedPic.Size = new System.Drawing.Size(130, 117);
            this.pictureBoxLoadedPic.TabIndex = 1;
            this.pictureBoxLoadedPic.TabStop = false;
            // 
            // pictureBoxEffect
            // 
            this.pictureBoxEffect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxEffect.Location = new System.Drawing.Point(148, 12);
            this.pictureBoxEffect.Name = "pictureBoxEffect";
            this.pictureBoxEffect.Size = new System.Drawing.Size(130, 117);
            this.pictureBoxEffect.TabIndex = 2;
            this.pictureBoxEffect.TabStop = false;
            // 
            // loadPicButton
            // 
            this.loadPicButton.Location = new System.Drawing.Point(12, 135);
            this.loadPicButton.Name = "loadPicButton";
            this.loadPicButton.Size = new System.Drawing.Size(83, 27);
            this.loadPicButton.TabIndex = 3;
            this.loadPicButton.Text = "Load Pic";
            this.loadPicButton.UseVisualStyleBackColor = true;
            this.loadPicButton.Click += new System.EventHandler(this.loadPicButton_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(148, 168);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(83, 27);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // PixelManipulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 241);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.loadPicButton);
            this.Controls.Add(this.pictureBoxEffect);
            this.Controls.Add(this.pictureBoxLoadedPic);
            this.Controls.Add(this.startbutton);
            this.Name = "PixelManipulatorForm";
            this.Text = "PixelManipulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PixelManipulatorForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadedPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEffect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.PictureBox pictureBoxLoadedPic;
        private System.Windows.Forms.PictureBox pictureBoxEffect;
        private System.Windows.Forms.Button loadPicButton;
        private System.Windows.Forms.Button buttonReset;
    }
}

