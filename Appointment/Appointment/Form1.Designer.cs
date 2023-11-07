namespace Appointment
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
            this.signup = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmrLogin = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.BackColor = System.Drawing.Color.Transparent;
            this.signup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.LinkColor = System.Drawing.Color.DarkBlue;
            this.signup.Location = new System.Drawing.Point(69, 287);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(203, 16);
            this.signup.TabIndex = 22;
            this.signup.TabStop = true;
            this.signup.Text = "Don\'t have an account? Click here!";
            this.signup.VisitedLinkColor = System.Drawing.Color.Turquoise;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(127, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "RedHat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.Black;
            this.submitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitbtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitbtn.Location = new System.Drawing.Point(250, 232);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(65, 32);
            this.submitbtn.TabIndex = 19;
            this.submitbtn.Text = "Log-in";
            this.submitbtn.UseVisualStyleBackColor = false;
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(72, 186);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(243, 26);
            this.passtxt.TabIndex = 18;
            // 
            // usertxt
            // 
            this.usertxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.Location = new System.Drawing.Point(72, 121);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(243, 26);
            this.usertxt.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 58);
            this.label4.TabIndex = 23;
            this.label4.Text = "Need help for your computer or internet issues? \r\n                  Book an appoi" +
    "ntment now!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(367, 425);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "RedHat Appointment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel signup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer tmrLogin;
        private System.Windows.Forms.Label label4;
    }
}

