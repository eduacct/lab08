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
            ve = new TextBox();
            m0 = new TextBox();
            label2 = new Label();
            mf = new TextBox();
            label3 = new Label();
            button1 = new Button();
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
            // ve
            // 
            ve.Location = new Point(9, 170);
            ve.Name = "ve";
            ve.Size = new Size(100, 23);
            ve.TabIndex = 1;
            // 
            // m0
            // 
            m0.Location = new Point(115, 170);
            m0.Name = "m0";
            m0.Size = new Size(100, 23);
            m0.TabIndex = 3;
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
            // mf
            // 
            mf.Location = new Point(221, 170);
            mf.Name = "mf";
            mf.Size = new Size(100, 23);
            mf.TabIndex = 5;
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
            // button1
            // 
            button1.Location = new Point(126, 199);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 230);
            Controls.Add(button1);
            Controls.Add(mf);
            Controls.Add(label3);
            Controls.Add(m0);
            Controls.Add(label2);
            Controls.Add(ve);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Rocket Equation Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ve;
        private TextBox m0;
        private Label label2;
        private TextBox mf;
        private Label label3;
        private Button button1;
    }
}
