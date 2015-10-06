namespace HelloRichard
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
            this.button1 = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.LB1 = new System.Windows.Forms.Label();
            this.RT1 = new System.Windows.Forms.RichTextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.nullpop = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nullpop)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Quote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(394, 22);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(764, 26);
            this.TB1.TabIndex = 1;
            this.TB1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.Location = new System.Drawing.Point(250, 28);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(100, 20);
            this.LB1.TabIndex = 2;
            this.LB1.Text = "Enter Quote:";
            this.LB1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RT1
            // 
            this.RT1.Location = new System.Drawing.Point(394, 116);
            this.RT1.Name = "RT1";
            this.RT1.Size = new System.Drawing.Size(764, 332);
            this.RT1.TabIndex = 3;
            this.RT1.Text = "";
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(394, 71);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(764, 26);
            this.TB2.TabIndex = 4;
            // 
            // nullpop
            // 
            this.nullpop.ContainerControl = this;
            this.nullpop.RightToLeftChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(296, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 74);
            this.button2.TabIndex = 5;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 540);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.RT1);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nullpop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Label LB1;
        private System.Windows.Forms.TextBox TB2;
        public System.Windows.Forms.RichTextBox RT1;
        private System.Windows.Forms.ErrorProvider nullpop;
        private System.Windows.Forms.Button button2;
    }
}

