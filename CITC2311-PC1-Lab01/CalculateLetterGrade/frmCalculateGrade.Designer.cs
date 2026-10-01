namespace CalculateLetterGrade
{
    partial class frmCalculateGrade
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
            txtNumberGrade = new TextBox();
            txtLetterGrade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtNumberGrade
            // 
            txtNumberGrade.BackColor = SystemColors.ControlLightLight;
            txtNumberGrade.BorderStyle = BorderStyle.FixedSingle;
            txtNumberGrade.Location = new Point(145, 23);
            txtNumberGrade.Name = "txtNumberGrade";
            txtNumberGrade.Size = new Size(119, 23);
            txtNumberGrade.TabIndex = 1;
            // 
            // txtLetterGrade
            // 
            txtLetterGrade.BackColor = SystemColors.Control;
            txtLetterGrade.BorderStyle = BorderStyle.FixedSingle;
            txtLetterGrade.Location = new Point(145, 52);
            txtLetterGrade.Name = "txtLetterGrade";
            txtLetterGrade.ReadOnly = true;
            txtLetterGrade.Size = new Size(119, 23);
            txtLetterGrade.TabIndex = 5;
            txtLetterGrade.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 26);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "&Number Grade:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 55);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 4;
            label2.Text = "Letter Grade:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ActiveBorder;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.ForeColor = SystemColors.ControlText;
            btnCalculate.Location = new Point(38, 98);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(86, 24);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveBorder;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.Location = new Point(178, 98);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 24);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // frmCalculateGrade
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(301, 145);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLetterGrade);
            Controls.Add(txtNumberGrade);
            Name = "frmCalculateGrade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate Letter Grade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumberGrade;
        private TextBox txtLetterGrade;
        private Label label1;
        private Label label2;
        private Button btnCalculate;
        private Button btnExit;
    }
}
