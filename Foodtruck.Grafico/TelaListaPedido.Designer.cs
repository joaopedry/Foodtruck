﻿namespace Foodtruck.Grafico
{
    partial class TelaListaPedido
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
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bebida_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lanche_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPedidos
            // 
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DataCompra,
            this.Cliente_Id,
            this.Bebida_Id,
            this.Lanche_Id});
            this.dgPedidos.Location = new System.Drawing.Point(11, 68);
            this.dgPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.RowTemplate.Height = 24;
            this.dgPedidos.Size = new System.Drawing.Size(763, 249);
            this.dgPedidos.TabIndex = 4;
            this.dgPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLanches_CellContentClick);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(99, 20);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(72, 34);
            this.btAlterar.TabIndex = 6;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(11, 20);
            this.btRemover.Margin = new System.Windows.Forms.Padding(2);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(84, 34);
            this.btRemover.TabIndex = 5;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // DataCompra
            // 
            this.DataCompra.DataPropertyName = "DataCompra";
            this.DataCompra.HeaderText = "DataCompra";
            this.DataCompra.Name = "DataCompra";
            // 
            // Cliente_Id
            // 
            this.Cliente_Id.DataPropertyName = "Cliente_Id";
            this.Cliente_Id.HeaderText = "Cliente_Id";
            this.Cliente_Id.Name = "Cliente_Id";
            // 
            // Bebida_Id
            // 
            this.Bebida_Id.DataPropertyName = "Bebida_Id";
            this.Bebida_Id.HeaderText = "Bebida_Id";
            this.Bebida_Id.Name = "Bebida_Id";
            // 
            // Lanche_Id
            // 
            this.Lanche_Id.DataPropertyName = "Lanche_Id";
            this.Lanche_Id.HeaderText = "Lanche_Id";
            this.Lanche_Id.Name = "Lanche_Id";
            // 
            // TelaListaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.dgPedidos);
            this.Name = "TelaListaPedido";
            this.Text = "TelaListaPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bebida_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lanche_Id;
    }
}