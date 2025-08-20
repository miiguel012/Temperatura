namespace Temperatura
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbTemperatura = new System.Windows.Forms.TextBox();
            this.lblTempertura = new System.Windows.Forms.Label();
            this.btnClima = new System.Windows.Forms.Button();
            this.pibResultado = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // txbTemperatura
            // 
            this.txbTemperatura.Location = new System.Drawing.Point(234, 86);
            this.txbTemperatura.Name = "txbTemperatura";
            this.txbTemperatura.Size = new System.Drawing.Size(100, 20);
            this.txbTemperatura.TabIndex = 1;
            // 
            // lblTempertura
            // 
            this.lblTempertura.AutoSize = true;
            this.lblTempertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempertura.Location = new System.Drawing.Point(149, 88);
            this.lblTempertura.Name = "lblTempertura";
            this.lblTempertura.Size = new System.Drawing.Size(79, 18);
            this.lblTempertura.TabIndex = 2;
            this.lblTempertura.Text = "tempertura";
            this.lblTempertura.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClima
            // 
            this.btnClima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClima.Location = new System.Drawing.Point(200, 112);
            this.btnClima.Name = "btnClima";
            this.btnClima.Size = new System.Drawing.Size(123, 61);
            this.btnClima.TabIndex = 3;
            this.btnClima.Text = "verificar clima";
            this.btnClima.UseVisualStyleBackColor = true;
            this.btnClima.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pibResultado
            // 
            this.pibResultado.Location = new System.Drawing.Point(211, 179);
            this.pibResultado.Name = "pibResultado";
            this.pibResultado.Size = new System.Drawing.Size(100, 50);
            this.pibResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibResultado.TabIndex = 4;
            this.pibResultado.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(180, 264);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pibResultado);
            this.Controls.Add(this.btnClima);
            this.Controls.Add(this.lblTempertura);
            this.Controls.Add(this.txbTemperatura);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pibResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbTemperatura;
        private System.Windows.Forms.Label lblTempertura;
        private System.Windows.Forms.Button btnClima;
        private System.Windows.Forms.PictureBox pibResultado;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

