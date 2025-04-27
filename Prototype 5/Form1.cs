using System;
using System.Linq;
using System.Windows.Forms;

namespace Prototype_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text;
                if (input.Length > 40)
                {
                    MessageBox.Show("Input string must be at most 40 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!input.All(c => c >= 'A' && c <= 'Z'))
                {
                    MessageBox.Show("Input must contain only capital letters (A-Z).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtShift.Text, out int shift) || shift < -25 || shift > 25)
                {
                    MessageBox.Show("Shift value must be between -25 and 25.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var processor = new StringProcessing(input, shift);

                lblEncoded.Text = "Encoded: " + processor.Print();
                lblSorted.Text = "Sorted: " + processor.Sort();
                lblInputCodes.Text = "Input ASCII: " + string.Join(", ", processor.InputCode());
                lblOutputCodes.Text = "Output ASCII: " + string.Join(", ", processor.OutputCode());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtShift.Text = "";
            lblEncoded.Text = "";
            lblSorted.Text = "";
            lblInputCodes.Text = "";
            lblOutputCodes.Text = "";
            txtInput.Focus(); // Set focus back to input
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtShift.Text = "";
            lblEncoded.Text = "Encoded:";
            lblSorted.Text = "Sorted:";
            lblInputCodes.Text = "Input ASCII:";
            lblOutputCodes.Text = "Output ASCII:";
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            int charCount = txtInput.Text.Length;
            lblCharCount.Text = $"Characters: {charCount}/40";
        }

    }
}
