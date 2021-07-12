
namespace Proyecto_Final_Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPositivoNegativo = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btn1sobreX = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPositivoNegativo
            // 
            this.btnPositivoNegativo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPositivoNegativo.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPositivoNegativo.Location = new System.Drawing.Point(3, 390);
            this.btnPositivoNegativo.Name = "btnPositivoNegativo";
            this.btnPositivoNegativo.Size = new System.Drawing.Size(75, 64);
            this.btnPositivoNegativo.TabIndex = 1;
            this.btnPositivoNegativo.Text = "+/-";
            this.btnPositivoNegativo.UseVisualStyleBackColor = false;
            this.btnPositivoNegativo.Click += new System.EventHandler(this.btnPositivoNegativo_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn0.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(76, 390);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 64);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPunto.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(149, 390);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(75, 64);
            this.btnPunto.TabIndex = 3;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIgual.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(222, 390);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 64);
            this.btnIgual.TabIndex = 4;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuma.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(222, 329);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 64);
            this.btnSuma.TabIndex = 8;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(149, 329);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 64);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(76, 329);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 64);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(3, 329);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 64);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnResta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResta.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(222, 267);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 64);
            this.btnResta.TabIndex = 12;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn6.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(149, 267);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 64);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn5.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(76, 267);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 64);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(3, 267);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 64);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMultiplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(222, 205);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(75, 64);
            this.btnMultiplicacion.TabIndex = 16;
            this.btnMultiplicacion.Text = "x";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn9.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(149, 205);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 64);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn8.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(76, 205);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 64);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn7.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(3, 205);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 64);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDivision.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(222, 144);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 64);
            this.btnDivision.TabIndex = 20;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRaizCuadrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRaizCuadrada.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaizCuadrada.Location = new System.Drawing.Point(149, 144);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(75, 64);
            this.btnRaizCuadrada.TabIndex = 19;
            this.btnRaizCuadrada.Text = "²√x";
            this.btnRaizCuadrada.UseVisualStyleBackColor = false;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.btnRaizCuadrada_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCuadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCuadrado.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadrado.Location = new System.Drawing.Point(76, 144);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(75, 64);
            this.btnCuadrado.TabIndex = 18;
            this.btnCuadrado.Text = "x²";
            this.btnCuadrado.UseVisualStyleBackColor = false;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btn1sobreX
            // 
            this.btn1sobreX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn1sobreX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn1sobreX.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1sobreX.Location = new System.Drawing.Point(3, 144);
            this.btn1sobreX.Name = "btn1sobreX";
            this.btn1sobreX.Size = new System.Drawing.Size(75, 64);
            this.btn1sobreX.TabIndex = 17;
            this.btn1sobreX.Text = "¹/x";
            this.btn1sobreX.UseVisualStyleBackColor = false;
            this.btn1sobreX.Click += new System.EventHandler(this.btn1sobreX_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBorrar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(222, 83);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 64);
            this.btnBorrar.TabIndex = 24;
            this.btnBorrar.Text = "⌫";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnC.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(149, 83);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 64);
            this.btnC.TabIndex = 23;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCE.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(76, 83);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(75, 64);
            this.btnCE.TabIndex = 22;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPorcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPorcentaje.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentaje.Location = new System.Drawing.Point(3, 83);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(75, 64);
            this.btnPorcentaje.TabIndex = 21;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = false;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // txtPantalla
            // 
            this.txtPantalla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtPantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPantalla.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPantalla.Font = new System.Drawing.Font("Digital-7 Mono", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.Location = new System.Drawing.Point(4, 12);
            this.txtPantalla.MaxLength = 12;
            this.txtPantalla.Multiline = true;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(293, 72);
            this.txtPantalla.TabIndex = 25;
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(299, 458);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnRaizCuadrada);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btn1sobreX);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPositivoNegativo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Christianlator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPositivoNegativo;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btn1sobreX;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.TextBox txtPantalla;
    }
}

