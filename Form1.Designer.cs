namespace FormComplejo
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
            this.txtbComplejo1 = new System.Windows.Forms.TextBox();
            this.txtbComplejo2 = new System.Windows.Forms.TextBox();
            this.lbOperador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultComplejo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnConjugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbComplejo1
            // 
            this.txtbComplejo1.Location = new System.Drawing.Point(131, 87);
            this.txtbComplejo1.Name = "txtbComplejo1";
            this.txtbComplejo1.Size = new System.Drawing.Size(119, 20);
            this.txtbComplejo1.TabIndex = 0;
            // 
            // txtbComplejo2
            // 
            this.txtbComplejo2.Location = new System.Drawing.Point(379, 89);
            this.txtbComplejo2.Name = "txtbComplejo2";
            this.txtbComplejo2.Size = new System.Drawing.Size(131, 20);
            this.txtbComplejo2.TabIndex = 1;
            // 
            // lbOperador
            // 
            this.lbOperador.AutoSize = true;
            this.lbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperador.Location = new System.Drawing.Point(298, 89);
            this.lbOperador.Name = "lbOperador";
            this.lbOperador.Size = new System.Drawing.Size(22, 24);
            this.lbOperador.TabIndex = 2;
            this.lbOperador.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(572, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // lbResultComplejo
            // 
            this.lbResultComplejo.AutoSize = true;
            this.lbResultComplejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultComplejo.Location = new System.Drawing.Point(644, 89);
            this.lbResultComplejo.Name = "lbResultComplejo";
            this.lbResultComplejo.Size = new System.Drawing.Size(61, 24);
            this.lbResultComplejo.TabIndex = 4;
            this.lbResultComplejo.Text = "0 + 0i";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "SUMA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "RESTA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 47);
            this.button3.TabIndex = 7;
            this.button3.Text = "MULTIPLICA";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(612, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 47);
            this.button4.TabIndex = 8;
            this.button4.Text = "CONJUGAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(110, 189);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(91, 47);
            this.btnSumar.TabIndex = 5;
            this.btnSumar.Text = "SUMA";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            this.btnSumar.MouseHover += new System.EventHandler(this.btnSumar_MouseHover);
            // 
            // btnRestar
            // 
            this.btnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Location = new System.Drawing.Point(274, 189);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(92, 47);
            this.btnRestar.TabIndex = 6;
            this.btnRestar.Text = "RESTA";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            this.btnRestar.MouseHover += new System.EventHandler(this.btnRestar_MouseHover);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(440, 189);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(98, 47);
            this.btnMultiplicar.TabIndex = 7;
            this.btnMultiplicar.Text = "MULTIPLICA";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            this.btnMultiplicar.MouseHover += new System.EventHandler(this.btnMultiplicar_MouseHover);
            // 
            // btnConjugar
            // 
            this.btnConjugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConjugar.Location = new System.Drawing.Point(612, 189);
            this.btnConjugar.Name = "btnConjugar";
            this.btnConjugar.Size = new System.Drawing.Size(93, 47);
            this.btnConjugar.TabIndex = 8;
            this.btnConjugar.Text = "CONJUGAR";
            this.btnConjugar.UseVisualStyleBackColor = true;
            this.btnConjugar.Click += new System.EventHandler(this.btnConjugar_Click);
            this.btnConjugar.MouseHover += new System.EventHandler(this.btnConjugar_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 346);
            this.Controls.Add(this.btnConjugar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbResultComplejo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbOperador);
            this.Controls.Add(this.txtbComplejo2);
            this.Controls.Add(this.txtbComplejo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbComplejo1;
        private System.Windows.Forms.TextBox txtbComplejo2;
        private System.Windows.Forms.Label lbOperador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultComplejo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnConjugar;
    }
}

