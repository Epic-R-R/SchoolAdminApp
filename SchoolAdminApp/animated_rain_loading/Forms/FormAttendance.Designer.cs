namespace animated_rain_loading
{
    partial class FormAttendance
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
            this.btnShowBooks = new FontAwesome.Sharp.IconButton();
            this.btnEditBook = new FontAwesome.Sharp.IconButton();
            this.btnRemoveBook = new FontAwesome.Sharp.IconButton();
            this.btnAddNewPerson = new FontAwesome.Sharp.IconButton();
            this.DgvPersons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowBooks
            // 
            this.btnShowBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.btnShowBooks.FlatAppearance.BorderSize = 0;
            this.btnShowBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBooks.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnShowBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnShowBooks.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowBooks.IconColor = System.Drawing.Color.White;
            this.btnShowBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowBooks.Location = new System.Drawing.Point(728, 446);
            this.btnShowBooks.Name = "btnShowBooks";
            this.btnShowBooks.Size = new System.Drawing.Size(196, 44);
            this.btnShowBooks.TabIndex = 8;
            this.btnShowBooks.Text = "Readout Data";
            this.btnShowBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowBooks.UseVisualStyleBackColor = false;
            this.btnShowBooks.Click += new System.EventHandler(this.btnShowBooks_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.btnEditBook.FlatAppearance.BorderSize = 0;
            this.btnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBook.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnEditBook.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditBook.IconColor = System.Drawing.Color.White;
            this.btnEditBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditBook.Location = new System.Drawing.Point(511, 446);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(196, 44);
            this.btnEditBook.TabIndex = 7;
            this.btnEditBook.Text = "Get Data";
            this.btnEditBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.btnRemoveBook.FlatAppearance.BorderSize = 0;
            this.btnRemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBook.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRemoveBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnRemoveBook.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnRemoveBook.IconColor = System.Drawing.Color.White;
            this.btnRemoveBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveBook.Location = new System.Drawing.Point(295, 446);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(196, 44);
            this.btnRemoveBook.TabIndex = 6;
            this.btnRemoveBook.Text = "Remove Person";
            this.btnRemoveBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveBook.UseVisualStyleBackColor = false;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.btnAddNewPerson.FlatAppearance.BorderSize = 0;
            this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnAddNewPerson.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddNewPerson.IconColor = System.Drawing.Color.White;
            this.btnAddNewPerson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewPerson.Location = new System.Drawing.Point(76, 446);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(196, 44);
            this.btnAddNewPerson.TabIndex = 5;
            this.btnAddNewPerson.Text = "Add Person";
            this.btnAddNewPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewPerson.UseVisualStyleBackColor = false;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // DgvPersons
            // 
            this.DgvPersons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.DgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersons.Location = new System.Drawing.Point(23, 5);
            this.DgvPersons.Name = "DgvPersons";
            this.DgvPersons.Size = new System.Drawing.Size(954, 430);
            this.DgvPersons.TabIndex = 9;
            // 
            // FormAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(991, 498);
            this.Controls.Add(this.DgvPersons);
            this.Controls.Add(this.btnShowBooks);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnAddNewPerson);
            this.Name = "FormAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.FormAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnShowBooks;
        private FontAwesome.Sharp.IconButton btnEditBook;
        private FontAwesome.Sharp.IconButton btnRemoveBook;
        private FontAwesome.Sharp.IconButton btnAddNewPerson;
        private System.Windows.Forms.DataGridView DgvPersons;
    }
}