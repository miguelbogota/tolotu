namespace Tolotu_Desktop.Views {
  partial class Inicio {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.container = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.MeneOption = new System.Windows.Forms.Button();
            this.BtnMyactiv = new System.Windows.Forms.Button();
            this.BtnAllActiv = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.AutoScroll = true;
            this.container.BackColor = System.Drawing.SystemColors.Control;
            this.container.Location = new System.Drawing.Point(297, 0);
            this.container.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(771, 635);
            this.container.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel.Controls.Add(this.BtnAllActiv);
            this.panel.Controls.Add(this.BtnMyactiv);
            this.panel.Controls.Add(this.btnCerrarSesion);
            this.panel.Controls.Add(this.lblTitulo);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(268, 635);
            this.panel.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 3;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(39, 587);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(185, 35);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(50, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(174, 44);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "TOLOTU";
            // 
            // MeneOption
            // 
            this.MeneOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MeneOption.Location = new System.Drawing.Point(273, 20);
            this.MeneOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MeneOption.Name = "MeneOption";
            this.MeneOption.Size = new System.Drawing.Size(20, 72);
            this.MeneOption.TabIndex = 2;
            this.MeneOption.Text = "<";
            this.MeneOption.UseVisualStyleBackColor = true;
            this.MeneOption.Click += new System.EventHandler(this.PanelToogle_Click);
            // 
            // BtnMyactiv
            // 
            this.BtnMyactiv.BackColor = System.Drawing.Color.White;
            this.BtnMyactiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMyactiv.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMyactiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnMyactiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnMyactiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMyactiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMyactiv.ForeColor = System.Drawing.Color.DarkOrchid;
            this.BtnMyactiv.Location = new System.Drawing.Point(25, 138);
            this.BtnMyactiv.Name = "BtnMyactiv";
            this.BtnMyactiv.Size = new System.Drawing.Size(221, 27);
            this.BtnMyactiv.TabIndex = 3;
            this.BtnMyactiv.Text = "Mis eventos";
            this.BtnMyactiv.UseVisualStyleBackColor = false;
            this.BtnMyactiv.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAllActiv
            // 
            this.BtnAllActiv.BackColor = System.Drawing.Color.White;
            this.BtnAllActiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAllActiv.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAllActiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnAllActiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnAllActiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllActiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAllActiv.ForeColor = System.Drawing.Color.DarkOrchid;
            this.BtnAllActiv.Location = new System.Drawing.Point(25, 171);
            this.BtnAllActiv.Name = "BtnAllActiv";
            this.BtnAllActiv.Size = new System.Drawing.Size(221, 30);
            this.BtnAllActiv.TabIndex = 4;
            this.BtnAllActiv.Text = "Todos los eventos";
            this.BtnAllActiv.UseVisualStyleBackColor = false;
            this.BtnAllActiv.Click += new System.EventHandler(this.BtnAllActiv_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 634);
            this.Controls.Add(this.MeneOption);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.container);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Inicio";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel container;
    private System.Windows.Forms.Panel panel;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Button MeneOption;
    private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button BtnAllActiv;
        private System.Windows.Forms.Button BtnMyactiv;
    }
}