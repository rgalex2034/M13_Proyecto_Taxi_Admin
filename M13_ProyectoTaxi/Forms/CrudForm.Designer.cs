namespace M13_ProyectoTaxi.Forms
{
    partial class CrudForm
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
            this.btnDelElement = new System.Windows.Forms.Button();
            this.btnUpdElement = new System.Windows.Forms.Button();
            this.btnAddElement = new System.Windows.Forms.Button();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelElement
            // 
            this.btnDelElement.Location = new System.Drawing.Point(174, 12);
            this.btnDelElement.Name = "btnDelElement";
            this.btnDelElement.Size = new System.Drawing.Size(75, 23);
            this.btnDelElement.TabIndex = 5;
            this.btnDelElement.Text = "Borrar";
            this.btnDelElement.UseVisualStyleBackColor = true;
            this.btnDelElement.Click += new System.EventHandler(this.btnDelElement_Click);
            // 
            // btnUpdElement
            // 
            this.btnUpdElement.Location = new System.Drawing.Point(93, 12);
            this.btnUpdElement.Name = "btnUpdElement";
            this.btnUpdElement.Size = new System.Drawing.Size(75, 23);
            this.btnUpdElement.TabIndex = 4;
            this.btnUpdElement.Text = "Actualizar";
            this.btnUpdElement.UseVisualStyleBackColor = true;
            this.btnUpdElement.Click += new System.EventHandler(this.btnUpdElement_Click);
            // 
            // btnAddElement
            // 
            this.btnAddElement.Location = new System.Drawing.Point(12, 12);
            this.btnAddElement.Name = "btnAddElement";
            this.btnAddElement.Size = new System.Drawing.Size(75, 23);
            this.btnAddElement.TabIndex = 3;
            this.btnAddElement.Text = "Añadir";
            this.btnAddElement.UseVisualStyleBackColor = true;
            this.btnAddElement.Click += new System.EventHandler(this.btnAddElement_Click);
            // 
            // dgvInfo
            // 
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(12, 41);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(412, 206);
            this.dgvInfo.TabIndex = 6;
            // 
            // CrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 258);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.btnDelElement);
            this.Controls.Add(this.btnUpdElement);
            this.Controls.Add(this.btnAddElement);
            this.Name = "CrudForm";
            this.Text = "CrudForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnDelElement;
        protected System.Windows.Forms.Button btnUpdElement;
        protected System.Windows.Forms.Button btnAddElement;
        protected System.Windows.Forms.DataGridView dgvInfo;
    }
}