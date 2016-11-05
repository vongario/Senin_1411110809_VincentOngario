namespace Latihan_1_2
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
            this.LblAkhir2 = new System.Windows.Forms.Label();
            this.LblMax = new System.Windows.Forms.Label();
            this.LblMin = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblJrk = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.vScrollBarAkhir = new System.Windows.Forms.VScrollBar();
            this.vScrollBarAwal = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // LblAkhir2
            // 
            this.LblAkhir2.AutoSize = true;
            this.LblAkhir2.Location = new System.Drawing.Point(74, 230);
            this.LblAkhir2.Name = "LblAkhir2";
            this.LblAkhir2.Size = new System.Drawing.Size(57, 13);
            this.LblAkhir2.TabIndex = 14;
            this.LblAkhir2.Text = "Nilai Sama";
            // 
            // LblMax
            // 
            this.LblMax.AutoSize = true;
            this.LblMax.Location = new System.Drawing.Point(74, 58);
            this.LblMax.Name = "LblMax";
            this.LblMax.Size = new System.Drawing.Size(54, 13);
            this.LblMax.TabIndex = 13;
            this.LblMax.Text = "Nilai Akhir";
            // 
            // LblMin
            // 
            this.LblMin.AutoSize = true;
            this.LblMin.Location = new System.Drawing.Point(4, 58);
            this.LblMin.Name = "LblMin";
            this.LblMin.Size = new System.Drawing.Size(53, 13);
            this.LblMin.TabIndex = 8;
            this.LblMin.Text = "Nilai Awal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // LblJrk
            // 
            this.LblJrk.AutoSize = true;
            this.LblJrk.Location = new System.Drawing.Point(150, 40);
            this.LblJrk.Name = "LblJrk";
            this.LblJrk.Size = new System.Drawing.Size(36, 13);
            this.LblJrk.TabIndex = 11;
            this.LblJrk.Text = "Jarak ";
            // 
            // txtBox
            // 
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox.Enabled = false;
            this.txtBox.Location = new System.Drawing.Point(151, 56);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 10;
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vScrollBarAkhir
            // 
            this.vScrollBarAkhir.LargeChange = 1;
            this.vScrollBarAkhir.Location = new System.Drawing.Point(86, 96);
            this.vScrollBarAkhir.Maximum = 50;
            this.vScrollBarAkhir.Name = "vScrollBarAkhir";
            this.vScrollBarAkhir.Size = new System.Drawing.Size(17, 122);
            this.vScrollBarAkhir.TabIndex = 9;
            this.vScrollBarAkhir.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarAkhir_Scroll);
            // 
            // vScrollBarAwal
            // 
            this.vScrollBarAwal.AllowDrop = true;
            this.vScrollBarAwal.LargeChange = 1;
            this.vScrollBarAwal.Location = new System.Drawing.Point(17, 96);
            this.vScrollBarAwal.Maximum = 50;
            this.vScrollBarAwal.Name = "vScrollBarAwal";
            this.vScrollBarAwal.Size = new System.Drawing.Size(17, 122);
            this.vScrollBarAwal.TabIndex = 7;
            this.vScrollBarAwal.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBarAwal_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 282);
            this.Controls.Add(this.LblAkhir2);
            this.Controls.Add(this.LblMax);
            this.Controls.Add(this.LblMin);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LblJrk);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.vScrollBarAkhir);
            this.Controls.Add(this.vScrollBarAwal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAkhir2;
        private System.Windows.Forms.Label LblMax;
        private System.Windows.Forms.Label LblMin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LblJrk;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.VScrollBar vScrollBarAkhir;
        private System.Windows.Forms.VScrollBar vScrollBarAwal;
    }
}

