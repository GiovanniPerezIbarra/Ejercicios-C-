namespace HolaWinForms
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
            this.EstatusBox = new System.Windows.Forms.ComboBox();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.ventana = new System.Windows.Forms.DataGridView();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.AbreviaturaLabel = new System.Windows.Forms.Label();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.ClaveText = new System.Windows.Forms.TextBox();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.PanelAgregar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ventana)).BeginInit();
            this.PanelAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // EstatusBox
            // 
            this.EstatusBox.FormattingEnabled = true;
            this.EstatusBox.Location = new System.Drawing.Point(29, 23);
            this.EstatusBox.Name = "EstatusBox";
            this.EstatusBox.Size = new System.Drawing.Size(153, 21);
            this.EstatusBox.TabIndex = 0;
            this.EstatusBox.SelectedIndexChanged += new System.EventHandler(this.EstatusBox_SelectedIndexChanged);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.BackColor = System.Drawing.SystemColors.Info;
            this.AgregarBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBtn.Location = new System.Drawing.Point(242, 16);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(91, 32);
            this.AgregarBtn.TabIndex = 1;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = false;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.BackColor = System.Drawing.SystemColors.Info;
            this.ModificarBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarBtn.Location = new System.Drawing.Point(362, 16);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(90, 32);
            this.ModificarBtn.TabIndex = 2;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.UseVisualStyleBackColor = false;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.BackColor = System.Drawing.SystemColors.Info;
            this.EliminarBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.Location = new System.Drawing.Point(473, 16);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(81, 32);
            this.EliminarBtn.TabIndex = 3;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = false;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // ventana
            // 
            this.ventana.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ventana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventana.Location = new System.Drawing.Point(110, 70);
            this.ventana.Name = "ventana";
            this.ventana.Size = new System.Drawing.Size(370, 150);
            this.ventana.TabIndex = 4;
            this.ventana.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ventana_CellContentClick);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NombreLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NombreLabel.Location = new System.Drawing.Point(15, 14);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(81, 21);
            this.NombreLabel.TabIndex = 5;
            this.NombreLabel.Text = "Nombre: ";
            // 
            // AbreviaturaLabel
            // 
            this.AbreviaturaLabel.AutoSize = true;
            this.AbreviaturaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbreviaturaLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AbreviaturaLabel.Location = new System.Drawing.Point(15, 52);
            this.AbreviaturaLabel.Name = "AbreviaturaLabel";
            this.AbreviaturaLabel.Size = new System.Drawing.Size(110, 21);
            this.AbreviaturaLabel.TabIndex = 6;
            this.AbreviaturaLabel.Text = "Abreviatura:";
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(102, 14);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(130, 20);
            this.NombreText.TabIndex = 7;
            // 
            // ClaveText
            // 
            this.ClaveText.Location = new System.Drawing.Point(132, 52);
            this.ClaveText.Name = "ClaveText";
            this.ClaveText.Size = new System.Drawing.Size(100, 20);
            this.ClaveText.TabIndex = 8;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GuardarBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarBtn.Location = new System.Drawing.Point(19, 94);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(95, 31);
            this.GuardarBtn.TabIndex = 9;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = false;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CancelarBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarBtn.Location = new System.Drawing.Point(146, 94);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(86, 31);
            this.CancelarBtn.TabIndex = 10;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // PanelAgregar
            // 
            this.PanelAgregar.Controls.Add(this.NombreText);
            this.PanelAgregar.Controls.Add(this.CancelarBtn);
            this.PanelAgregar.Controls.Add(this.NombreLabel);
            this.PanelAgregar.Controls.Add(this.GuardarBtn);
            this.PanelAgregar.Controls.Add(this.AbreviaturaLabel);
            this.PanelAgregar.Controls.Add(this.ClaveText);
            this.PanelAgregar.Location = new System.Drawing.Point(29, 226);
            this.PanelAgregar.Name = "PanelAgregar";
            this.PanelAgregar.Size = new System.Drawing.Size(318, 134);
            this.PanelAgregar.TabIndex = 11;
            this.PanelAgregar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 371);
            this.Controls.Add(this.PanelAgregar);
            this.Controls.Add(this.ventana);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.EstatusBox);
            this.Name = "Form1";
            this.Text = "Estatus";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventana)).EndInit();
            this.PanelAgregar.ResumeLayout(false);
            this.PanelAgregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox EstatusBox;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.DataGridView ventana;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label AbreviaturaLabel;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.TextBox ClaveText;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Panel PanelAgregar;
    }
}

