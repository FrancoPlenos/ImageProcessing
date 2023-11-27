namespace ImageProcessing
{
    partial class Subtraction
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
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pbSubtracted = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLoadGreen = new System.Windows.Forms.Button();
            this.btnLoadBG = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtracted)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGreen
            // 
            this.pbGreen.Location = new System.Drawing.Point(12, 63);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(414, 418);
            this.pbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGreen.TabIndex = 0;
            this.pbGreen.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Location = new System.Drawing.Point(444, 63);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(414, 418);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 1;
            this.pbBackground.TabStop = false;
            // 
            // pbSubtracted
            // 
            this.pbSubtracted.Location = new System.Drawing.Point(876, 63);
            this.pbSubtracted.Name = "pbSubtracted";
            this.pbSubtracted.Size = new System.Drawing.Size(414, 418);
            this.pbSubtracted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSubtracted.TabIndex = 2;
            this.pbSubtracted.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 44);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Image Processing";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLoadGreen
            // 
            this.btnLoadGreen.Location = new System.Drawing.Point(136, 513);
            this.btnLoadGreen.Name = "btnLoadGreen";
            this.btnLoadGreen.Size = new System.Drawing.Size(140, 44);
            this.btnLoadGreen.TabIndex = 4;
            this.btnLoadGreen.Text = "Load Image";
            this.btnLoadGreen.UseVisualStyleBackColor = true;
            this.btnLoadGreen.Click += new System.EventHandler(this.btnLoadGreen_Click);
            // 
            // btnLoadBG
            // 
            this.btnLoadBG.Location = new System.Drawing.Point(586, 513);
            this.btnLoadBG.Name = "btnLoadBG";
            this.btnLoadBG.Size = new System.Drawing.Size(140, 44);
            this.btnLoadBG.TabIndex = 5;
            this.btnLoadBG.Text = "Load Background";
            this.btnLoadBG.UseVisualStyleBackColor = true;
            this.btnLoadBG.Click += new System.EventHandler(this.btnLoadBG_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(1021, 513);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(140, 44);
            this.btnSubtract.TabIndex = 6;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            // 
            // Subtraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 672);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnLoadBG);
            this.Controls.Add(this.btnLoadGreen);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbSubtracted);
            this.Controls.Add(this.pbBackground);
            this.Controls.Add(this.pbGreen);
            this.Name = "Subtraction";
            this.Text = "Subtraction Tings";
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtracted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbSubtracted;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLoadGreen;
        private System.Windows.Forms.Button btnLoadBG;
        private System.Windows.Forms.Button btnSubtract;
    }
}