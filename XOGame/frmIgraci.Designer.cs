namespace XOGame
{
    partial class frmIgraci
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
            this.lblIgrac2 = new System.Windows.Forms.Label();
            this.txtIgrac1 = new System.Windows.Forms.TextBox();
            this.txtIgrac2 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblIgrac1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIgrac2
            // 
            this.lblIgrac2.AutoSize = true;
            this.lblIgrac2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIgrac2.Location = new System.Drawing.Point(36, 77);
            this.lblIgrac2.Name = "lblIgrac2";
            this.lblIgrac2.Size = new System.Drawing.Size(73, 20);
            this.lblIgrac2.TabIndex = 1;
            this.lblIgrac2.Text = "Player 2: ";
            // 
            // txtIgrac1
            // 
            this.txtIgrac1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIgrac1.Location = new System.Drawing.Point(115, 26);
            this.txtIgrac1.Name = "txtIgrac1";
            this.txtIgrac1.Size = new System.Drawing.Size(216, 26);
            this.txtIgrac1.TabIndex = 2;
            // 
            // txtIgrac2
            // 
            this.txtIgrac2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIgrac2.Location = new System.Drawing.Point(115, 71);
            this.txtIgrac2.Name = "txtIgrac2";
            this.txtIgrac2.Size = new System.Drawing.Size(216, 26);
            this.txtIgrac2.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(256, 118);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblIgrac1
            // 
            this.lblIgrac1.AutoSize = true;
            this.lblIgrac1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIgrac1.Location = new System.Drawing.Point(36, 29);
            this.lblIgrac1.Name = "lblIgrac1";
            this.lblIgrac1.Size = new System.Drawing.Size(73, 20);
            this.lblIgrac1.TabIndex = 5;
            this.lblIgrac1.Text = "Player 1: ";
            // 
            // frmIgraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 153);
            this.Controls.Add(this.lblIgrac1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtIgrac2);
            this.Controls.Add(this.txtIgrac1);
            this.Controls.Add(this.lblIgrac2);
            this.Name = "frmIgraci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XO Game: Players";
            this.Load += new System.EventHandler(this.frmIgraci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIgrac2;
        private System.Windows.Forms.TextBox txtIgrac1;
        private System.Windows.Forms.TextBox txtIgrac2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblIgrac1;
    }
}