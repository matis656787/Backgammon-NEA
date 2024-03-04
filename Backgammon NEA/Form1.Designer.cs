namespace Backgammon_NEA
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.statsButton = new System.Windows.Forms.Button();
            this.instructionsbutton = new System.Windows.Forms.Button();
            this.vsPlayerbutton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rulesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // statsButton
            // 
            this.statsButton.BackColor = System.Drawing.Color.Black;
            this.statsButton.ForeColor = System.Drawing.Color.White;
            this.statsButton.Location = new System.Drawing.Point(55, 173);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(158, 63);
            this.statsButton.TabIndex = 1;
            this.statsButton.Text = "Statistics";
            this.statsButton.UseVisualStyleBackColor = false;
            this.statsButton.Click += new System.EventHandler(this.statsButton_Click);
            // 
            // instructionsbutton
            // 
            this.instructionsbutton.BackColor = System.Drawing.Color.Black;
            this.instructionsbutton.ForeColor = System.Drawing.Color.White;
            this.instructionsbutton.Location = new System.Drawing.Point(242, 173);
            this.instructionsbutton.Name = "instructionsbutton";
            this.instructionsbutton.Size = new System.Drawing.Size(158, 63);
            this.instructionsbutton.TabIndex = 2;
            this.instructionsbutton.Text = "Instructions";
            this.instructionsbutton.UseVisualStyleBackColor = false;
            this.instructionsbutton.Click += new System.EventHandler(this.instructionsbutton_Click);
            // 
            // vsPlayerbutton
            // 
            this.vsPlayerbutton.BackColor = System.Drawing.Color.Black;
            this.vsPlayerbutton.ForeColor = System.Drawing.Color.White;
            this.vsPlayerbutton.Location = new System.Drawing.Point(55, 68);
            this.vsPlayerbutton.Name = "vsPlayerbutton";
            this.vsPlayerbutton.Size = new System.Drawing.Size(345, 63);
            this.vsPlayerbutton.TabIndex = 5;
            this.vsPlayerbutton.Text = "vs PLAYER";
            this.vsPlayerbutton.UseVisualStyleBackColor = false;
            this.vsPlayerbutton.Click += new System.EventHandler(this.vsPlayerbutton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rulesTextBox
            // 
            this.rulesTextBox.Location = new System.Drawing.Point(13, 271);
            this.rulesTextBox.Name = "rulesTextBox";
            this.rulesTextBox.ReadOnly = true;
            this.rulesTextBox.Size = new System.Drawing.Size(387, 22);
            this.rulesTextBox.TabIndex = 6;
            this.rulesTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rulesTextBox);
            this.Controls.Add(this.vsPlayerbutton);
            this.Controls.Add(this.instructionsbutton);
            this.Controls.Add(this.statsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.Button instructionsbutton;
        private System.Windows.Forms.Button vsPlayerbutton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox rulesTextBox;
    }
}

