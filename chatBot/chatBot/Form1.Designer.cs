namespace chatBot
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_send = new System.Windows.Forms.Button();
            this.txb_in = new System.Windows.Forms.TextBox();
            this.txb_out = new System.Windows.Forms.TextBox();
            this.btn_clr = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(538, 416);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Odeslat";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txb_in
            // 
            this.txb_in.Location = new System.Drawing.Point(12, 418);
            this.txb_in.Name = "txb_in";
            this.txb_in.Size = new System.Drawing.Size(520, 20);
            this.txb_in.TabIndex = 1;
            this.txb_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_in_KeyPress);
            // 
            // txb_out
            // 
            this.txb_out.Location = new System.Drawing.Point(12, 12);
            this.txb_out.Multiline = true;
            this.txb_out.Name = "txb_out";
            this.txb_out.ReadOnly = true;
            this.txb_out.Size = new System.Drawing.Size(520, 400);
            this.txb_out.TabIndex = 2;
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(538, 12);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(75, 30);
            this.btn_clr.TabIndex = 3;
            this.btn_clr.Text = "Smazat";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.txb_out);
            this.Controls.Add(this.txb_in);
            this.Controls.Add(this.btn_send);
            this.Name = "Form1";
            this.Text = "Chad the ChatBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txb_in;
        private System.Windows.Forms.TextBox txb_out;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

