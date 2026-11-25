namespace PJCBLauncher;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        tabControl1 = new System.Windows.Forms.TabControl();
        tabPage1 = new System.Windows.Forms.TabPage();
        button5 = new System.Windows.Forms.Button();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox4 = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        checkBox2 = new System.Windows.Forms.CheckBox();
        checkBox1 = new System.Windows.Forms.CheckBox();
        button8 = new System.Windows.Forms.Button();
        label3 = new System.Windows.Forms.Label();
        progressBar1 = new System.Windows.Forms.ProgressBar();
        textBox1 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        button4 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        tabPage2 = new System.Windows.Forms.TabPage();
        label7 = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
        comboBox3 = new System.Windows.Forms.ComboBox();
        checkBox3 = new System.Windows.Forms.CheckBox();
        tabPage3 = new System.Windows.Forms.TabPage();
        button11 = new System.Windows.Forms.Button();
        button9 = new System.Windows.Forms.Button();
        label6 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        tabPage3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Controls.Add(tabPage3);
        tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        tabControl1.Location = new System.Drawing.Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(531, 343);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(button5);
        tabPage1.Controls.Add(textBox2);
        tabPage1.Controls.Add(textBox4);
        tabPage1.Controls.Add(label4);
        tabPage1.Controls.Add(checkBox2);
        tabPage1.Controls.Add(checkBox1);
        tabPage1.Controls.Add(button8);
        tabPage1.Controls.Add(label3);
        tabPage1.Controls.Add(progressBar1);
        tabPage1.Controls.Add(textBox1);
        tabPage1.Controls.Add(label2);
        tabPage1.Controls.Add(button4);
        tabPage1.Controls.Add(button2);
        tabPage1.Location = new System.Drawing.Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new System.Windows.Forms.Padding(3);
        tabPage1.Size = new System.Drawing.Size(523, 315);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Game";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        button5.Location = new System.Drawing.Point(433, 7);
        button5.Name = "button5";
        button5.Size = new System.Drawing.Size(75, 23);
        button5.TabIndex = 19;
        button5.Text = "Select";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // textBox2
        // 
        textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBox2.Location = new System.Drawing.Point(102, 8);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(325, 23);
        textBox2.TabIndex = 18;
        textBox2.TextChanged += textBox2_TextChanged;
        // 
        // textBox4
        // 
        textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBox4.Location = new System.Drawing.Point(102, 33);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(406, 23);
        textBox4.TabIndex = 17;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new System.Drawing.Point(8, 36);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(88, 15);
        label4.TabIndex = 16;
        label4.Text = "Download URL:";
        // 
        // checkBox2
        // 
        checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        checkBox2.AutoSize = true;
        checkBox2.Location = new System.Drawing.Point(294, 100);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new System.Drawing.Size(211, 19);
        checkBox2.TabIndex = 15;
        checkBox2.Text = "Launch game when done updating";
        checkBox2.UseVisualStyleBackColor = true;
        // 
        // checkBox1
        // 
        checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        checkBox1.AutoSize = true;
        checkBox1.Location = new System.Drawing.Point(157, 99);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(131, 19);
        checkBox1.TabIndex = 14;
        checkBox1.Text = "Keep launcher open";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // button8
        // 
        button8.Location = new System.Drawing.Point(6, 68);
        button8.Name = "button8";
        button8.Size = new System.Drawing.Size(113, 23);
        button8.TabIndex = 13;
        button8.Text = "Log device specs";
        button8.UseVisualStyleBackColor = true;
        button8.Click += button8_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new System.Drawing.Point(8, 141);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(87, 15);
        label3.TabIndex = 12;
        label3.Text = "Progress Status";
        // 
        // progressBar1
        // 
        progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        progressBar1.Location = new System.Drawing.Point(8, 125);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new System.Drawing.Size(500, 13);
        progressBar1.TabIndex = 11;
        // 
        // textBox1
        // 
        textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBox1.Location = new System.Drawing.Point(8, 160);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.PlaceholderText = "Logs will appear here...";
        textBox1.ReadOnly = true;
        textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        textBox1.Size = new System.Drawing.Size(500, 147);
        textBox1.TabIndex = 10;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(8, 11);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(81, 15);
        label2.TabIndex = 6;
        label2.Text = "Instance Path:";
        // 
        // button4
        // 
        button4.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        button4.Location = new System.Drawing.Point(395, 68);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(113, 23);
        button4.TabIndex = 5;
        button4.Text = "Install game";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button2
        // 
        button2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        button2.Location = new System.Drawing.Point(276, 68);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(113, 23);
        button2.TabIndex = 3;
        button2.Text = "Launch game";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(label7);
        tabPage2.Controls.Add(textBox3);
        tabPage2.Controls.Add(comboBox3);
        tabPage2.Controls.Add(checkBox3);
        tabPage2.Location = new System.Drawing.Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Size = new System.Drawing.Size(523, 315);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Settings";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new System.Drawing.Point(9, 68);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(109, 15);
        label7.TabIndex = 6;
        label7.Text = "Launch arguments:";
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(8, 89);
        textBox3.Multiline = true;
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(200, 123);
        textBox3.TabIndex = 5;
        // 
        // comboBox3
        // 
        comboBox3.Enabled = false;
        comboBox3.FormattingEnabled = true;
        comboBox3.Items.AddRange(new object[] { "DirectX 11", "DirectX 12", "OpenGL", "Vulkan" });
        comboBox3.Location = new System.Drawing.Point(18, 40);
        comboBox3.Name = "comboBox3";
        comboBox3.Size = new System.Drawing.Size(121, 23);
        comboBox3.TabIndex = 4;
        comboBox3.Text = "DirectX 11";
        // 
        // checkBox3
        // 
        checkBox3.AutoSize = true;
        checkBox3.Location = new System.Drawing.Point(18, 15);
        checkBox3.Name = "checkBox3";
        checkBox3.Size = new System.Drawing.Size(127, 19);
        checkBox3.TabIndex = 3;
        checkBox3.Text = "Override render api";
        checkBox3.UseVisualStyleBackColor = true;
        checkBox3.CheckedChanged += checkBox3_CheckedChanged;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(button11);
        tabPage3.Controls.Add(button9);
        tabPage3.Controls.Add(label6);
        tabPage3.Controls.Add(pictureBox1);
        tabPage3.Location = new System.Drawing.Point(4, 24);
        tabPage3.Name = "tabPage3";
        tabPage3.Size = new System.Drawing.Size(523, 315);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "About";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // button11
        // 
        button11.Location = new System.Drawing.Point(274, 41);
        button11.Name = "button11";
        button11.Size = new System.Drawing.Size(121, 23);
        button11.TabIndex = 4;
        button11.Text = "PixlPlaya5\'s Linktree";
        button11.UseVisualStyleBackColor = true;
        button11.Click += button11_Click;
        // 
        // button9
        // 
        button9.Location = new System.Drawing.Point(274, 12);
        button9.Name = "button9";
        button9.Size = new System.Drawing.Size(95, 23);
        button9.TabIndex = 2;
        button9.Text = "Report an issue";
        button9.UseVisualStyleBackColor = true;
        button9.Click += button9_Click;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(8, 171);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(507, 130);
        label6.TabIndex = 1;
        label6.Text = "This is a work-in-progress launcher for Project CloBeats.";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(8, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(260, 146);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(531, 343);
        Controls.Add(tabControl1);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "PJCB Launcher";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        tabPage2.ResumeLayout(false);
        tabPage2.PerformLayout();
        tabPage3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button5;

    private System.Windows.Forms.TextBox textBox4;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.ComboBox comboBox3;

    private System.Windows.Forms.CheckBox checkBox3;

    private System.Windows.Forms.Button button11;

    private System.Windows.Forms.Button button9;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.CheckBox checkBox1;

    private System.Windows.Forms.Button button8;

    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;

    #endregion
}