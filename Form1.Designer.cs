namespace lab08_swe_lab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            exVelo = new TextBox();
            minit = new TextBox();
            label2 = new Label();
            mfinal = new TextBox();
            label3 = new Label();
            calc = new Button();
            result = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Exhaust Velocity";
            // 
            // exVelo
            // 
            exVelo.Location = new Point(12, 40);
            exVelo.Name = "exVelo";
            exVelo.Size = new Size(100, 23);
            exVelo.TabIndex = 1;
            // 
            // minit
            // 
            minit.Location = new Point(118, 40);
            minit.Name = "minit";
            minit.Size = new Size(100, 23);
            minit.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 22);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Initial Mass";
            // 
            // mfinal
            // 
            mfinal.Location = new Point(224, 40);
            mfinal.Name = "mfinal";
            mfinal.Size = new Size(100, 23);
            mfinal.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 22);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Final Mass";
            // 
            // calc
            // 
            calc.Location = new Point(145, 153);
            calc.Name = "calc";
            calc.Size = new Size(75, 23);
            calc.TabIndex = 6;
            calc.Text = "Calculate";
            calc.UseVisualStyleBackColor = true;
            calc.Click += calc_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(12, 19);
            result.Name = "result";
            result.Size = new Size(43, 15);
            result.TabIndex = 7;
            result.Text = "output";
            result.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(result);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 52);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Output";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(exVelo);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(mfinal);
            groupBox2.Controls.Add(minit);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 77);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Input";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F);
            label4.Location = new Point(296, 19);
            label4.Name = "label4";
            label4.Size = new Size(64, 45);
            label4.TabIndex = 10;
            label4.Text = "🚀";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 191);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(calc);
            Name = "Form1";
            Text = "Rocket Equation Calculator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox exVelo;
        private TextBox minit;
        private Label label2;
        private TextBox mfinal;
        private Label label3;
        private Button calc;
        private Label result;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
    }
}
