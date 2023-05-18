namespace Placos
{
    partial class FrmExercicio1
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
            this.rtbFrase1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEspacoBranco = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnPar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbFrase1
            // 
            this.rtbFrase1.Location = new System.Drawing.Point(245, 111);
            this.rtbFrase1.Name = "rtbFrase1";
            this.rtbFrase1.Size = new System.Drawing.Size(382, 115);
            this.rtbFrase1.TabIndex = 0;
            this.rtbFrase1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exercicio 1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnEspacoBranco
            // 
            this.btnEspacoBranco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspacoBranco.Location = new System.Drawing.Point(98, 294);
            this.btnEspacoBranco.Name = "btnEspacoBranco";
            this.btnEspacoBranco.Size = new System.Drawing.Size(173, 57);
            this.btnEspacoBranco.TabIndex = 2;
            this.btnEspacoBranco.Text = "número de espaços em branco";
            this.btnEspacoBranco.UseVisualStyleBackColor = true;
            this.btnEspacoBranco.Click += new System.EventHandler(this.BtnEspacoBranco_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetraR.Location = new System.Drawing.Point(275, 294);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(173, 57);
            this.btnLetraR.TabIndex = 3;
            this.btnLetraR.Text = "número de vezes que aparece a letra “R”";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.BtnLetraR_Click);
            // 
            // btnPar
            // 
            this.btnPar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPar.Location = new System.Drawing.Point(452, 294);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(173, 57);
            this.btnPar.TabIndex = 4;
            this.btnPar.Text = "O número de vezes que ocorre um mesmo par de letras na frase";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.BtnPar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(629, 294);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(173, 57);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FrmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 393);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnEspacoBranco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbFrase1);
            this.Name = "FrmExercicio1";
            this.Text = "FrmExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFrase1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEspacoBranco;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.Button btnFechar;
    }
}