namespace VisualPOVray
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBar)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Render";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lightBar);
            this.Controls.Add(this.renderBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox renderBox;
        private System.Windows.Forms.TrackBar lightBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

