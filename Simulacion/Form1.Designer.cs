namespace Simulacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.numeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Others = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linferior = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lsuperior = new System.Windows.Forms.TextBox();
            this.generar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(73, 80);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(57, 20);
            this.cantidad.TabIndex = 2;
            this.cantidad.TextChanged += new System.EventHandler(this.cantidad_TextChanged);
            this.cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_KeyPress);
            // 
            // numeros
            // 
            this.numeros.Location = new System.Drawing.Point(27, 200);
            this.numeros.Multiline = true;
            this.numeros.Name = "numeros";
            this.numeros.ReadOnly = true;
            this.numeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.numeros.Size = new System.Drawing.Size(224, 191);
            this.numeros.TabIndex = 8;
            this.numeros.TextChanged += new System.EventHandler(this.numeros_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numeros aleatorios generados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Others);
            this.groupBox1.Controls.Add(this.limpiar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.linferior);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lsuperior);
            this.groupBox1.Controls.Add(this.generar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cantidad);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo basico";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Others
            // 
            this.Others.Location = new System.Drawing.Point(10, 106);
            this.Others.Name = "Others";
            this.Others.Size = new System.Drawing.Size(75, 23);
            this.Others.TabIndex = 3;
            this.Others.Text = "Otros,,,,";
            this.Others.UseVisualStyleBackColor = true;
            this.Others.Click += new System.EventHandler(this.Others_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(180, 106);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 5;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Intervalo Inferior";
            // 
            // linferior
            // 
            this.linferior.Location = new System.Drawing.Point(124, 22);
            this.linferior.Name = "linferior";
            this.linferior.Size = new System.Drawing.Size(57, 20);
            this.linferior.TabIndex = 0;
            this.linferior.TextChanged += new System.EventHandler(this.linferior_TextChanged);
            this.linferior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.linferior_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Intervalo superior";
            // 
            // lsuperior
            // 
            this.lsuperior.Location = new System.Drawing.Point(124, 49);
            this.lsuperior.Name = "lsuperior";
            this.lsuperior.Size = new System.Drawing.Size(57, 20);
            this.lsuperior.TabIndex = 1;
            this.lsuperior.TextChanged += new System.EventHandler(this.lsuperior_TextChanged);
            this.lsuperior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lsuperior_KeyPress);
            // 
            // generar
            // 
            this.generar.Enabled = false;
            this.generar.Location = new System.Drawing.Point(99, 106);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(75, 23);
            this.generar.TabIndex = 4;
            this.generar.Text = "Generar";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeros);
            this.Name = "Form1";
            this.Text = "Generador de numeros aleatorios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.TextBox numeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox linferior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lsuperior;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button Others;
    }
}

