namespace Tolotu_Desktop.Views {
  partial class EventoDetallado {
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
    private void InitializeComponent(bool add) {
      this.EventImagen = new System.Windows.Forms.PictureBox();
      this.LblEventNombre = new System.Windows.Forms.Label();
      this.LblDescripcion = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.BtnCerrar = new System.Windows.Forms.Button();
      this.LblAsistentes = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      if (add) { this.BtnParticipar = new System.Windows.Forms.Button(); }
      ((System.ComponentModel.ISupportInitialize)(this.EventImagen)).BeginInit();
      this.SuspendLayout();
      // 
      // EventImagen
      // 
      this.EventImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EventImagen.Location = new System.Drawing.Point(121, 70);
      this.EventImagen.Name = "EventImagen";
      this.EventImagen.Size = new System.Drawing.Size(126, 138);
      this.EventImagen.TabIndex = 0;
      this.EventImagen.TabStop = false;
      this.EventImagen.Click += new System.EventHandler(this.EventImagen_Click);
      // 
      // LblEventNombre
      // 
      this.LblEventNombre.AutoSize = true;
      this.LblEventNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LblEventNombre.Location = new System.Drawing.Point(148, 42);
      this.LblEventNombre.Name = "LblEventNombre";
      this.LblEventNombre.Size = new System.Drawing.Size(70, 25);
      this.LblEventNombre.TabIndex = 1;
      this.LblEventNombre.Text = "label1";
      this.LblEventNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // LblDescripcion
      // 
      this.LblDescripcion.AutoSize = true;
      this.LblDescripcion.Location = new System.Drawing.Point(23, 259);
      this.LblDescripcion.Name = "LblDescripcion";
      this.LblDescripcion.Size = new System.Drawing.Size(35, 13);
      this.LblDescripcion.TabIndex = 2;
      this.LblDescripcion.Text = "label2";
      this.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(23, 235);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Descripcion";
      // 
      // BtnCerrar
      // 
      this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(98)))), ((int)(((byte)(221)))));
      this.BtnCerrar.FlatAppearance.BorderSize = 3;
      this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(98)))), ((int)(((byte)(221)))));
      this.BtnCerrar.Location = new System.Drawing.Point(109, 422);
      this.BtnCerrar.Name = "BtnCerrar";
      this.BtnCerrar.Size = new System.Drawing.Size(148, 32);
      this.BtnCerrar.TabIndex = 4;
      this.BtnCerrar.Text = "Cerrar";
      this.BtnCerrar.UseVisualStyleBackColor = true;
      this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
      // 
      // LblAsistentes
      // 
      this.LblAsistentes.AutoSize = true;
      this.LblAsistentes.Location = new System.Drawing.Point(23, 327);
      this.LblAsistentes.Name = "LblAsistentes";
      this.LblAsistentes.Size = new System.Drawing.Size(35, 13);
      this.LblAsistentes.TabIndex = 5;
      this.LblAsistentes.Text = "label1";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(23, 298);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Asistentes";
      // 
      // BtnParticipar
      // 
      if (add) {
        this.BtnParticipar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(98)))), ((int)(((byte)(221)))));
        this.BtnParticipar.FlatAppearance.BorderSize = 3;
        this.BtnParticipar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        this.BtnParticipar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        this.BtnParticipar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.BtnParticipar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(98)))), ((int)(((byte)(221)))));
        this.BtnParticipar.Location = new System.Drawing.Point(109, 358);
        this.BtnParticipar.Name = "BtnParticipar";
        this.BtnParticipar.Size = new System.Drawing.Size(148, 48);
        this.BtnParticipar.TabIndex = 7;
        this.BtnParticipar.Text = "Participar en esta actividad";
        this.BtnParticipar.UseVisualStyleBackColor = true;
        this.BtnParticipar.Click += new System.EventHandler(this.BtnParticipar_Click);
      }
      // 
      // EventoDetallado
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(381, 477);
      if (add) { this.Controls.Add(this.BtnParticipar); }
      this.Controls.Add(this.label1);
      this.Controls.Add(this.LblAsistentes);
      this.Controls.Add(this.BtnCerrar);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.LblDescripcion);
      this.Controls.Add(this.LblEventNombre);
      this.Controls.Add(this.EventImagen);
      this.MaximizeBox = false;
      this.Name = "EventoDetallado";
      this.Text = "Tolotu - Evento";
      this.Load += new System.EventHandler(this.EventoDetallado_Load);
      ((System.ComponentModel.ISupportInitialize)(this.EventImagen)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox EventImagen;
    private System.Windows.Forms.Label LblEventNombre;
    private System.Windows.Forms.Label LblDescripcion;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button BtnCerrar;
    private System.Windows.Forms.Label LblAsistentes;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button BtnParticipar;
  }
}