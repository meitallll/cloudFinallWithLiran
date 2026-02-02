namespace cloudFinal.Forms
{
    partial class ViewSingleHotel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox_ViewSingleHotal = new System.Windows.Forms.RichTextBox();
            this.btn_ReplaceHotel = new System.Windows.Forms.Button();
            this.btn_DeleteHotel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.richTextBox_ViewSingleHotal);
            this.panel1.Location = new System.Drawing.Point(35, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 433);
            this.panel1.TabIndex = 1;
            // 
            // richTextBox_ViewSingleHotal
            // 
            this.richTextBox_ViewSingleHotal.Location = new System.Drawing.Point(19, 34);
            this.richTextBox_ViewSingleHotal.Name = "richTextBox_ViewSingleHotal";
            this.richTextBox_ViewSingleHotal.Size = new System.Drawing.Size(859, 380);
            this.richTextBox_ViewSingleHotal.TabIndex = 0;
            this.richTextBox_ViewSingleHotal.Text = "";
            // 
            // btn_ReplaceHotel
            // 
            this.btn_ReplaceHotel.Location = new System.Drawing.Point(120, 493);
            this.btn_ReplaceHotel.Name = "btn_ReplaceHotel";
            this.btn_ReplaceHotel.Size = new System.Drawing.Size(151, 53);
            this.btn_ReplaceHotel.TabIndex = 2;
            this.btn_ReplaceHotel.Text = "Replace";
            this.btn_ReplaceHotel.UseVisualStyleBackColor = true;
            this.btn_ReplaceHotel.Click += new System.EventHandler(this.btn_ReplaceHotel_Click);
            // 
            // btn_DeleteHotel
            // 
            this.btn_DeleteHotel.Location = new System.Drawing.Point(325, 493);
            this.btn_DeleteHotel.Name = "btn_DeleteHotel";
            this.btn_DeleteHotel.Size = new System.Drawing.Size(151, 53);
            this.btn_DeleteHotel.TabIndex = 3;
            this.btn_DeleteHotel.Text = "Delete";
            this.btn_DeleteHotel.UseVisualStyleBackColor = true;
            this.btn_DeleteHotel.Click += new System.EventHandler(this.btn_DeleteHotel_Click);
            // 
            // ViewSingleHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1032, 595);
            this.Controls.Add(this.btn_DeleteHotel);
            this.Controls.Add(this.btn_ReplaceHotel);
            this.Controls.Add(this.panel1);
            this.Name = "ViewSingleHotel";
            this.Text = "ViewSingleHotel";
            this.Load += new System.EventHandler(this.ViewSingleHotel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox_ViewSingleHotal;
        private System.Windows.Forms.Button btn_ReplaceHotel;
        private System.Windows.Forms.Button btn_DeleteHotel;
    }
}