namespace DastaMessage
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
            this.btnValdu = new System.Windows.Forms.Button();
            this.btnReadZprava = new System.Windows.Forms.Button();
            this.lblVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValdu
            // 
            this.btnValdu.Location = new System.Drawing.Point(147, 24);
            this.btnValdu.Name = "btnValdu";
            this.btnValdu.Size = new System.Drawing.Size(128, 45);
            this.btnValdu.TabIndex = 0;
            this.btnValdu.Text = "Validate";
            this.btnValdu.UseVisualStyleBackColor = true;
            this.btnValdu.Click += new System.EventHandler(this.btnValdu_Click);
            // 
            // btnReadZprava
            // 
            this.btnReadZprava.Location = new System.Drawing.Point(41, 35);
            this.btnReadZprava.Name = "btnReadZprava";
            this.btnReadZprava.Size = new System.Drawing.Size(75, 23);
            this.btnReadZprava.TabIndex = 1;
            this.btnReadZprava.Text = "Otevri zpravu";
            this.btnReadZprava.UseVisualStyleBackColor = true;
            this.btnReadZprava.Click += new System.EventHandler(this.btnReadZprava_Click);
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Location = new System.Drawing.Point(41, 102);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(84, 13);
            this.lblVal.TabIndex = 2;
            this.lblVal.Text = "Validator error ->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(697, 376);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.btnReadZprava);
            this.Controls.Add(this.btnValdu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValdu;
        private System.Windows.Forms.Button btnReadZprava;
        private System.Windows.Forms.Label lblVal;
    }
}

