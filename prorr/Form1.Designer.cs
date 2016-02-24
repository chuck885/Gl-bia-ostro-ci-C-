namespace prorr
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.obraz = new System.Windows.Forms.PictureBox();
            this.trackF = new System.Windows.Forms.TrackBar();
            this.trackFocal = new System.Windows.Forms.TrackBar();
            this.f = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.Label();
            this.focal1 = new System.Windows.Forms.Label();
            this.focal = new System.Windows.Forms.Label();
            this.distance1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dof = new System.Windows.Forms.Label();
            this.hip = new System.Windows.Forms.Label();
            this.resultDOF = new System.Windows.Forms.Button();
            this.DOFn1 = new System.Windows.Forms.Label();
            this.DOFf1 = new System.Windows.Forms.Label();
            this.DOFn = new System.Windows.Forms.Label();
            this.DOFf = new System.Windows.Forms.Label();
            this.procent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.obraz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFocal)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "city",
            "lake"});
            this.comboBox2.Location = new System.Drawing.Point(52, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "(wybierz tło)";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tło";
            // 
            // obraz
            // 
            this.obraz.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.obraz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.obraz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obraz.Location = new System.Drawing.Point(292, 12);
            this.obraz.Name = "obraz";
            this.obraz.Size = new System.Drawing.Size(480, 360);
            this.obraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obraz.TabIndex = 0;
            this.obraz.TabStop = false;
            // 
            // trackF
            // 
            this.trackF.Location = new System.Drawing.Point(75, 189);
            this.trackF.Maximum = 64;
            this.trackF.Minimum = 1;
            this.trackF.Name = "trackF";
            this.trackF.Size = new System.Drawing.Size(211, 45);
            this.trackF.TabIndex = 5;
            this.trackF.Value = 1;
            this.trackF.Scroll += new System.EventHandler(this.trackF_Scroll);
            // 
            // trackFocal
            // 
            this.trackFocal.Location = new System.Drawing.Point(75, 234);
            this.trackFocal.Maximum = 300;
            this.trackFocal.Minimum = 24;
            this.trackFocal.Name = "trackFocal";
            this.trackFocal.Size = new System.Drawing.Size(200, 45);
            this.trackFocal.TabIndex = 6;
            this.trackFocal.Value = 24;
            this.trackFocal.Scroll += new System.EventHandler(this.trackFocal_Scroll);
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(12, 197);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(16, 13);
            this.f.TabIndex = 13;
            this.f.Text = "f=";
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.Location = new System.Drawing.Point(49, 197);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(13, 13);
            this.f1.TabIndex = 14;
            this.f1.Text = "1";
            // 
            // focal1
            // 
            this.focal1.AutoSize = true;
            this.focal1.Location = new System.Drawing.Point(9, 247);
            this.focal1.Name = "focal1";
            this.focal1.Size = new System.Drawing.Size(19, 13);
            this.focal1.TabIndex = 15;
            this.focal1.Text = "F=";
            // 
            // focal
            // 
            this.focal.AutoSize = true;
            this.focal.Location = new System.Drawing.Point(49, 247);
            this.focal.Name = "focal";
            this.focal.Size = new System.Drawing.Size(19, 13);
            this.focal.TabIndex = 16;
            this.focal.Text = "24";
            // 
            // distance1
            // 
            this.distance1.AutoSize = true;
            this.distance1.Location = new System.Drawing.Point(12, 285);
            this.distance1.Name = "distance1";
            this.distance1.Size = new System.Drawing.Size(73, 13);
            this.distance1.TabIndex = 17;
            this.distance1.Text = "Odległość (m)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Odległość Tła";
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(117, 285);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(56, 20);
            this.distance.TabIndex = 20;
            this.distance.Text = "0,5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Głębia ostrości (m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Hiperfokalna (m)";
            // 
            // dof
            // 
            this.dof.AutoSize = true;
            this.dof.Location = new System.Drawing.Point(103, 384);
            this.dof.Name = "dof";
            this.dof.Size = new System.Drawing.Size(13, 13);
            this.dof.TabIndex = 24;
            this.dof.Text = "_";
            // 
            // hip
            // 
            this.hip.AutoSize = true;
            this.hip.Location = new System.Drawing.Point(103, 416);
            this.hip.Name = "hip";
            this.hip.Size = new System.Drawing.Size(13, 13);
            this.hip.TabIndex = 25;
            this.hip.Text = "_";
            // 
            // resultDOF
            // 
            this.resultDOF.Location = new System.Drawing.Point(24, 71);
            this.resultDOF.Name = "resultDOF";
            this.resultDOF.Size = new System.Drawing.Size(92, 53);
            this.resultDOF.TabIndex = 26;
            this.resultDOF.Text = "Start";
            this.resultDOF.UseVisualStyleBackColor = true;
            this.resultDOF.Click += new System.EventHandler(this.resultDOF_Click);
            // 
            // DOFn1
            // 
            this.DOFn1.AutoSize = true;
            this.DOFn1.Location = new System.Drawing.Point(205, 385);
            this.DOFn1.Name = "DOFn1";
            this.DOFn1.Size = new System.Drawing.Size(38, 13);
            this.DOFn1.TabIndex = 27;
            this.DOFn1.Text = "Dn (m)";
            // 
            // DOFf1
            // 
            this.DOFf1.AutoSize = true;
            this.DOFf1.Location = new System.Drawing.Point(205, 416);
            this.DOFf1.Name = "DOFf1";
            this.DOFf1.Size = new System.Drawing.Size(35, 13);
            this.DOFf1.TabIndex = 28;
            this.DOFf1.Text = "Df (m)";
            // 
            // DOFn
            // 
            this.DOFn.AutoSize = true;
            this.DOFn.Location = new System.Drawing.Point(246, 384);
            this.DOFn.Name = "DOFn";
            this.DOFn.Size = new System.Drawing.Size(13, 13);
            this.DOFn.TabIndex = 29;
            this.DOFn.Text = "_";
            // 
            // DOFf
            // 
            this.DOFf.AutoSize = true;
            this.DOFf.Location = new System.Drawing.Point(246, 416);
            this.DOFf.Name = "DOFf";
            this.DOFf.Size = new System.Drawing.Size(13, 13);
            this.DOFf.TabIndex = 30;
            this.DOFf.Text = "_";
            this.DOFf.Click += new System.EventHandler(this.DOFf_Click);
            // 
            // procent
            // 
            this.procent.AutoSize = true;
            this.procent.Location = new System.Drawing.Point(729, 385);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(13, 13);
            this.procent.TabIndex = 31;
            this.procent.Text = "_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Część głębi za osią obiektu (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(136, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "∞";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.DOFf);
            this.Controls.Add(this.DOFn);
            this.Controls.Add(this.DOFf1);
            this.Controls.Add(this.DOFn1);
            this.Controls.Add(this.resultDOF);
            this.Controls.Add(this.hip);
            this.Controls.Add(this.dof);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.distance1);
            this.Controls.Add(this.focal);
            this.Controls.Add(this.focal1);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.f);
            this.Controls.Add(this.trackFocal);
            this.Controls.Add(this.trackF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.obraz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obraz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox obraz;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackFocal;
        private System.Windows.Forms.TrackBar trackF;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label f1;
        private System.Windows.Forms.Label focal1;
        private System.Windows.Forms.Label focal;
        private System.Windows.Forms.Label distance1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dof;
        private System.Windows.Forms.Label hip;
        private System.Windows.Forms.Button resultDOF;
        private System.Windows.Forms.Label DOFn1;
        private System.Windows.Forms.Label DOFf1;
        private System.Windows.Forms.Label DOFn;
        private System.Windows.Forms.Label DOFf;
        private System.Windows.Forms.Label procent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

