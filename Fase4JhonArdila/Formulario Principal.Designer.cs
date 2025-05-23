namespace Fase4JhonArdila
{
    partial class frmEsctructuraArbolBinario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorEntero = new System.Windows.Forms.TextBox();
            this.panelArbol = new System.Windows.Forms.Panel();
            this.panelPreorden = new System.Windows.Forms.Panel();
            this.panelInorden = new System.Windows.Forms.Panel();
            this.panelPosorden = new System.Windows.Forms.Panel();
            this.btnAgregarNodo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Entero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Árbol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 406);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recorrido Preorden";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 496);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recorrido Inorden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 587);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Recorrido Posorden";
            // 
            // txtValorEntero
            // 
            this.txtValorEntero.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtValorEntero.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEntero.Location = new System.Drawing.Point(31, 40);
            this.txtValorEntero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValorEntero.Name = "txtValorEntero";
            this.txtValorEntero.Size = new System.Drawing.Size(117, 23);
            this.txtValorEntero.TabIndex = 5;
            this.txtValorEntero.TextChanged += new System.EventHandler(this.txtValorEntero_TextChanged);
            // 
            // panelArbol
            // 
            this.panelArbol.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelArbol.Location = new System.Drawing.Point(31, 102);
            this.panelArbol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelArbol.Name = "panelArbol";
            this.panelArbol.Size = new System.Drawing.Size(787, 288);
            this.panelArbol.TabIndex = 6;
            this.panelArbol.Paint += new System.Windows.Forms.PaintEventHandler(this.panelArbol_Paint);
            // 
            // panelPreorden
            // 
            this.panelPreorden.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelPreorden.Location = new System.Drawing.Point(31, 425);
            this.panelPreorden.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelPreorden.Name = "panelPreorden";
            this.panelPreorden.Size = new System.Drawing.Size(786, 58);
            this.panelPreorden.TabIndex = 7;
            this.panelPreorden.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPreorden_Paint);
            // 
            // panelInorden
            // 
            this.panelInorden.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelInorden.Location = new System.Drawing.Point(31, 514);
            this.panelInorden.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelInorden.Name = "panelInorden";
            this.panelInorden.Size = new System.Drawing.Size(785, 59);
            this.panelInorden.TabIndex = 8;
            this.panelInorden.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInorden_Paint);
            // 
            // panelPosorden
            // 
            this.panelPosorden.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelPosorden.Location = new System.Drawing.Point(31, 606);
            this.panelPosorden.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelPosorden.Name = "panelPosorden";
            this.panelPosorden.Size = new System.Drawing.Size(785, 55);
            this.panelPosorden.TabIndex = 9;
            this.panelPosorden.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPosorden_Paint);
            // 
            // btnAgregarNodo
            // 
            this.btnAgregarNodo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgregarNodo.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNodo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarNodo.Location = new System.Drawing.Point(167, 32);
            this.btnAgregarNodo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarNodo.Name = "btnAgregarNodo";
            this.btnAgregarNodo.Size = new System.Drawing.Size(132, 36);
            this.btnAgregarNodo.TabIndex = 10;
            this.btnAgregarNodo.Text = "Agregar Nodo";
            this.btnAgregarNodo.UseVisualStyleBackColor = false;
            this.btnAgregarNodo.Click += new System.EventHandler(this.btnAgregarNodo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalir.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(718, 671);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 36);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEsctructuraArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(850, 718);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarNodo);
            this.Controls.Add(this.panelPosorden);
            this.Controls.Add(this.panelInorden);
            this.Controls.Add(this.panelPreorden);
            this.Controls.Add(this.panelArbol);
            this.Controls.Add(this.txtValorEntero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEsctructuraArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Principal";
            this.Load += new System.EventHandler(this.frmEsctructuraArbolBinario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorEntero;
        private System.Windows.Forms.Panel panelArbol;
        private System.Windows.Forms.Panel panelPreorden;
        private System.Windows.Forms.Panel panelInorden;
        private System.Windows.Forms.Panel panelPosorden;
        private System.Windows.Forms.Button btnAgregarNodo;
        private System.Windows.Forms.Button btnSalir;
    }
}