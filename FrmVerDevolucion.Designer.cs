﻿namespace TrabajoFinal_
{
    partial class FrmVerDevolucion
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
            btnVolver = new Button();
            lstDevolucion = new ListBox();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(336, 377);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lstDevolucion
            // 
            lstDevolucion.FormattingEnabled = true;
            lstDevolucion.ItemHeight = 15;
            lstDevolucion.Location = new Point(236, 89);
            lstDevolucion.Name = "lstDevolucion";
            lstDevolucion.Size = new Size(289, 199);
            lstDevolucion.TabIndex = 1;
            // 
            // FrmVerDevolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstDevolucion);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVerDevolucion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVerDevolucion";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private ListBox lstDevolucion;
    }
}