namespace SpriteProcess
{
    partial class Form1
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
            this.cmdOpen = new System.Windows.Forms.Button();
            this.lstSourceFiles = new System.Windows.Forms.ListBox();
            this.cmdAlpha = new System.Windows.Forms.Button();
            this.cmdShadow = new System.Windows.Forms.Button();
            this.txtSpriteDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShadowDir = new System.Windows.Forms.TextBox();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.pbAlpha = new System.Windows.Forms.PictureBox();
            this.pbShadow = new System.Windows.Forms.PictureBox();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(22, 27);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(131, 37);
            this.cmdOpen.TabIndex = 0;
            this.cmdOpen.Text = "Open Images";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // lstSourceFiles
            // 
            this.lstSourceFiles.FormattingEnabled = true;
            this.lstSourceFiles.Location = new System.Drawing.Point(22, 70);
            this.lstSourceFiles.Name = "lstSourceFiles";
            this.lstSourceFiles.Size = new System.Drawing.Size(500, 225);
            this.lstSourceFiles.TabIndex = 1;
            // 
            // cmdAlpha
            // 
            this.cmdAlpha.Location = new System.Drawing.Point(22, 301);
            this.cmdAlpha.Name = "cmdAlpha";
            this.cmdAlpha.Size = new System.Drawing.Size(131, 37);
            this.cmdAlpha.TabIndex = 3;
            this.cmdAlpha.Text = "Alpha key";
            this.cmdAlpha.UseVisualStyleBackColor = true;
            this.cmdAlpha.Click += new System.EventHandler(this.cmdAlpha_Click);
            // 
            // cmdShadow
            // 
            this.cmdShadow.Location = new System.Drawing.Point(159, 302);
            this.cmdShadow.Name = "cmdShadow";
            this.cmdShadow.Size = new System.Drawing.Size(131, 37);
            this.cmdShadow.TabIndex = 4;
            this.cmdShadow.Text = "Shadow Key";
            this.cmdShadow.UseVisualStyleBackColor = true;
            this.cmdShadow.Click += new System.EventHandler(this.cmdShadow_Click);
            // 
            // txtSpriteDir
            // 
            this.txtSpriteDir.Location = new System.Drawing.Point(22, 402);
            this.txtSpriteDir.Name = "txtSpriteDir";
            this.txtSpriteDir.Size = new System.Drawing.Size(500, 20);
            this.txtSpriteDir.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sprite Output Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Shadow Output Directory";
            // 
            // txtShadowDir
            // 
            this.txtShadowDir.Location = new System.Drawing.Point(22, 447);
            this.txtShadowDir.Name = "txtShadowDir";
            this.txtShadowDir.Size = new System.Drawing.Size(500, 20);
            this.txtShadowDir.TabIndex = 7;
            // 
            // cmdConvert
            // 
            this.cmdConvert.Location = new System.Drawing.Point(391, 302);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(131, 37);
            this.cmdConvert.TabIndex = 9;
            this.cmdConvert.Text = "Convert";
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.cmdConvert_Click);
            // 
            // prgProgress
            // 
            this.prgProgress.Location = new System.Drawing.Point(22, 484);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(500, 23);
            this.prgProgress.TabIndex = 10;
            // 
            // pbAlpha
            // 
            this.pbAlpha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(66)))), ((int)(((byte)(41)))));
            this.pbAlpha.Location = new System.Drawing.Point(22, 344);
            this.pbAlpha.Name = "pbAlpha";
            this.pbAlpha.Size = new System.Drawing.Size(131, 24);
            this.pbAlpha.TabIndex = 11;
            this.pbAlpha.TabStop = false;
            // 
            // pbShadow
            // 
            this.pbShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(9)))), ((int)(((byte)(5)))));
            this.pbShadow.Location = new System.Drawing.Point(159, 344);
            this.pbShadow.Name = "pbShadow";
            this.pbShadow.Size = new System.Drawing.Size(131, 24);
            this.pbShadow.TabIndex = 12;
            this.pbShadow.TabStop = false;
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(296, 318);
            this.nudWidth.Maximum = new decimal(new int[] {
            16777216,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(78, 20);
            this.nudWidth.TabIndex = 13;
            this.nudWidth.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(296, 357);
            this.nudHeight.Maximum = new decimal(new int[] {
            16777216,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(78, 20);
            this.nudHeight.TabIndex = 14;
            this.nudHeight.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 525);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.pbShadow);
            this.Controls.Add(this.pbAlpha);
            this.Controls.Add(this.prgProgress);
            this.Controls.Add(this.cmdConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtShadowDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpriteDir);
            this.Controls.Add(this.cmdShadow);
            this.Controls.Add(this.cmdAlpha);
            this.Controls.Add(this.lstSourceFiles);
            this.Controls.Add(this.cmdOpen);
            this.Name = "Form1";
            this.Text = "Sprite Processor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.ListBox lstSourceFiles;
        private System.Windows.Forms.Button cmdAlpha;
        private System.Windows.Forms.Button cmdShadow;
        private System.Windows.Forms.TextBox txtSpriteDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShadowDir;
        private System.Windows.Forms.Button cmdConvert;
        private System.Windows.Forms.ProgressBar prgProgress;
        private System.Windows.Forms.PictureBox pbAlpha;
        private System.Windows.Forms.PictureBox pbShadow;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

