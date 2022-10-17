namespace Tarea_2
{
    partial class Form1
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
            this.txtMensaje1 = new System.Windows.Forms.TextBox();
            this.btnMensaje1 = new System.Windows.Forms.Button();
            this.btnMensaje2 = new System.Windows.Forms.Button();
            this.txtMensaje2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMensaje1
            // 
            this.txtMensaje1.Location = new System.Drawing.Point(24, 29);
            this.txtMensaje1.Name = "txtMensaje1";
            this.txtMensaje1.Size = new System.Drawing.Size(174, 20);
            this.txtMensaje1.TabIndex = 0;
            // 
            // btnMensaje1
            // 
            this.btnMensaje1.Location = new System.Drawing.Point(24, 81);
            this.btnMensaje1.Name = "btnMensaje1";
            this.btnMensaje1.Size = new System.Drawing.Size(174, 23);
            this.btnMensaje1.TabIndex = 1;
            this.btnMensaje1.Text = "Enviar mensaje 1";
            this.btnMensaje1.UseVisualStyleBackColor = true;
         
            // 
            // btnMensaje2
            // 
            this.btnMensaje2.Location = new System.Drawing.Point(273, 81);
            this.btnMensaje2.Name = "btnMensaje2";
            this.btnMensaje2.Size = new System.Drawing.Size(174, 23);
            this.btnMensaje2.TabIndex = 2;
            this.btnMensaje2.Text = "Enviar mensaje 2";
            this.btnMensaje2.UseVisualStyleBackColor = true;
        
            // 
            // txtMensaje2
            // 
            this.txtMensaje2.Location = new System.Drawing.Point(273, 29);
            this.txtMensaje2.Name = "txtMensaje2";
            this.txtMensaje2.Size = new System.Drawing.Size(174, 20);
            this.txtMensaje2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 153);
            this.Controls.Add(this.txtMensaje2);
            this.Controls.Add(this.btnMensaje2);
            this.Controls.Add(this.btnMensaje1);
            this.Controls.Add(this.txtMensaje1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje1;
        private System.Windows.Forms.Button btnMensaje1;
        private System.Windows.Forms.Button btnMensaje2;
        private System.Windows.Forms.TextBox txtMensaje2;
    }
}

