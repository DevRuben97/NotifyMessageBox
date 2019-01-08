namespace TestWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtcuerpo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupDuration = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Numsegundos = new System.Windows.Forms.NumericUpDown();
            this.CheckTime = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupDuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numsegundos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar Mensaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo:";
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(56, 22);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(257, 20);
            this.txttitulo.TabIndex = 2;
            // 
            // txtcuerpo
            // 
            this.txtcuerpo.Location = new System.Drawing.Point(56, 78);
            this.txtcuerpo.Name = "txtcuerpo";
            this.txtcuerpo.Size = new System.Drawing.Size(257, 20);
            this.txtcuerpo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuerpo:";
            // 
            // cbotipo
            // 
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "Confirmacion",
            "Alerta",
            "Error",
            "Mensaje"});
            this.cbotipo.Location = new System.Drawing.Point(62, 126);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(257, 21);
            this.cbotipo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo:";
            // 
            // groupDuration
            // 
            this.groupDuration.Controls.Add(this.label4);
            this.groupDuration.Controls.Add(this.Numsegundos);
            this.groupDuration.Location = new System.Drawing.Point(395, 38);
            this.groupDuration.Name = "groupDuration";
            this.groupDuration.Size = new System.Drawing.Size(326, 84);
            this.groupDuration.TabIndex = 7;
            this.groupDuration.TabStop = false;
            this.groupDuration.Text = "Duración del Mensaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Duración(Segundos):";
            // 
            // Numsegundos
            // 
            this.Numsegundos.Location = new System.Drawing.Point(6, 45);
            this.Numsegundos.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Numsegundos.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Numsegundos.Name = "Numsegundos";
            this.Numsegundos.Size = new System.Drawing.Size(195, 20);
            this.Numsegundos.TabIndex = 9;
            this.Numsegundos.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // CheckTime
            // 
            this.CheckTime.AutoSize = true;
            this.CheckTime.Location = new System.Drawing.Point(404, 12);
            this.CheckTime.Name = "CheckTime";
            this.CheckTime.Size = new System.Drawing.Size(175, 17);
            this.CheckTime.TabIndex = 8;
            this.CheckTime.Text = "Modificar Duración Por Defecto";
            this.CheckTime.UseVisualStyleBackColor = true;
            this.CheckTime.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(747, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 71);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 191);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckTime);
            this.Controls.Add(this.groupDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.txtcuerpo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupDuration.ResumeLayout(false);
            this.groupDuration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numsegundos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtcuerpo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Numsegundos;
        private System.Windows.Forms.CheckBox CheckTime;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

