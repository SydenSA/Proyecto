namespace Rosales_WaterLevel_Monitor.Views
{
    partial class frm_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnósticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_monitorear = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "WATER LEVEL MONITOR";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.sensoresToolStripMenuItem,
            this.diagnósticosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // sensoresToolStripMenuItem
            // 
            this.sensoresToolStripMenuItem.Name = "sensoresToolStripMenuItem";
            this.sensoresToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sensoresToolStripMenuItem.Text = "Sensores";
            this.sensoresToolStripMenuItem.Click += new System.EventHandler(this.sensoresToolStripMenuItem_Click);
            // 
            // diagnósticosToolStripMenuItem
            // 
            this.diagnósticosToolStripMenuItem.Name = "diagnósticosToolStripMenuItem";
            this.diagnósticosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.diagnósticosToolStripMenuItem.Text = "Diagnósticos";
            this.diagnósticosToolStripMenuItem.Click += new System.EventHandler(this.diagnósticosToolStripMenuItem_Click);
            // 
            // btn_monitorear
            // 
            this.btn_monitorear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_monitorear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_monitorear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_monitorear.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_monitorear.Location = new System.Drawing.Point(122, 328);
            this.btn_monitorear.Name = "btn_monitorear";
            this.btn_monitorear.Size = new System.Drawing.Size(89, 52);
            this.btn_monitorear.TabIndex = 2;
            this.btn_monitorear.Text = "Monitorear";
            this.btn_monitorear.UseVisualStyleBackColor = true;
            this.btn_monitorear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_salir.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(353, 328);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(89, 52);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rosales_WaterLevel_Monitor.Properties.Resources.ultrasonidos_agarre_05edit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_monitorear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_MenuPrincipal";
            this.Text = "Rosales WaterLevel Monitor";
            this.Load += new System.EventHandler(this.frm_MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnósticosToolStripMenuItem;
        private System.Windows.Forms.Button btn_monitorear;
        private System.Windows.Forms.Button btn_salir;
    }
}