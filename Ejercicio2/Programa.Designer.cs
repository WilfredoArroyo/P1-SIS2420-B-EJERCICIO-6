﻿namespace ejercicio2
{
    partial class Frm_P6
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_num = new System.Windows.Forms.ListBox();
            this.btn_genenar = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.Cbbox_operaciones = new System.Windows.Forms.ComboBox();
            this.lbl_principal = new System.Windows.Forms.Label();
            this.lbl_listbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx_num
            // 
            this.lbx_num.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_num.FormattingEnabled = true;
            this.lbx_num.ItemHeight = 26;
            this.lbx_num.Location = new System.Drawing.Point(155, 196);
            this.lbx_num.Name = "lbx_num";
            this.lbx_num.Size = new System.Drawing.Size(437, 212);
            this.lbx_num.TabIndex = 0;
            // 
            // btn_genenar
            // 
            this.btn_genenar.BackColor = System.Drawing.Color.Red;
            this.btn_genenar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_genenar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_genenar.Location = new System.Drawing.Point(609, 91);
            this.btn_genenar.Name = "btn_genenar";
            this.btn_genenar.Size = new System.Drawing.Size(150, 59);
            this.btn_genenar.TabIndex = 1;
            this.btn_genenar.Text = "GENERAR";
            this.btn_genenar.UseVisualStyleBackColor = false;
            this.btn_genenar.Click += new System.EventHandler(this.btn_genenar_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(239, 104);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 34);
            this.txt_numero.TabIndex = 2;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(12, 107);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(202, 26);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "iNGRESAR VALOR";
            // 
            // Cbbox_operaciones
            // 
            this.Cbbox_operaciones.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbbox_operaciones.FormattingEnabled = true;
            this.Cbbox_operaciones.Location = new System.Drawing.Point(356, 104);
            this.Cbbox_operaciones.Name = "Cbbox_operaciones";
            this.Cbbox_operaciones.Size = new System.Drawing.Size(236, 34);
            this.Cbbox_operaciones.TabIndex = 4;
            // 
            // lbl_principal
            // 
            this.lbl_principal.AutoSize = true;
            this.lbl_principal.Font = new System.Drawing.Font("ISOCPEUR", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_principal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_principal.Location = new System.Drawing.Point(315, 25);
            this.lbl_principal.Name = "lbl_principal";
            this.lbl_principal.Size = new System.Drawing.Size(186, 46);
            this.lbl_principal.TabIndex = 5;
            this.lbl_principal.Text = "PROGRAMA";
            // 
            // lbl_listbox
            // 
            this.lbl_listbox.AutoSize = true;
            this.lbl_listbox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_listbox.Location = new System.Drawing.Point(23, 152);
            this.lbl_listbox.Name = "lbl_listbox";
            this.lbl_listbox.Size = new System.Drawing.Size(227, 26);
            this.lbl_listbox.TabIndex = 6;
            this.lbl_listbox.Text = "LOS NUMEROS SON:";
            // 
            // frm_P6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_listbox);
            this.Controls.Add(this.lbl_principal);
            this.Controls.Add(this.Cbbox_operaciones);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.btn_genenar);
            this.Controls.Add(this.lbx_num);
            this.Name = "frm_P6";
            this.Text = "EJERCICIO 6";
            this.Load += new System.EventHandler(this.frm_programa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_num;
        private System.Windows.Forms.Button btn_genenar;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ComboBox Cbbox_operaciones;
        private System.Windows.Forms.Label lbl_principal;
        private System.Windows.Forms.Label lbl_listbox;
    }
}

