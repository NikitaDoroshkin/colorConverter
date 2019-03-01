namespace colorPicker
{
    partial class ColorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorForm));
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ColorDialogButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RgbBBox = new System.Windows.Forms.TextBox();
            this.RgbGBox = new System.Windows.Forms.TextBox();
            this.RgbRBox = new System.Windows.Forms.TextBox();
            this.RgbBBar = new System.Windows.Forms.TrackBar();
            this.RgbGBar = new System.Windows.Forms.TrackBar();
            this.RgbRBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.percent1 = new System.Windows.Forms.Label();
            this.HslSBox = new System.Windows.Forms.TextBox();
            this.HslLBox = new System.Windows.Forms.TextBox();
            this.HslHBox = new System.Windows.Forms.TextBox();
            this.HslSBar = new System.Windows.Forms.TrackBar();
            this.HslLBar = new System.Windows.Forms.TrackBar();
            this.HslHBar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmykKBox = new System.Windows.Forms.TextBox();
            this.CmykYBox = new System.Windows.Forms.TextBox();
            this.CmykKBar = new System.Windows.Forms.TrackBar();
            this.CmykMBox = new System.Windows.Forms.TextBox();
            this.CmykCBox = new System.Windows.Forms.TextBox();
            this.CmykYBar = new System.Windows.Forms.TrackBar();
            this.CmykMBar = new System.Windows.Forms.TrackBar();
            this.CmykCBar = new System.Windows.Forms.TrackBar();
            this.ColorDispayBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RgbBBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgbGBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgbRBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HslSBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HslLBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HslHBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmykKBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmykYBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmykMBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmykCBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorDispayBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorDialogButton
            // 
            resources.ApplyResources(this.ColorDialogButton, "ColorDialogButton");
            this.ColorDialogButton.Name = "ColorDialogButton";
            this.ColorDialogButton.UseVisualStyleBackColor = true;
            this.ColorDialogButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.RgbBBox);
            this.groupBox1.Controls.Add(this.RgbGBox);
            this.groupBox1.Controls.Add(this.RgbRBox);
            this.groupBox1.Controls.Add(this.RgbBBar);
            this.groupBox1.Controls.Add(this.RgbGBar);
            this.groupBox1.Controls.Add(this.RgbRBar);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // RgbBBox
            // 
            resources.ApplyResources(this.RgbBBox, "RgbBBox");
            this.RgbBBox.Name = "RgbBBox";
            this.RgbBBox.TextChanged += new System.EventHandler(this.RgbBBox_TextChanged);
            // 
            // RgbGBox
            // 
            resources.ApplyResources(this.RgbGBox, "RgbGBox");
            this.RgbGBox.Name = "RgbGBox";
            this.RgbGBox.TextChanged += new System.EventHandler(this.RgbGBox_TextChanged);
            // 
            // RgbRBox
            // 
            resources.ApplyResources(this.RgbRBox, "RgbRBox");
            this.RgbRBox.Name = "RgbRBox";
            this.RgbRBox.TextChanged += new System.EventHandler(this.RgbRBox_TextChanged);
            // 
            // RgbBBar
            // 
            resources.ApplyResources(this.RgbBBar, "RgbBBar");
            this.RgbBBar.Maximum = 255;
            this.RgbBBar.Name = "RgbBBar";
            this.RgbBBar.Scroll += new System.EventHandler(this.RgbBBar_Scroll);
            // 
            // RgbGBar
            // 
            resources.ApplyResources(this.RgbGBar, "RgbGBar");
            this.RgbGBar.Maximum = 255;
            this.RgbGBar.Name = "RgbGBar";
            this.RgbGBar.Scroll += new System.EventHandler(this.RgbGBar_Scroll);
            // 
            // RgbRBar
            // 
            resources.ApplyResources(this.RgbRBar, "RgbRBar");
            this.RgbRBar.Maximum = 255;
            this.RgbRBar.Name = "RgbRBar";
            this.RgbRBar.Scroll += new System.EventHandler(this.RgbRBar_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.percent1);
            this.groupBox2.Controls.Add(this.HslSBox);
            this.groupBox2.Controls.Add(this.HslLBox);
            this.groupBox2.Controls.Add(this.HslHBox);
            this.groupBox2.Controls.Add(this.HslSBar);
            this.groupBox2.Controls.Add(this.HslLBar);
            this.groupBox2.Controls.Add(this.HslHBar);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // percent1
            // 
            resources.ApplyResources(this.percent1, "percent1");
            this.percent1.Name = "percent1";
            // 
            // HslSBox
            // 
            resources.ApplyResources(this.HslSBox, "HslSBox");
            this.HslSBox.Name = "HslSBox";
            this.HslSBox.TextChanged += new System.EventHandler(this.HlsSBox_TextChanged);
            // 
            // HslLBox
            // 
            resources.ApplyResources(this.HslLBox, "HslLBox");
            this.HslLBox.Name = "HslLBox";
            this.HslLBox.TextChanged += new System.EventHandler(this.HlsLBox_TextChanged);
            // 
            // HslHBox
            // 
            resources.ApplyResources(this.HslHBox, "HslHBox");
            this.HslHBox.Name = "HslHBox";
            this.HslHBox.TextChanged += new System.EventHandler(this.HlsHBox_TextChanged);
            // 
            // HslSBar
            // 
            resources.ApplyResources(this.HslSBar, "HslSBar");
            this.HslSBar.Maximum = 100;
            this.HslSBar.Name = "HslSBar";
            this.HslSBar.Scroll += new System.EventHandler(this.HlsSBar_Scroll);
            // 
            // HslLBar
            // 
            resources.ApplyResources(this.HslLBar, "HslLBar");
            this.HslLBar.Maximum = 100;
            this.HslLBar.Name = "HslLBar";
            this.HslLBar.Scroll += new System.EventHandler(this.HlsLBar_Scroll);
            // 
            // HslHBar
            // 
            resources.ApplyResources(this.HslHBar, "HslHBar");
            this.HslHBar.Maximum = 360;
            this.HslHBar.Name = "HslHBar";
            this.HslHBar.Scroll += new System.EventHandler(this.HlsHBar_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.CmykKBox);
            this.groupBox3.Controls.Add(this.CmykYBox);
            this.groupBox3.Controls.Add(this.CmykKBar);
            this.groupBox3.Controls.Add(this.CmykMBox);
            this.groupBox3.Controls.Add(this.CmykCBox);
            this.groupBox3.Controls.Add(this.CmykYBar);
            this.groupBox3.Controls.Add(this.CmykMBar);
            this.groupBox3.Controls.Add(this.CmykCBar);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // CmykKBox
            // 
            resources.ApplyResources(this.CmykKBox, "CmykKBox");
            this.CmykKBox.Name = "CmykKBox";
            this.CmykKBox.TextChanged += new System.EventHandler(this.CmykKBox_TextChanged);
            // 
            // CmykYBox
            // 
            resources.ApplyResources(this.CmykYBox, "CmykYBox");
            this.CmykYBox.Name = "CmykYBox";
            this.CmykYBox.TextChanged += new System.EventHandler(this.CmykYBox_TextChanged);
            // 
            // CmykKBar
            // 
            resources.ApplyResources(this.CmykKBar, "CmykKBar");
            this.CmykKBar.Maximum = 100;
            this.CmykKBar.Name = "CmykKBar";
            this.CmykKBar.Value = 100;
            this.CmykKBar.Scroll += new System.EventHandler(this.CmykKBar_Scroll);
            // 
            // CmykMBox
            // 
            resources.ApplyResources(this.CmykMBox, "CmykMBox");
            this.CmykMBox.Name = "CmykMBox";
            this.CmykMBox.TextChanged += new System.EventHandler(this.CmykMBox_TextChanged);
            // 
            // CmykCBox
            // 
            resources.ApplyResources(this.CmykCBox, "CmykCBox");
            this.CmykCBox.Name = "CmykCBox";
            this.CmykCBox.TextChanged += new System.EventHandler(this.CmykCBox_TextChanged);
            // 
            // CmykYBar
            // 
            resources.ApplyResources(this.CmykYBar, "CmykYBar");
            this.CmykYBar.Maximum = 100;
            this.CmykYBar.Name = "CmykYBar";
            this.CmykYBar.Scroll += new System.EventHandler(this.CmykYBar_Scroll);
            // 
            // CmykMBar
            // 
            resources.ApplyResources(this.CmykMBar, "CmykMBar");
            this.CmykMBar.Maximum = 100;
            this.CmykMBar.Name = "CmykMBar";
            this.CmykMBar.Scroll += new System.EventHandler(this.CmykMBar_Scroll);
            // 
            // CmykCBar
            // 
            resources.ApplyResources(this.CmykCBar, "CmykCBar");
            this.CmykCBar.Maximum = 100;
            this.CmykCBar.Name = "CmykCBar";
            this.CmykCBar.Scroll += new System.EventHandler(this.CmykCBar_Scroll);
            // 
            // ColorDispayBox
            // 
            this.ColorDispayBox.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ColorDispayBox, "ColorDispayBox");
            this.ColorDispayBox.Name = "ColorDispayBox";
            this.ColorDispayBox.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.InfoLabel);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.InfoLabel, "InfoLabel");
            this.InfoLabel.Name = "InfoLabel";
            // 
            // ColorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ColorDispayBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ColorDialogButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RgbBBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgbGBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RgbRBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HslSBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HslLBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HslHBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmykKBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmykYBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmykMBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmykCBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorDispayBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button ColorDialogButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RgbBBox;
        private System.Windows.Forms.TextBox RgbGBox;
        private System.Windows.Forms.TextBox RgbRBox;
        private System.Windows.Forms.TrackBar RgbBBar;
        private System.Windows.Forms.TrackBar RgbGBar;
        private System.Windows.Forms.TrackBar RgbRBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label percent1;
        private System.Windows.Forms.TextBox HslSBox;
        private System.Windows.Forms.TextBox HslLBox;
        private System.Windows.Forms.TextBox HslHBox;
        private System.Windows.Forms.TrackBar HslSBar;
        private System.Windows.Forms.TrackBar HslLBar;
        private System.Windows.Forms.TrackBar HslHBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CmykKBox;
        private System.Windows.Forms.TextBox CmykYBox;
        private System.Windows.Forms.TrackBar CmykKBar;
        private System.Windows.Forms.TextBox CmykMBox;
        private System.Windows.Forms.TextBox CmykCBox;
        private System.Windows.Forms.TrackBar CmykYBar;
        private System.Windows.Forms.TrackBar CmykMBar;
        private System.Windows.Forms.TrackBar CmykCBar;
        private System.Windows.Forms.PictureBox ColorDispayBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label InfoLabel;
    }
}

