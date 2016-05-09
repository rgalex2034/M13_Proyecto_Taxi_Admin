namespace M13_ProyectoTaxi.Forms.Tareas
{
    partial class TareasForm
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
            this.btnAddTarea = new System.Windows.Forms.Button();
            this.btnUpdTarea = new System.Windows.Forms.Button();
            this.btnDelTarea = new System.Windows.Forms.Button();
            this.dgvTarea = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarea)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTarea
            // 
            this.btnAddTarea.Location = new System.Drawing.Point(13, 13);
            this.btnAddTarea.Name = "btnAddTarea";
            this.btnAddTarea.Size = new System.Drawing.Size(75, 23);
            this.btnAddTarea.TabIndex = 0;
            this.btnAddTarea.Text = "Añadir";
            this.btnAddTarea.UseVisualStyleBackColor = true;
            // 
            // btnUpdTarea
            // 
            this.btnUpdTarea.Location = new System.Drawing.Point(94, 13);
            this.btnUpdTarea.Name = "btnUpdTarea";
            this.btnUpdTarea.Size = new System.Drawing.Size(75, 23);
            this.btnUpdTarea.TabIndex = 1;
            this.btnUpdTarea.Text = "Actualizar";
            this.btnUpdTarea.UseVisualStyleBackColor = true;
            // 
            // btnDelTarea
            // 
            this.btnDelTarea.Location = new System.Drawing.Point(175, 13);
            this.btnDelTarea.Name = "btnDelTarea";
            this.btnDelTarea.Size = new System.Drawing.Size(75, 23);
            this.btnDelTarea.TabIndex = 2;
            this.btnDelTarea.Text = "Borrar";
            this.btnDelTarea.UseVisualStyleBackColor = true;
            // 
            // dgvTarea
            // 
            this.dgvTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarea.Location = new System.Drawing.Point(13, 43);
            this.dgvTarea.Name = "dgvTarea";
            this.dgvTarea.Size = new System.Drawing.Size(412, 206);
            this.dgvTarea.TabIndex = 3;
            // 
            // TareasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 261);
            this.Controls.Add(this.dgvTarea);
            this.Controls.Add(this.btnDelTarea);
            this.Controls.Add(this.btnUpdTarea);
            this.Controls.Add(this.btnAddTarea);
            this.Name = "TareasForm";
            this.Text = "TareasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddTarea;
        private System.Windows.Forms.Button btnUpdTarea;
        private System.Windows.Forms.Button btnDelTarea;
        private System.Windows.Forms.DataGridView dgvTarea;
    }
}