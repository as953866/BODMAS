namespace BODMAS
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.Input1 = new System.Windows.Forms.Label();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Addition";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(106, 21);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 1;
            // 
            // Input1
            // 
            this.Input1.AutoSize = true;
            this.Input1.Location = new System.Drawing.Point(55, 24);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(35, 13);
            this.Input1.TabIndex = 2;
            this.Input1.Text = "label1";
            this.Input1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(106, 45);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 20);
            this.txtInput2.TabIndex = 3;
            // 
            // Input2
            // 
            this.Input2.AutoSize = true;
            this.Input2.Location = new System.Drawing.Point(55, 48);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(35, 13);
            this.Input2.TabIndex = 4;
            this.Input2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label Input1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Label Input2;
    }
}

