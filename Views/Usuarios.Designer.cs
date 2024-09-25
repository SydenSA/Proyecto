namespace Rosales_WaterLevel_Monitor.Views
{
    partial class frm_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuarios));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRASENADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monitoreoAguaDataSet = new Rosales_WaterLevel_Monitor.MonitoreoAguaDataSet();
            this.rEGISTROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEGISTROTableAdapter = new Rosales_WaterLevel_Monitor.MonitoreoAguaDataSetTableAdapters.REGISTROTableAdapter();
            this.uSUARIOSTableAdapter = new Rosales_WaterLevel_Monitor.MonitoreoAguaDataSetTableAdapters.USUARIOSTableAdapter();
            this.btn_GuardarUsuario = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoreoAguaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTROBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUSUARIODataGridViewTextBoxColumn,
            this.uSUARIODataGridViewTextBoxColumn,
            this.cONTRASENADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uSUARIOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDUSUARIODataGridViewTextBoxColumn
            // 
            this.iDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "IDUSUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.HeaderText = "IDUSUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.Name = "iDUSUARIODataGridViewTextBoxColumn";
            this.iDUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSUARIODataGridViewTextBoxColumn
            // 
            this.uSUARIODataGridViewTextBoxColumn.DataPropertyName = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.HeaderText = "USUARIO";
            this.uSUARIODataGridViewTextBoxColumn.Name = "uSUARIODataGridViewTextBoxColumn";
            // 
            // cONTRASENADataGridViewTextBoxColumn
            // 
            this.cONTRASENADataGridViewTextBoxColumn.DataPropertyName = "CONTRASENA";
            this.cONTRASENADataGridViewTextBoxColumn.HeaderText = "CONTRASENA";
            this.cONTRASENADataGridViewTextBoxColumn.Name = "cONTRASENADataGridViewTextBoxColumn";
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.monitoreoAguaDataSet;
            // 
            // monitoreoAguaDataSet
            // 
            this.monitoreoAguaDataSet.DataSetName = "MonitoreoAguaDataSet";
            this.monitoreoAguaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEGISTROBindingSource
            // 
            this.rEGISTROBindingSource.DataMember = "REGISTRO";
            this.rEGISTROBindingSource.DataSource = this.monitoreoAguaDataSet;
            // 
            // rEGISTROTableAdapter
            // 
            this.rEGISTROTableAdapter.ClearBeforeFill = true;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // btn_GuardarUsuario
            // 
            this.btn_GuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_GuardarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarUsuario.Location = new System.Drawing.Point(394, 36);
            this.btn_GuardarUsuario.Name = "btn_GuardarUsuario";
            this.btn_GuardarUsuario.Size = new System.Drawing.Size(89, 50);
            this.btn_GuardarUsuario.TabIndex = 1;
            this.btn_GuardarUsuario.Text = "INSERTAR";
            this.btn_GuardarUsuario.UseVisualStyleBackColor = true;
            this.btn_GuardarUsuario.Click += new System.EventHandler(this.btn_GuardarUsuarios);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(515, 36);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(89, 50);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(448, 102);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(89, 50);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(429, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "REGRESAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 263);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_GuardarUsuario);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoreoAguaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGISTROBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MonitoreoAguaDataSet monitoreoAguaDataSet;
        private System.Windows.Forms.BindingSource rEGISTROBindingSource;
        private MonitoreoAguaDataSetTableAdapters.REGISTROTableAdapter rEGISTROTableAdapter;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private MonitoreoAguaDataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRASENADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_GuardarUsuario;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button button5;
    }
}