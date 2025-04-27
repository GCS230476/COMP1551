namespace Prototype_5
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
            label2 = new Label();
            txtInput = new TextBox();
            txtShift = new TextBox();
            btnProcess = new Button();
            lblEncoded = new Label();
            lblSorted = new Label();
            lblInputCodes = new Label();
            lblOutputCodes = new Label();
            label3 = new Label();
            btnClear = new Button();
            lblCharCount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 95);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter string (A-Z)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 138);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter shift (-25 to 25)";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(232, 92);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(436, 27);
            txtInput.TabIndex = 2;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // txtShift
            // 
            txtShift.Location = new Point(232, 135);
            txtShift.Name = "txtShift";
            txtShift.Size = new Size(436, 27);
            txtShift.TabIndex = 2;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(312, 168);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(94, 29);
            btnProcess.TabIndex = 3;
            btnProcess.Text = "Process";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // lblEncoded
            // 
            lblEncoded.AutoSize = true;
            lblEncoded.Location = new Point(149, 218);
            lblEncoded.Name = "lblEncoded";
            lblEncoded.Size = new Size(70, 20);
            lblEncoded.TabIndex = 4;
            lblEncoded.Text = "Encoded:";
            // 
            // lblSorted
            // 
            lblSorted.AutoSize = true;
            lblSorted.Location = new Point(163, 249);
            lblSorted.Name = "lblSorted";
            lblSorted.Size = new Size(56, 20);
            lblSorted.TabIndex = 4;
            lblSorted.Text = "Sorted:";
            // 
            // lblInputCodes
            // 
            lblInputCodes.AutoSize = true;
            lblInputCodes.Location = new Point(134, 279);
            lblInputCodes.Name = "lblInputCodes";
            lblInputCodes.Size = new Size(85, 20);
            lblInputCodes.TabIndex = 4;
            lblInputCodes.Text = "Input ASCII:";
            // 
            // lblOutputCodes
            // 
            lblOutputCodes.AutoSize = true;
            lblOutputCodes.Location = new Point(122, 308);
            lblOutputCodes.Name = "lblOutputCodes";
            lblOutputCodes.Size = new Size(97, 20);
            lblOutputCodes.TabIndex = 4;
            lblOutputCodes.Text = "Output ASCII:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 29);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 5;
            label3.Text = "ASCII ENCODE";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(453, 168);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // lblCharCount
            // 
            lblCharCount.AutoSize = true;
            lblCharCount.Location = new Point(553, 95);
            lblCharCount.Name = "lblCharCount";
            lblCharCount.Size = new Size(115, 20);
            lblCharCount.TabIndex = 7;
            lblCharCount.Text = "Characters: 0/40";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCharCount);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(lblOutputCodes);
            Controls.Add(lblInputCodes);
            Controls.Add(lblSorted);
            Controls.Add(lblEncoded);
            Controls.Add(btnProcess);
            Controls.Add(txtShift);
            Controls.Add(txtInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtInput;
        private TextBox txtShift;
        private Button btnProcess;
        private Label lblEncoded;
        private Label lblSorted;
        private Label lblInputCodes;
        private Label lblOutputCodes;
        private Label label3;
        private Button btnClear;
        private Label lblCharCount;
    }
}
