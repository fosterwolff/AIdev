namespace HelloWorldWindowApp;

using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        // Set the form properties
        this.Text = "Hello World Application";
        this.Size = new System.Drawing.Size(400, 300);
        this.StartPosition = FormStartPosition.CenterScreen;
        
        // Create a label to display "Hello World"
        Label helloLabel = new Label
        {
            Text = "Hello World!",
            Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold),
            Size = new System.Drawing.Size(300, 50),
            Location = new System.Drawing.Point(50, 100),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        };
        
        // Add the label to the form
        this.Controls.Add(helloLabel);
    }
}
