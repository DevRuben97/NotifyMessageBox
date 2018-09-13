namespace PopUpMessageBox
{
    partial class Window
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
            this.lbntitulo = new System.Windows.Forms.Label();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.Showing = new System.Windows.Forms.Timer(this.components);
            this.Closing = new System.Windows.Forms.Timer(this.components);
            this.btnclose = new System.Windows.Forms.Button();
            this.txtBody = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbntitulo
            // 
            this.lbntitulo.AutoSize = true;
            this.lbntitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbntitulo.ForeColor = System.Drawing.Color.White;
            this.lbntitulo.Location = new System.Drawing.Point(78, 9);
            this.lbntitulo.Name = "lbntitulo";
            this.lbntitulo.Size = new System.Drawing.Size(49, 21);
            this.lbntitulo.TabIndex = 0;
            this.lbntitulo.Text = "Titulo";
            // 
            // PictureLogo
            // 
            this.PictureLogo.Image = global::PopUpMessageBox.Properties.Resources.cancelWhite;
            this.PictureLogo.Location = new System.Drawing.Point(1, 12);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(71, 67);
            this.PictureLogo.TabIndex = 1;
            this.PictureLogo.TabStop = false;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // Showing
            // 
            this.Showing.Tick += new System.EventHandler(this.Showing_Tick);
            // 
            // Closing
            // 
            this.Closing.Tick += new System.EventHandler(this.Closing_Tick);
            // 
            // btnclose
            // 
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(375, -2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(41, 32);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBody
            // 
            this.txtBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.txtBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBody.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBody.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBody.ForeColor = System.Drawing.Color.White;
            this.txtBody.Location = new System.Drawing.Point(82, 33);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ReadOnly = true;
            this.txtBody.Size = new System.Drawing.Size(317, 46);
            this.txtBody.TabIndex = 11;
            this.txtBody.Text = "Mi Primer Mensaje";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(411, 94);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.PictureLogo);
            this.Controls.Add(this.lbntitulo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Window";
            this.Opacity = 0D;
            this.Text = "Window";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Window_Load);
            this.MouseLeave += new System.EventHandler(this.Window_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Window_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbntitulo;
        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Timer Showing;
        private System.Windows.Forms.Timer Closing;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox txtBody;
    }
}