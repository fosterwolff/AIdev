namespace HelloWorldWindowApp;

using System.Windows.Forms;
using System.Drawing;

public partial class Form1 : Form
{
    private TextBox usernameTextBox;
    private TextBox passwordTextBox;
    private Button loginButton;
    private Label statusLabel;

    public Form1()
    {
        InitializeComponent();
        // Set the form properties
        this.Text = "Hello World Application";
        this.Size = new System.Drawing.Size(400, 350);
        this.StartPosition = FormStartPosition.CenterScreen;
        
        // Create username label and textbox
        Label usernameLabel = new Label
        {
            Text = "Username:",
            Size = new System.Drawing.Size(100, 25),
            Location = new System.Drawing.Point(50, 50),
            TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        };
        
        usernameTextBox = new TextBox
        {
            Size = new System.Drawing.Size(200, 25),
            Location = new System.Drawing.Point(150, 50),
            Text = ""
        };
        
        // Create password label and textbox
        Label passwordLabel = new Label
        {
            Text = "Password:",
            Size = new System.Drawing.Size(100, 25),
            Location = new System.Drawing.Point(50, 90),
            TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        };
        
        passwordTextBox = new TextBox
        {
            Size = new System.Drawing.Size(200, 25),
            Location = new System.Drawing.Point(150, 90),
            PasswordChar = '*',
            Text = ""
        };
        
        // Create login button
        loginButton = new Button
        {
            Text = "Login",
            Size = new System.Drawing.Size(100, 30),
            Location = new System.Drawing.Point(150, 140)
        };
        loginButton.Click += LoginButton_Click;
        
        // Create status label
        statusLabel = new Label
        {
            Text = "",
            Size = new System.Drawing.Size(300, 25),
            Location = new System.Drawing.Point(50, 180),
            ForeColor = Color.Red,
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        };
        
        // Create a label to display "Hello World"
        Label helloLabel = new Label
        {
            Text = "Hello World!",
            Font = new System.Drawing.Font("Arial", 24, System.Drawing.FontStyle.Bold),
            Size = new System.Drawing.Size(300, 50),
            Location = new System.Drawing.Point(50, 220),
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        };
        
        // Add all controls to the form
        this.Controls.Add(usernameLabel);
        this.Controls.Add(usernameTextBox);
        this.Controls.Add(passwordLabel);
        this.Controls.Add(passwordTextBox);
        this.Controls.Add(loginButton);
        this.Controls.Add(statusLabel);
        this.Controls.Add(helloLabel);
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        // Simple validation - check if username and password are not empty
        if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
        {
            statusLabel.Text = "Please enter a username";
            return;
        }
        
        if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
        {
            statusLabel.Text = "Please enter a password";
            return;
        }
        
        // Simple validation - check if username and password are valid
        if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "password")
        {
            statusLabel.Text = "Login successful!";
            statusLabel.ForeColor = Color.Green;
        }
        else
        {
            statusLabel.Text = "Invalid username or password";
            statusLabel.ForeColor = Color.Red;
        }
    }
}
