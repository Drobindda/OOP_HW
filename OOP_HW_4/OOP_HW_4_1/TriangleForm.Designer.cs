
namespace OOP_HW_4_1
{
    partial class TriangleForm
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
            this.MainBtn = new System.Windows.Forms.Button();
            this.textBoxAB = new System.Windows.Forms.TextBox();
            this.textBoxBC = new System.Windows.Forms.TextBox();
            this.textBoxCA = new System.Windows.Forms.TextBox();
            this.AB = new System.Windows.Forms.Label();
            this.BC = new System.Windows.Forms.Label();
            this.CA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.angleBC_CA = new System.Windows.Forms.Label();
            this.angleAB_BC = new System.Windows.Forms.Label();
            this.angleCA_AB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Perimetr = new System.Windows.Forms.Label();
            this.labelPerimetrText = new System.Windows.Forms.Label();
            this.Square = new System.Windows.Forms.Label();
            this.labelSquareText = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MainBtn
            // 
            this.MainBtn.Location = new System.Drawing.Point(371, 333);
            this.MainBtn.Name = "MainBtn";
            this.MainBtn.Size = new System.Drawing.Size(115, 35);
            this.MainBtn.TabIndex = 0;
            this.MainBtn.Text = "Calculate";
            this.MainBtn.UseVisualStyleBackColor = true;
            this.MainBtn.Click += new System.EventHandler(this.MainBtn_Click);
            // 
            // textBoxAB
            // 
            this.textBoxAB.Location = new System.Drawing.Point(254, 97);
            this.textBoxAB.Name = "textBoxAB";
            this.textBoxAB.Size = new System.Drawing.Size(125, 27);
            this.textBoxAB.TabIndex = 2;
            this.textBoxAB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxBC
            // 
            this.textBoxBC.Location = new System.Drawing.Point(254, 130);
            this.textBoxBC.Name = "textBoxBC";
            this.textBoxBC.Size = new System.Drawing.Size(125, 27);
            this.textBoxBC.TabIndex = 3;
            this.textBoxBC.TextChanged += new System.EventHandler(this.textBoxBC_TextChanged);
            // 
            // textBoxCA
            // 
            this.textBoxCA.Location = new System.Drawing.Point(254, 163);
            this.textBoxCA.Name = "textBoxCA";
            this.textBoxCA.Size = new System.Drawing.Size(125, 27);
            this.textBoxCA.TabIndex = 4;
            // 
            // AB
            // 
            this.AB.AutoSize = true;
            this.AB.Location = new System.Drawing.Point(196, 100);
            this.AB.Name = "AB";
            this.AB.Size = new System.Drawing.Size(46, 20);
            this.AB.TabIndex = 5;
            this.AB.Text = "AB  =";
            // 
            // BC
            // 
            this.BC.AutoSize = true;
            this.BC.Location = new System.Drawing.Point(196, 133);
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(45, 20);
            this.BC.TabIndex = 6;
            this.BC.Text = "BC  =";
            this.BC.Click += new System.EventHandler(this.label2_Click);
            // 
            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.Location = new System.Drawing.Point(196, 166);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(46, 20);
            this.CA.TabIndex = 7;
            this.CA.Text = "CA  =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Angle (CA, AB)  =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Angle (BC, CA)  =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Angle (AB, BC)  =";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // angleBC_CA
            // 
            this.angleBC_CA.AutoSize = true;
            this.angleBC_CA.Location = new System.Drawing.Point(632, 117);
            this.angleBC_CA.Name = "angleBC_CA";
            this.angleBC_CA.Size = new System.Drawing.Size(0, 20);
            this.angleBC_CA.TabIndex = 12;
            // 
            // angleAB_BC
            // 
            this.angleAB_BC.AutoSize = true;
            this.angleAB_BC.Location = new System.Drawing.Point(630, 84);
            this.angleAB_BC.Name = "angleAB_BC";
            this.angleAB_BC.Size = new System.Drawing.Size(0, 20);
            this.angleAB_BC.TabIndex = 11;
            // 
            // angleCA_AB
            // 
            this.angleCA_AB.AutoSize = true;
            this.angleCA_AB.Location = new System.Drawing.Point(632, 150);
            this.angleCA_AB.Name = "angleCA_AB";
            this.angleCA_AB.Size = new System.Drawing.Size(0, 20);
            this.angleCA_AB.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Triangle Program";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Perimetr
            // 
            this.Perimetr.AutoSize = true;
            this.Perimetr.Location = new System.Drawing.Point(630, 186);
            this.Perimetr.Name = "Perimetr";
            this.Perimetr.Size = new System.Drawing.Size(0, 20);
            this.Perimetr.TabIndex = 16;
            this.Perimetr.Click += new System.EventHandler(this.label11_Click);
            // 
            // labelPerimetrText
            // 
            this.labelPerimetrText.AutoSize = true;
            this.labelPerimetrText.Location = new System.Drawing.Point(545, 186);
            this.labelPerimetrText.Name = "labelPerimetrText";
            this.labelPerimetrText.Size = new System.Drawing.Size(82, 20);
            this.labelPerimetrText.TabIndex = 15;
            this.labelPerimetrText.Text = "Perimetr  =";
            this.labelPerimetrText.Click += new System.EventHandler(this.label12_Click);
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Location = new System.Drawing.Point(632, 220);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(0, 20);
            this.Square.TabIndex = 21;
            this.Square.Click += new System.EventHandler(this.label13_Click);
            // 
            // labelSquareText
            // 
            this.labelSquareText.AutoSize = true;
            this.labelSquareText.Location = new System.Drawing.Point(553, 220);
            this.labelSquareText.Name = "labelSquareText";
            this.labelSquareText.Size = new System.Drawing.Size(73, 20);
            this.labelSquareText.TabIndex = 20;
            this.labelSquareText.Text = "Square  =";
            this.labelSquareText.Visible = false;
            this.labelSquareText.Click += new System.EventHandler(this.label14_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(215, 220);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 24);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Equilateral Triangle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.labelSquareText);
            this.Controls.Add(this.Perimetr);
            this.Controls.Add(this.labelPerimetrText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.angleCA_AB);
            this.Controls.Add(this.angleBC_CA);
            this.Controls.Add(this.angleAB_BC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CA);
            this.Controls.Add(this.BC);
            this.Controls.Add(this.AB);
            this.Controls.Add(this.textBoxCA);
            this.Controls.Add(this.textBoxBC);
            this.Controls.Add(this.textBoxAB);
            this.Controls.Add(this.MainBtn);
            this.Name = "TriangleForm";
            this.Text = "Triangle";
            this.Load += new System.EventHandler(this.TriangleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainBtn;
        private System.Windows.Forms.TextBox textBoxAB;
        private System.Windows.Forms.TextBox textBoxBC;
        private System.Windows.Forms.TextBox textBoxCA;
        private System.Windows.Forms.Label AB;
        private System.Windows.Forms.Label BC;
        private System.Windows.Forms.Label CA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label angleBC_CA;
        private System.Windows.Forms.Label angleAB_BC;
        private System.Windows.Forms.Label angleCA_AB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Perimetr;
        private System.Windows.Forms.Label labelPerimetrText;
        private System.Windows.Forms.Label Square;
        private System.Windows.Forms.Label labelSquareText;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}