namespace Tolotu_Desktop.Vista {
  partial class Menu {
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
      this.button1 = new System.Windows.Forms.Button();
      this.panel = new System.Windows.Forms.Panel();
      this.lblTitulo = new System.Windows.Forms.Label();
      this.MeneOption = new System.Windows.Forms.Button();
      this.container.SuspendLayout();
      this.panel.SuspendLayout();
      this.SuspendLayout();
      // 
      // container
      // 
      this.container.AutoScroll = true;
      this.container.BackColor = System.Drawing.SystemColors.Control;
      this.container.Controls.Add(this.button1);
      this.container.Location = new System.Drawing.Point(396, 0);
      this.container.Name = "container";
      this.container.Size = new System.Drawing.Size(1028, 781);
      this.container.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(3, 6);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // panel
      // 
      this.panel.BackColor = System.Drawing.Color.DarkOrchid;
      this.panel.Controls.Add(this.lblTitulo);
      this.panel.Location = new System.Drawing.Point(0, 0);
      this.panel.Name = "panel";
      this.panel.Size = new System.Drawing.Size(358, 781);
      this.panel.TabIndex = 1;
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
      this.MeneOption.Name = "MeneOption";
      this.MeneOption.Size = new System.Drawing.Size(26, 89);
      this.MeneOption.TabIndex = 2;
      this.MeneOption.Text = "<";
      this.MeneOption.UseVisualStyleBackColor = true;
      this.MeneOption.Click += new System.EventHandler(this.button1_Click);
      // 
      // Menu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1424, 780);
      this.Controls.Add(this.MeneOption);
      this.Controls.Add(this.panel);
      this.Controls.Add(this.container);
      this.Name = "Menu";
      this.Text = "Menu";
      this.container.ResumeLayout(false);
      this.panel.ResumeLayout(false);
      this.panel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel container;
    private System.Windows.Forms.Panel panel;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Button MeneOption;
    private System.Windows.Forms.Button button1;
  }
}