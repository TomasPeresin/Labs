
namespace UI.Desktop
{
    partial class formListaUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.usuarioLogicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daUsuariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioLogicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Usuarios:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioDataDataGridViewTextBoxColumn,
            this.daUsuariosDataGridViewTextBoxColumn,
            this.connDataGridViewTextBoxColumn});
            this.dgvUsuarios.DataSource = this.usuarioLogicBindingSource;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 25);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(496, 407);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // usuarioLogicBindingSource
            // 
            this.usuarioLogicBindingSource.DataSource = typeof(Business.Logic.UsuarioLogic);
            // 
            // usuarioDataDataGridViewTextBoxColumn
            // 
            this.usuarioDataDataGridViewTextBoxColumn.DataPropertyName = "UsuarioData";
            this.usuarioDataDataGridViewTextBoxColumn.HeaderText = "UsuarioData";
            this.usuarioDataDataGridViewTextBoxColumn.Name = "usuarioDataDataGridViewTextBoxColumn";
            // 
            // daUsuariosDataGridViewTextBoxColumn
            // 
            this.daUsuariosDataGridViewTextBoxColumn.DataPropertyName = "DaUsuarios";
            this.daUsuariosDataGridViewTextBoxColumn.HeaderText = "DaUsuarios";
            this.daUsuariosDataGridViewTextBoxColumn.Name = "daUsuariosDataGridViewTextBoxColumn";
            // 
            // connDataGridViewTextBoxColumn
            // 
            this.connDataGridViewTextBoxColumn.DataPropertyName = "Conn";
            this.connDataGridViewTextBoxColumn.HeaderText = "Conn";
            this.connDataGridViewTextBoxColumn.Name = "connDataGridViewTextBoxColumn";
            // 
            // formListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 444);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label1);
            this.Name = "formListaUsuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioLogicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daUsuariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuarioLogicBindingSource;
    }
}