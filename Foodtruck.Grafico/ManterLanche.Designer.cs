namespace Foodtruck.Grafico
{
    partial class ManterLanche
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
            this.btCancelarLanche = new System.Windows.Forms.Button();
            this.btSalvarLanche = new System.Windows.Forms.Button();
            this.tbValorLanche = new System.Windows.Forms.TextBox();
            this.tbNomeLanche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelarLanche
            // 
            this.btCancelarLanche.Location = new System.Drawing.Point(398, 209);
            this.btCancelarLanche.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelarLanche.Name = "btCancelarLanche";
            this.btCancelarLanche.Size = new System.Drawing.Size(96, 48);
            this.btCancelarLanche.TabIndex = 19;
            this.btCancelarLanche.Text = "Cancelar";
            this.btCancelarLanche.UseVisualStyleBackColor = true;
            this.btCancelarLanche.Click += new System.EventHandler(this.btCancelarLanche_Click);
            // 
            // btSalvarLanche
            // 
            this.btSalvarLanche.Location = new System.Drawing.Point(502, 209);
            this.btSalvarLanche.Margin = new System.Windows.Forms.Padding(2);
            this.btSalvarLanche.Name = "btSalvarLanche";
            this.btSalvarLanche.Size = new System.Drawing.Size(95, 48);
            this.btSalvarLanche.TabIndex = 18;
            this.btSalvarLanche.Text = "Salvar";
            this.btSalvarLanche.UseVisualStyleBackColor = true;
            this.btSalvarLanche.Click += new System.EventHandler(this.btSalvarLanche_Click_1);
            // 
            // tbValorLanche
            // 
            this.tbValorLanche.Location = new System.Drawing.Point(72, 130);
            this.tbValorLanche.Margin = new System.Windows.Forms.Padding(2);
            this.tbValorLanche.Name = "tbValorLanche";
            this.tbValorLanche.Size = new System.Drawing.Size(150, 20);
            this.tbValorLanche.TabIndex = 16;
            // 
            // tbNomeLanche
            // 
            this.tbNomeLanche.Location = new System.Drawing.Point(72, 94);
            this.tbNomeLanche.Margin = new System.Windows.Forms.Padding(2);
            this.tbNomeLanche.Name = "tbNomeLanche";
            this.tbNomeLanche.Size = new System.Drawing.Size(527, 20);
            this.tbNomeLanche.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome:";
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(26, 133);
            this.valor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(31, 13);
            this.valor.TabIndex = 21;
            this.valor.Text = "Valor";
            // 
            // ManterLanche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.btCancelarLanche);
            this.Controls.Add(this.btSalvarLanche);
            this.Controls.Add(this.tbValorLanche);
            this.Controls.Add(this.tbNomeLanche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ManterLanche";
            this.Text = "ManterLanche";
            this.Load += new System.EventHandler(this.ManterLanche_Load);
            this.Shown += new System.EventHandler(this.ManterLanche_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelarLanche;
        private System.Windows.Forms.Button btSalvarLanche;
        private System.Windows.Forms.TextBox tbValorLanche;
        private System.Windows.Forms.TextBox tbNomeLanche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valor;
    }
}