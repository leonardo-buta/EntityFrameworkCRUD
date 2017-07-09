namespace WinForms
{
    partial class Form1
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelectInsert = new System.Windows.Forms.Button();
            this.btnSelectLojaProduto = new System.Windows.Forms.Button();
            this.btnSelectWhere = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateEntityState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(129, 52);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(123, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSelectInsert
            // 
            this.btnSelectInsert.Location = new System.Drawing.Point(129, 81);
            this.btnSelectInsert.Name = "btnSelectInsert";
            this.btnSelectInsert.Size = new System.Drawing.Size(123, 23);
            this.btnSelectInsert.TabIndex = 0;
            this.btnSelectInsert.Text = "Select + Insert";
            this.btnSelectInsert.UseVisualStyleBackColor = true;
            this.btnSelectInsert.Click += new System.EventHandler(this.btnSelectInsert_Click);
            // 
            // btnSelectLojaProduto
            // 
            this.btnSelectLojaProduto.Location = new System.Drawing.Point(129, 110);
            this.btnSelectLojaProduto.Name = "btnSelectLojaProduto";
            this.btnSelectLojaProduto.Size = new System.Drawing.Size(123, 23);
            this.btnSelectLojaProduto.TabIndex = 1;
            this.btnSelectLojaProduto.Text = "Select loja do produto";
            this.btnSelectLojaProduto.UseVisualStyleBackColor = true;
            this.btnSelectLojaProduto.Click += new System.EventHandler(this.btnSelectLojaProduto_Click);
            // 
            // btnSelectWhere
            // 
            this.btnSelectWhere.Location = new System.Drawing.Point(129, 139);
            this.btnSelectWhere.Name = "btnSelectWhere";
            this.btnSelectWhere.Size = new System.Drawing.Size(123, 28);
            this.btnSelectWhere.TabIndex = 1;
            this.btnSelectWhere.Text = "Select com where";
            this.btnSelectWhere.UseVisualStyleBackColor = true;
            this.btnSelectWhere.Click += new System.EventHandler(this.btnSelectWhere_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(129, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 28);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(129, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 28);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateEntityState
            // 
            this.btnUpdateEntityState.Location = new System.Drawing.Point(129, 241);
            this.btnUpdateEntityState.Name = "btnUpdateEntityState";
            this.btnUpdateEntityState.Size = new System.Drawing.Size(123, 28);
            this.btnUpdateEntityState.TabIndex = 1;
            this.btnUpdateEntityState.Text = "Update via Entity State";
            this.btnUpdateEntityState.UseVisualStyleBackColor = true;
            this.btnUpdateEntityState.Click += new System.EventHandler(this.btnUpdateEntityState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 327);
            this.Controls.Add(this.btnUpdateEntityState);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelectWhere);
            this.Controls.Add(this.btnSelectLojaProduto);
            this.Controls.Add(this.btnSelectInsert);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelectInsert;
        private System.Windows.Forms.Button btnSelectLojaProduto;
        private System.Windows.Forms.Button btnSelectWhere;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateEntityState;
    }
}

