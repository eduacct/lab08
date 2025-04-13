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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 152);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // exVelo
            // 
            exVelo.Location = new Point(9, 170);
            exVelo.Name = "exVelo";
            exVelo.Size = new Size(100, 23);
            exVelo.TabIndex = 1;
            // 
            // minit
            // 
            minit.Location = new Point(115, 170);
            minit.Name = "minit";
            minit.Size = new Size(100, 23);
            minit.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 152);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // mfinal
            // 
            mfinal.Location = new Point(221, 170);
            mfinal.Name = "mfinal";
            mfinal.Size = new Size(100, 23);
            mfinal.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 152);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // calc
            // 
            calc.Location = new Point(126, 199);
            calc.Name = "calc";
            calc.Size = new Size(75, 23);
            calc.TabIndex = 6;
            calc.Text = "button1";
            calc.UseVisualStyleBackColor = true;
            calc.Click += calc_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(148, 58);
            result.Name = "result";
            result.Size = new Size(38, 15);
            result.TabIndex = 7;
            result.Text = "label4";
            result.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 230);
            Controls.Add(result);
            Controls.Add(calc);
            Controls.Add(mfinal);
            Controls.Add(label3);
            Controls.Add(minit);
            Controls.Add(label2);
            Controls.Add(exVelo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Rocket Equation Calculator";
            Load += Form1_Load;
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
    }
}
