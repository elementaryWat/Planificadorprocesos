﻿namespace WindowsFormsApplication3
{
    partial class DialogoSimple
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
            this.Etiqueta = new System.Windows.Forms.Label();
            this.Texto = new System.Windows.Forms.TextBox();
            this.BotonEst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Etiqueta
            // 
            this.Etiqueta.AutoSize = true;
            this.Etiqueta.Location = new System.Drawing.Point(12, 23);
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.Size = new System.Drawing.Size(86, 13);
            this.Etiqueta.TabIndex = 0;
            this.Etiqueta.Text = "Tiempo quantum";
            // 
            // Texto
            // 
            this.Texto.Location = new System.Drawing.Point(119, 15);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(100, 20);
            this.Texto.TabIndex = 1;
            this.Texto.Text = "1";
            // 
            // BotonEst
            // 
            this.BotonEst.Location = new System.Drawing.Point(80, 50);
            this.BotonEst.Name = "BotonEst";
            this.BotonEst.Size = new System.Drawing.Size(75, 23);
            this.BotonEst.TabIndex = 2;
            this.BotonEst.Text = "button1";
            this.BotonEst.UseVisualStyleBackColor = true;
            this.BotonEst.Click += new System.EventHandler(this.BotonEst_Click);
            // 
            // DialogoSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 76);
            this.Controls.Add(this.BotonEst);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.Etiqueta);
            this.MaximizeBox = false;
            this.Name = "DialogoSimple";
            this.Text = "Tiempo de quantum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox Texto;
        public System.Windows.Forms.Label Etiqueta;
        public System.Windows.Forms.Button BotonEst;
    }
}