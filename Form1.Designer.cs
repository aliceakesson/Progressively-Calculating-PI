
namespace Progressively_Calculating_PI
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
            this.pi_label = new System.Windows.Forms.Label();
            this.calcTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pi_label
            // 
            this.pi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pi_label.ForeColor = System.Drawing.Color.White;
            this.pi_label.Location = new System.Drawing.Point(12, 9);
            this.pi_label.Name = "pi_label";
            this.pi_label.Size = new System.Drawing.Size(760, 743);
            this.pi_label.TabIndex = 0;
            // 
            // calcTimer
            // 
            this.calcTimer.Enabled = true;
            this.calcTimer.Interval = 1;
            this.calcTimer.Tick += new System.EventHandler(this.calcTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.pi_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pi_label;
        private System.Windows.Forms.Timer calcTimer;
    }
}

