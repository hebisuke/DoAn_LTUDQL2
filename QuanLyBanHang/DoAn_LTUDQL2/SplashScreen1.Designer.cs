namespace DoAn_LTUDQL2
{
    partial class SplashScreen1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen1));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 290);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Starting...";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(392, 533);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(383, 36);
            this.progressBar1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 32;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureEdit2.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowMenu = false;
            this.pictureEdit2.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit2.Size = new System.Drawing.Size(806, 620);
            this.pictureEdit2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(438, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hacking....";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SplashScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelControl2);
            this.Name = "SplashScreen1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}
