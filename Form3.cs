using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Csharpusing System;
namespace BomDia
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            // Set up the form
            this.Text = "Calculator";
            this.Width = 300;
            this.Height = 400;

            // Create a TextBox for displaying input/output
            TextBox display = new TextBox
            {
                Name = "Display",
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Right,
                Font = new System.Drawing.Font("Arial", 16),
                Dock = DockStyle.Top,
                Height = 50
            };
            //this.Controls.Add(display);
            this.splitContainer1.Panel1.Controls.Add(display);

            // Create a panel to hold buttons
            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
            //this.Controls.Add(buttonPanel);
            this.splitContainer1.Panel2.Controls.Add(buttonPanel);
            // Define button labels
            string[] buttonLabels = { "7", "8", "9", "/", "4", "5", "6", "*", "1", "2", "3", "-", "0", ".", "=", "+" ,"CE"};

            // Add buttons dynamically
            int x = 0, y = 0;
            foreach (string label in buttonLabels)
            {
                Button button = new Button
                {
                    Text = label,
                    Width = 50,
                    Height = 50,
                    Left = x * 60,
                    Top = y * 60
                };

                // Add click event for buttons
                button.Click += (CalculatorForm_Load, Click) =>
                {
                    if (label == "=")
                    {
                        try
                        {
                            display.Text = new DataTable().Compute(display.Text, null).ToString();
                        }
                        catch
                        {
                            display.Text = "Error";
                        }
                    }
                    else
                    {
                        display.Text += label;
                    }
                    if(label == "CE")
                    {
                        display.ResetText();
                        display.Refresh();
                        return;
                    }
                };

                buttonPanel.Controls.Add(button);

                x++;
                if (x > 3) { x = 0; y++; }
            }
        
        }
    }
}
