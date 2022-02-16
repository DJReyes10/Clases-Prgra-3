namespace Programacion3IPAC2022
{
    partial class Arreglos
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
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MatrizButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(218, 12);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(125, 34);
            this.EjecutarButton.TabIndex = 0;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(218, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 139);
            this.listBox1.TabIndex = 1;
            // 
            // MatrizButton
            // 
            this.MatrizButton.Location = new System.Drawing.Point(533, 18);
            this.MatrizButton.Name = "MatrizButton";
            this.MatrizButton.Size = new System.Drawing.Size(96, 28);
            this.MatrizButton.TabIndex = 2;
            this.MatrizButton.Text = "Ejecutar Matriz";
            this.MatrizButton.UseVisualStyleBackColor = true;
            this.MatrizButton.Click += new System.EventHandler(this.MatrizButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(508, 86);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(130, 139);
            this.listBox2.TabIndex = 3;
            // 
            // Arreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 380);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.MatrizButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.EjecutarButton);
            this.Name = "Arreglos";
            this.Text = "Arreglos";
            this.ResumeLayout(false);

        }

        #endregion

        private Button EjecutarButton;
        private ListBox listBox1;
        private Button MatrizButton;
        private ListBox listBox2;
    }
}