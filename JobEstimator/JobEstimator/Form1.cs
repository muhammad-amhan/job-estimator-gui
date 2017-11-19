using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //I used this for reading and writing (e.g. saving to a file or opening a file for example).

// The name of the application I am developing.
namespace JobEstimator
{
    public partial class frmMain : Form
    {
        /*Below I have declared the variables with values that will not change for program life time, using CONSTANTS.
         * those values are static and stored in the application to provide info to the customer */

        const int LABOUR = 40;
        const int TRAVEL = 1;
        const int PLASTIC = 2;
        const int COPPER = 3;
        const int CHROME = 4;
        const double VAT = 20;

        //I have set the variables that require an input value from the user interaction.
        int hours = 0;
        int miles = 0;
        int pipeLength = 0;
        int labourSubTotal;
        int travelSubTotal;
        int pipeSubTotal;
        double vatTotal;
        double netSubTotal;
        double finalTotal;
        string message;

        public frmMain()
        {
            InitializeComponent();
        }

        /*This is the first button declaring the calculation operations to produce the expected output as a result of the users' input.
         * It also contains messages produced for the user to identify the calculation results. */

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //These are the variables that require the users' input which will be calculated and displayed on the user interface. 
            hours = 0;
            miles = 0;
            pipeLength = 0;
            labourSubTotal = 0;
            travelSubTotal = 0;
            pipeSubTotal = 0;
            vatTotal = 0;
            netSubTotal = 0;
            finalTotal = 0;

            //I have converted string to a number so that the user input value is a numeric and the program can understand it.
            hours = Convert.ToInt32(txtLabour.Text);
            miles = Convert.ToInt32(txtTravel.Text);

            /*This is the first message that will be displayed as part of the program output on the user interface.
             * The \n refers to a new line whithin the program, so the messages are not on one line.
             * The messages below is to introduce the customer to the comapny name and program nature. */

            message = "Pete Taylor's Plumbing Company\n";
            message += "Job Quote Estimate \n\n";

            //Logical operations to calculate the total labour cost, and the total travel cost.
            labourSubTotal = LABOUR * hours;
            travelSubTotal = TRAVEL * miles;

            //I have set the hours and labour cost per hour, then showed the total cost on the same line to make it clear for the user.
            message += "---------------------------\n";
            message += hours + " hours @ £" + LABOUR + " per hr = £" + labourSubTotal + "\n";

            //I have set the miles and travel cost per mile, then showed the total cost in the same message line to make it clear.
            message += miles + " miles @ £" + TRAVEL + " per mile = £" + travelSubTotal + "\n\n";

            //I have divided the output screen to refer to each section using the below message.
            message += "-------- Materials --------\n";

            /* The following if statement set conditions for the user choice of material. 
             * Each condition applies only if the option is checked. */

            if (checkBox1.Checked)
            {
                /* I have converted the input value into numeric value so the program understand how to carry out a logic calcualtion.
                 * I have included a logic operation for the program to know what to do with the inputted information.
                 * Finally I have included a message that contains the previous steps to make it clear to the customer. */

                pipeLength = Convert.ToInt32(txtPlasticPipes.Text);
                pipeSubTotal = pipeLength * PLASTIC;
                message += pipeLength + "m of plastic piping @ £" + PLASTIC + " per metre = £" + pipeSubTotal + "\n";
            }

            if (checkBox2.Checked)
            {
                //Previous comment applies.
                pipeLength = Convert.ToInt32(txtCopperPipes.Text);
                pipeSubTotal += pipeLength * COPPER;
                message += pipeLength + "m of copper piping @ £" + COPPER + " per metre = £" + pipeSubTotal + "\n";
            }

            if (checkBox3.Checked)
            {
                //Previous comment applies.
                pipeLength = Convert.ToInt32(txtChromePipes.Text);
                pipeSubTotal += pipeLength * CHROME;
                message += pipeLength + "m of chrome piping @ £" + CHROME + " per metre = £" + pipeSubTotal + "\n";
            }

            //This is the final subtotal that calculates the user requirements only, excluding the VAT costs.
            netSubTotal = labourSubTotal + travelSubTotal + pipeSubTotal;

            /* The below message shows the customer the above operation output, to clarify what the user is looking at.
             * I have seperated the output screen into sections, and this is the final costing section. */

            message += "\n----- Final Costings ------\n";
            message += "Sub total: £ " + netSubTotal + "\n";

            //Here is the VAT cost taken from the netSubTotal and shown as a seperate result, with a message that refers at it.
            vatTotal = (VAT / 100 * netSubTotal);
            message += "VAT: £ " + vatTotal + "\n";

            //The actual final cost including VAT is calculated through the below operation with a message that identifies it to the user.
            finalTotal = vatTotal + netSubTotal;

            message += "Final total: £ " + finalTotal + "\n";

            lblQuote.Text = message;
        }
        // This is the Clear button that works on resetting all values to default value which is set below to (0) as well as checked materials.

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblQuote.Text = "";
            txtLabour.Text = "0";
            txtPlasticPipes.Text = "0";
            txtCopperPipes.Text = "0";
            txtChromePipes.Text = "0";
            txtTravel.Text = "0";

            hours = 0;
            miles = 0;
            pipeLength = 0;
            labourSubTotal = 0;
            travelSubTotal = 0;
            pipeSubTotal = 0;
            vatTotal = 0;
            netSubTotal = 0;
            finalTotal = 0;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        /*The following code checks if the customer has checked any material option, then the textbox for that material is enabled, otherwise it remains disabled.
         * For an easier method which I haven't tried, from the event handlers choose (checkStateChange) then:
         * textBox1.Enabled = (checkBox1.CheckState == CheckState.Checked);
         */
        private void txtPlasticPipes_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                txtPlasticPipes.Enabled = false;
                txtPlasticPipes.Text = "0";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPlasticPipes.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select your material.");
                txtPlasticPipes.Text = "0";
            }
        }
        //*************************************************************************
        private void txtCopperPipes_TextChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                txtCopperPipes.Enabled = false;
                txtCopperPipes.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtCopperPipes.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select your material.");
                txtCopperPipes.Text = "0";
            }
        }
        //*************************************************************************
        private void txtChromePipes_TextChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                txtChromePipes.Enabled = false;
                txtChromePipes.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                txtChromePipes.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select your material.");
                txtChromePipes.Text = "0";
            }
        }

        // In the follwoing code, I have added a validation to the textboxes to accept only numeric data.
        private void txtLabour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTravel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;

            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPlasticPipes_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtCopperPipes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtChromePipes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        // This is to link two different form together.
        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            new Help().Show();
            //this.Hide(); only if I wanted to hide this current window while opeining the other.
        }

        private void generalHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Help().Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        // In the following code, I have added a PLACEHOLDER with the number (0) to the textboxes.
        private void txtLabour_Enter(object sender, EventArgs e)
        {
            if (txtLabour.Text == "0")
            {
                txtLabour.Text = "";
            }
        }

        private void txtLabour_Leave(object sender, EventArgs e)
        {
            if (txtLabour.Text == "")
            {
                txtLabour.Text = "0";
            }
        }

        private void txtTravel_Enter(object sender, EventArgs e)
        {
            if (txtTravel.Text == "0")
            {
                txtTravel.Text = "";
            }
        }

        private void txtTravel_Leave(object sender, EventArgs e)
        {
            if (txtTravel.Text == "")
            {
                txtTravel.Text = "0";
            }
        }

        private void txtPlasticPipes_Enter(object sender, EventArgs e)
        {
            if (txtPlasticPipes.Text == "0")
            {
                txtPlasticPipes.Text = "";
            }
        }

        private void txtPlasticPipes_Leave(object sender, EventArgs e)
        {
            if (txtPlasticPipes.Text == "")
            {
                txtPlasticPipes.Text = "0";
            }
        }

        private void txtCopperPipes_Enter(object sender, EventArgs e)
        {
            if (txtCopperPipes.Text == "0")
            {
                txtCopperPipes.Text = "";
            }
        }

        private void txtCopperPipes_Leave(object sender, EventArgs e)
        {
            if (txtCopperPipes.Text == "")
            {
                txtCopperPipes.Text = "0";
            }
        }

        private void txtChromePipes_Enter(object sender, EventArgs e)
        {
            if (txtChromePipes.Text == "0")
            {
                txtChromePipes.Text = "";
            }
        }

        private void txtChromePipes_Leave(object sender, EventArgs e)
        {
            if (txtChromePipes.Text == "")
            {
                txtChromePipes.Text = "0";
            }
        }

        //The following code I used to add an option for the customer to save the output as a text file.
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Save as";
                save.Filter = "Text Files (*.txt)|*.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter write = new StreamWriter(File.Create(save.FileName));
                    write.Write(lblQuote.Text);
                    write.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please choose the correct file type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*
             * StreamWriter Writer = new StreamWriter(saveFileDialog1.FileName);
               Writer.Write(lblQuote);
               Writer.Close();
            
             * using TextWriter tw = new StreamWriter ("test.txt");
               tw.WriteLine(lblQuote);
             */
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save as";
            save.Filter = "Text Files (*.txt)|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.Write(lblQuote.Text);
                write.Dispose();           }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Title = "Open File";
                open.Filter = "Text Files (*.txt)|*.txt"; // The (*) means look for anything there, so for example |All Files (*.*)|*.* is to look at anything.

                if (open.ShowDialog() == DialogResult.OK)
                {
                    StreamReader read = new StreamReader(File.OpenRead(open.FileName));
                    lblQuote.Text = read.ReadToEnd();
                    read.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //For the below code, I have used it to copy the output to the customer's machine clipboard to enable him/her to copy and paste anywhere they wish.
        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();  //Clear if any old value is there in Clipboard        
            Clipboard.SetText(lblQuote.Text);  //Copy text to Clipboard
            string strClip = Clipboard.GetText();  //Get text from Clipboard
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(lblQuote.Text);
            string strClip = Clipboard.GetText();
        }

        // Finally I have added an Exit button to end the program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for considering Pete Taylor's Ltd.", "Thank You", MessageBoxButtons.OK);
                Application.ExitThread();
            }
            else
            {
                this.Activate();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                this.Activate();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
