namespace ConsoleApplication1
{
    partial class Startwindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.start_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chips_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.load_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Enabled = false;
            this.start_button.Location = new System.Drawing.Point(172, 237);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(85, 42);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start game";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your buy-in (amount of chips, max: 500)";
            // 
            // chips_textbox
            // 
            this.chips_textbox.Location = new System.Drawing.Point(231, 150);
            this.chips_textbox.Name = "chips_textbox";
            this.chips_textbox.Size = new System.Drawing.Size(100, 20);
            this.chips_textbox.TabIndex = 2;
            this.chips_textbox.TextChanged += new System.EventHandler(this.chips_textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your name:";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(231, 99);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_textbox.TabIndex = 4;
            this.name_textbox.TextChanged += new System.EventHandler(this.name_textbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Texas Hold\'em by StahlBerg Industries";
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(308, 237);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(85, 42);
            this.load_button.TabIndex = 6;
            this.load_button.Text = "Load game";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // Startwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 351);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chips_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Startwindow";
            this.Text = "Gamewindow";
            this.Load += new System.EventHandler(this.Gamewindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chips_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button load_button;
    }
}