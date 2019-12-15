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
      this.panel.SuspendLayout();
      this.SuspendLayout();
      // 
      // container
      // 
      this.container.AutoScroll = true;
      this.container.BackColor = System.Drawing.SystemColors.Control;
      this.container.Location = new System.Drawing.Point(396, 0);
      this.container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.container.Name = "container";
      this.container.Size = new System.Drawing.Size(1028, 782);
      this.container.TabIndex = 0;
      // 
      // panel
      // 
      this.panel.BackColor = System.Drawing.Color.DarkOrchid;
      this.panel.Controls.Add(this.btnCerrarSesion);
      this.panel.Controls.Add(this.lblTitulo);
      this.panel.Location = new System.Drawing.Point(0, 0);
      this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel.Name = "panel";
      this.panel.Size = new System.Drawing.Size(357, 782);
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
      this.btnCerrarSesion.Location = new System.Drawing.Point(52, 722);
      this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnCerrarSesion.Name = "btnCerrarSesion";
      this.btnCerrarSesion.Size = new System.Drawing.Size(247, 43);
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
      this.lblTitulo.Location = new System.Drawing.Point(67, 31);
      this.lblTitulo.Name = "lblTitulo";
      this.lblTitulo.Size = new System.Drawing.Size(218, 55);
      this.lblTitulo.TabIndex = 1;
      this.lblTitulo.Text = "TOLOTU";
      // 
      // MeneOption
      // 
      this.MeneOption.Cursor = System.Windows.Forms.Cursors.Hand;
      this.MeneOption.Location = new System.Drawing.Point(364, 25);
      this.MeneOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MeneOption.Name = "MeneOption";
      this.MeneOption.Size = new System.Drawing.Size(27, 89);
      this.MeneOption.TabIndex = 2;
      this.MeneOption.Text = "<";
      this.MeneOption.UseVisualStyleBackColor = true;
      this.MeneOption.Click += new System.EventHandler(this.PanelToogle_Click);
      // 
      // Inicio
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1424, 780);
      this.Controls.Add(this.MeneOption);
      this.Controls.Add(this.panel);
      this.Controls.Add(this.container);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
  }
}