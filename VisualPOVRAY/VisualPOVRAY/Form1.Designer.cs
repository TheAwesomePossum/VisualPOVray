namespace VisualPOVRAY
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
            this.components = new System.ComponentModel.Container();
            this.renderBox = new System.Windows.Forms.PictureBox();
            this.lightBar = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageWidthTB = new System.Windows.Forms.TextBox();
            this.imageNameTB = new System.Windows.Forms.TextBox();
            this.imageSizeLabel = new System.Windows.Forms.Label();
            this.imageNameLabel = new System.Windows.Forms.Label();
            this.renderButt = new System.Windows.Forms.Button();
            this.imageHeightLabel = new System.Windows.Forms.Label();
            this.imageHeightTB = new System.Windows.Forms.TextBox();
            this.imageGammaBar = new System.Windows.Forms.TrackBar();
            this.imageGammaLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gammaUpdater = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.camXPosLab = new System.Windows.Forms.Label();
            this.camXDirLab = new System.Windows.Forms.Label();
            this.camYPosLab = new System.Windows.Forms.Label();
            this.camYDirLab = new System.Windows.Forms.Label();
            this.camZPosLab = new System.Windows.Forms.Label();
            this.camZDirLab = new System.Windows.Forms.Label();
            this.xPosTB = new System.Windows.Forms.TextBox();
            this.yPosTB = new System.Windows.Forms.TextBox();
            this.zPosTB = new System.Windows.Forms.TextBox();
            this.xDirTB = new System.Windows.Forms.TextBox();
            this.yDirTB = new System.Windows.Forms.TextBox();
            this.zDirTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.aliasLabel = new System.Windows.Forms.Label();
            this.aliasingTrackBar = new System.Windows.Forms.TrackBar();
            this.qualityTrackBar = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.antiAliasingCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGammaBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliasingTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // renderBox
            // 
            this.renderBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.renderBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.renderBox.Location = new System.Drawing.Point(69, 75);
            this.renderBox.Name = "renderBox";
            this.renderBox.Size = new System.Drawing.Size(512, 385);
            this.renderBox.TabIndex = 0;
            this.renderBox.TabStop = false;
            this.renderBox.Paint += new System.Windows.Forms.PaintEventHandler(this.renderBox_Paint);
            // 
            // lightBar
            // 
            this.lightBar.Location = new System.Drawing.Point(69, 12);
            this.lightBar.Maximum = 12;
            this.lightBar.Minimum = -4;
            this.lightBar.Name = "lightBar";
            this.lightBar.Size = new System.Drawing.Size(104, 45);
            this.lightBar.TabIndex = 1;
            this.lightBar.Value = 4;
            this.lightBar.Scroll += new System.EventHandler(this.lightBar_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageWidthTB
            // 
            this.imageWidthTB.Location = new System.Drawing.Point(691, 165);
            this.imageWidthTB.Name = "imageWidthTB";
            this.imageWidthTB.Size = new System.Drawing.Size(100, 20);
            this.imageWidthTB.TabIndex = 3;
            this.imageWidthTB.Text = "512";
            this.imageWidthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imageWidthTB_KeyPress);
            // 
            // imageNameTB
            // 
            this.imageNameTB.Location = new System.Drawing.Point(691, 191);
            this.imageNameTB.Name = "imageNameTB";
            this.imageNameTB.Size = new System.Drawing.Size(100, 20);
            this.imageNameTB.TabIndex = 5;
            // 
            // imageSizeLabel
            // 
            this.imageSizeLabel.AutoSize = true;
            this.imageSizeLabel.Location = new System.Drawing.Point(604, 165);
            this.imageSizeLabel.Name = "imageSizeLabel";
            this.imageSizeLabel.Size = new System.Drawing.Size(73, 13);
            this.imageSizeLabel.TabIndex = 6;
            this.imageSizeLabel.Text = "Image Width: ";
            // 
            // imageNameLabel
            // 
            this.imageNameLabel.AutoSize = true;
            this.imageNameLabel.Location = new System.Drawing.Point(604, 191);
            this.imageNameLabel.Name = "imageNameLabel";
            this.imageNameLabel.Size = new System.Drawing.Size(73, 13);
            this.imageNameLabel.TabIndex = 8;
            this.imageNameLabel.Text = "Image Name: ";
            // 
            // renderButt
            // 
            this.renderButt.Location = new System.Drawing.Point(444, 34);
            this.renderButt.Name = "renderButt";
            this.renderButt.Size = new System.Drawing.Size(75, 23);
            this.renderButt.TabIndex = 0;
            this.renderButt.Text = "Render";
            this.renderButt.Click += new System.EventHandler(this.renderButt_Click);
            // 
            // imageHeightLabel
            // 
            this.imageHeightLabel.AutoSize = true;
            this.imageHeightLabel.Location = new System.Drawing.Point(604, 139);
            this.imageHeightLabel.Name = "imageHeightLabel";
            this.imageHeightLabel.Size = new System.Drawing.Size(73, 13);
            this.imageHeightLabel.TabIndex = 9;
            this.imageHeightLabel.Text = "Image Height:";
            // 
            // imageHeightTB
            // 
            this.imageHeightTB.Location = new System.Drawing.Point(691, 139);
            this.imageHeightTB.Name = "imageHeightTB";
            this.imageHeightTB.Size = new System.Drawing.Size(100, 20);
            this.imageHeightTB.TabIndex = 10;
            this.imageHeightTB.Text = "385";
            this.imageHeightTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imageHeightTB_KeyPress);
            // 
            // imageGammaBar
            // 
            this.imageGammaBar.Location = new System.Drawing.Point(679, 217);
            this.imageGammaBar.Maximum = 300;
            this.imageGammaBar.Name = "imageGammaBar";
            this.imageGammaBar.Size = new System.Drawing.Size(104, 45);
            this.imageGammaBar.TabIndex = 11;
            this.imageGammaBar.Value = 100;
            // 
            // imageGammaLabel
            // 
            this.imageGammaLabel.AutoSize = true;
            this.imageGammaLabel.Location = new System.Drawing.Point(604, 217);
            this.imageGammaLabel.Name = "imageGammaLabel";
            this.imageGammaLabel.Size = new System.Drawing.Size(78, 13);
            this.imageGammaLabel.TabIndex = 12;
            this.imageGammaLabel.Text = "Image Gamma:";
            // 
            // gammaUpdater
            // 
            this.gammaUpdater.AutoSize = true;
            this.gammaUpdater.Location = new System.Drawing.Point(688, 249);
            this.gammaUpdater.Name = "gammaUpdater";
            this.gammaUpdater.Size = new System.Drawing.Size(49, 13);
            this.gammaUpdater.TabIndex = 16;
            this.gammaUpdater.Text = "Gamma: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Camera Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Camera Direction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Z:";
            // 
            // camXPosLab
            // 
            this.camXPosLab.AutoSize = true;
            this.camXPosLab.Location = new System.Drawing.Point(623, 288);
            this.camXPosLab.Name = "camXPosLab";
            this.camXPosLab.Size = new System.Drawing.Size(35, 13);
            this.camXPosLab.TabIndex = 22;
            this.camXPosLab.Text = "X Pos";
            // 
            // camXDirLab
            // 
            this.camXDirLab.AutoSize = true;
            this.camXDirLab.Location = new System.Drawing.Point(703, 287);
            this.camXDirLab.Name = "camXDirLab";
            this.camXDirLab.Size = new System.Drawing.Size(30, 13);
            this.camXDirLab.TabIndex = 23;
            this.camXDirLab.Text = "X Dir";
            // 
            // camYPosLab
            // 
            this.camYPosLab.AutoSize = true;
            this.camYPosLab.Location = new System.Drawing.Point(623, 301);
            this.camYPosLab.Name = "camYPosLab";
            this.camYPosLab.Size = new System.Drawing.Size(35, 13);
            this.camYPosLab.TabIndex = 24;
            this.camYPosLab.Text = "Y Pos";
            // 
            // camYDirLab
            // 
            this.camYDirLab.AutoSize = true;
            this.camYDirLab.Location = new System.Drawing.Point(703, 301);
            this.camYDirLab.Name = "camYDirLab";
            this.camYDirLab.Size = new System.Drawing.Size(30, 13);
            this.camYDirLab.TabIndex = 25;
            this.camYDirLab.Text = "Y Dir";
            // 
            // camZPosLab
            // 
            this.camZPosLab.AutoSize = true;
            this.camZPosLab.Location = new System.Drawing.Point(623, 314);
            this.camZPosLab.Name = "camZPosLab";
            this.camZPosLab.Size = new System.Drawing.Size(35, 13);
            this.camZPosLab.TabIndex = 26;
            this.camZPosLab.Text = "Z Pos";
            // 
            // camZDirLab
            // 
            this.camZDirLab.AutoSize = true;
            this.camZDirLab.Location = new System.Drawing.Point(703, 314);
            this.camZDirLab.Name = "camZDirLab";
            this.camZDirLab.Size = new System.Drawing.Size(30, 13);
            this.camZDirLab.TabIndex = 27;
            this.camZDirLab.Text = "Z Dir";
            // 
            // xPosTB
            // 
            this.xPosTB.Location = new System.Drawing.Point(626, 331);
            this.xPosTB.Name = "xPosTB";
            this.xPosTB.Size = new System.Drawing.Size(51, 20);
            this.xPosTB.TabIndex = 28;
            this.xPosTB.Text = "0";
            // 
            // yPosTB
            // 
            this.yPosTB.Location = new System.Drawing.Point(626, 358);
            this.yPosTB.Name = "yPosTB";
            this.yPosTB.Size = new System.Drawing.Size(51, 20);
            this.yPosTB.TabIndex = 29;
            this.yPosTB.Text = "2";
            // 
            // zPosTB
            // 
            this.zPosTB.Location = new System.Drawing.Point(626, 385);
            this.zPosTB.Name = "zPosTB";
            this.zPosTB.Size = new System.Drawing.Size(51, 20);
            this.zPosTB.TabIndex = 30;
            this.zPosTB.Text = "-3";
            // 
            // xDirTB
            // 
            this.xDirTB.Location = new System.Drawing.Point(691, 330);
            this.xDirTB.Name = "xDirTB";
            this.xDirTB.Size = new System.Drawing.Size(51, 20);
            this.xDirTB.TabIndex = 31;
            this.xDirTB.Text = "0";
            // 
            // yDirTB
            // 
            this.yDirTB.Location = new System.Drawing.Point(691, 357);
            this.yDirTB.Name = "yDirTB";
            this.yDirTB.Size = new System.Drawing.Size(51, 20);
            this.yDirTB.TabIndex = 32;
            this.yDirTB.Text = "1";
            // 
            // zDirTB
            // 
            this.zDirTB.Location = new System.Drawing.Point(691, 384);
            this.zDirTB.Name = "zDirTB";
            this.zDirTB.Size = new System.Drawing.Size(51, 20);
            this.zDirTB.TabIndex = 33;
            this.zDirTB.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "X: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Z:";
            // 
            // aliasLabel
            // 
            this.aliasLabel.AutoSize = true;
            this.aliasLabel.Location = new System.Drawing.Point(623, 418);
            this.aliasLabel.Name = "aliasLabel";
            this.aliasLabel.Size = new System.Drawing.Size(46, 13);
            this.aliasLabel.TabIndex = 37;
            this.aliasLabel.Text = "Aliasing:";
            // 
            // aliasingTrackBar
            // 
            this.aliasingTrackBar.Location = new System.Drawing.Point(626, 434);
            this.aliasingTrackBar.Name = "aliasingTrackBar";
            this.aliasingTrackBar.Size = new System.Drawing.Size(104, 45);
            this.aliasingTrackBar.TabIndex = 38;
            this.aliasingTrackBar.Value = 3;
            // 
            // qualityTrackBar
            // 
            this.qualityTrackBar.Location = new System.Drawing.Point(651, 62);
            this.qualityTrackBar.Maximum = 11;
            this.qualityTrackBar.Name = "qualityTrackBar";
            this.qualityTrackBar.Size = new System.Drawing.Size(104, 45);
            this.qualityTrackBar.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(679, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Quality";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(632, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "L";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(761, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "H";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(604, 434);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Fast";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(725, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Slow";
            // 
            // antiAliasingCB
            // 
            this.antiAliasingCB.AutoSize = true;
            this.antiAliasingCB.Location = new System.Drawing.Point(607, 485);
            this.antiAliasingCB.Name = "antiAliasingCB";
            this.antiAliasingCB.Size = new System.Drawing.Size(82, 17);
            this.antiAliasingCB.TabIndex = 45;
            this.antiAliasingCB.Text = "Anti-aliasing";
            this.antiAliasingCB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 550);
            this.Controls.Add(this.antiAliasingCB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.qualityTrackBar);
            this.Controls.Add(this.aliasingTrackBar);
            this.Controls.Add(this.aliasLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zDirTB);
            this.Controls.Add(this.yDirTB);
            this.Controls.Add(this.xDirTB);
            this.Controls.Add(this.zPosTB);
            this.Controls.Add(this.yPosTB);
            this.Controls.Add(this.xPosTB);
            this.Controls.Add(this.camZDirLab);
            this.Controls.Add(this.camZPosLab);
            this.Controls.Add(this.camYDirLab);
            this.Controls.Add(this.camYPosLab);
            this.Controls.Add(this.camXDirLab);
            this.Controls.Add(this.camXPosLab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gammaUpdater);
            this.Controls.Add(this.imageGammaLabel);
            this.Controls.Add(this.imageGammaBar);
            this.Controls.Add(this.imageHeightTB);
            this.Controls.Add(this.imageHeightLabel);
            this.Controls.Add(this.renderButt);
            this.Controls.Add(this.imageNameLabel);
            this.Controls.Add(this.imageSizeLabel);
            this.Controls.Add(this.imageNameTB);
            this.Controls.Add(this.imageWidthTB);
            this.Controls.Add(this.lightBar);
            this.Controls.Add(this.renderBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageGammaBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aliasingTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox renderBox;
        private System.Windows.Forms.TrackBar lightBar;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox imageWidthTB;
        private System.Windows.Forms.TextBox imageNameTB;
        private System.Windows.Forms.Label imageSizeLabel;
        private System.Windows.Forms.Label imageNameLabel;
        private System.Windows.Forms.Button renderButt;
        private System.Windows.Forms.Label imageHeightLabel;
        private System.Windows.Forms.TextBox imageHeightTB;
        private System.Windows.Forms.TrackBar imageGammaBar;
        private System.Windows.Forms.Label imageGammaLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label gammaUpdater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label camXPosLab;
        private System.Windows.Forms.Label camXDirLab;
        private System.Windows.Forms.Label camYPosLab;
        private System.Windows.Forms.Label camYDirLab;
        private System.Windows.Forms.Label camZPosLab;
        private System.Windows.Forms.Label camZDirLab;
        private System.Windows.Forms.TextBox xPosTB;
        private System.Windows.Forms.TextBox yPosTB;
        private System.Windows.Forms.TextBox zPosTB;
        private System.Windows.Forms.TextBox xDirTB;
        private System.Windows.Forms.TextBox yDirTB;
        private System.Windows.Forms.TextBox zDirTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label aliasLabel;
        private System.Windows.Forms.TrackBar aliasingTrackBar;
        private System.Windows.Forms.TrackBar qualityTrackBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox antiAliasingCB;
    }
}

