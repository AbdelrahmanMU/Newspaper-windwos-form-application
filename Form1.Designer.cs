namespace Day2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_GV = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_pdf = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_brief = new System.Windows.Forms.TextBox();
            this.txt_ref = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_author_name = new System.Windows.Forms.ComboBox();
            this.btn_add_title = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // data_GV
            // 
            this.data_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_GV.Location = new System.Drawing.Point(-1, 3);
            this.data_GV.Name = "data_GV";
            this.data_GV.RowTemplate.Height = 25;
            this.data_GV.Size = new System.Drawing.Size(589, 449);
            this.data_GV.TabIndex = 0;
            this.data_GV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_GV_RowHeaderMouseDoubleClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(680, 284);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(667, 26);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(100, 23);
            this.txt_title.TabIndex = 2;
            // 
            // txt_pdf
            // 
            this.txt_pdf.Location = new System.Drawing.Point(667, 216);
            this.txt_pdf.Name = "txt_pdf";
            this.txt_pdf.Size = new System.Drawing.Size(100, 23);
            this.txt_pdf.TabIndex = 3;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(667, 187);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(100, 23);
            this.txt_desc.TabIndex = 4;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(667, 158);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(100, 23);
            this.txt_date.TabIndex = 5;
            // 
            // txt_brief
            // 
            this.txt_brief.Location = new System.Drawing.Point(667, 129);
            this.txt_brief.Name = "txt_brief";
            this.txt_brief.Size = new System.Drawing.Size(100, 23);
            this.txt_brief.TabIndex = 6;
            // 
            // txt_ref
            // 
            this.txt_ref.Location = new System.Drawing.Point(667, 245);
            this.txt_ref.Name = "txt_ref";
            this.txt_ref.Size = new System.Drawing.Size(100, 23);
            this.txt_ref.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "News Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Reference";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Brief";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "pdf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Author ";
            // 
            // cb_author_name
            // 
            this.cb_author_name.FormattingEnabled = true;
            this.cb_author_name.Location = new System.Drawing.Point(667, 52);
            this.cb_author_name.Name = "cb_author_name";
            this.cb_author_name.Size = new System.Drawing.Size(121, 23);
            this.cb_author_name.TabIndex = 18;
            // 
            // btn_add_title
            // 
            this.btn_add_title.Location = new System.Drawing.Point(667, 81);
            this.btn_add_title.Name = "btn_add_title";
            this.btn_add_title.Size = new System.Drawing.Size(100, 23);
            this.btn_add_title.TabIndex = 21;
            this.btn_add_title.Text = "Add new title";
            this.btn_add_title.UseVisualStyleBackColor = true;
            this.btn_add_title.Click += new System.EventHandler(this.btn_add_title_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(599, 284);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(713, 284);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 23;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add_title);
            this.Controls.Add(this.cb_author_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ref);
            this.Controls.Add(this.txt_brief);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_pdf);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.data_GV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView data_GV;
        private Button btn_add;
        private TextBox txt_title;
        private TextBox txt_pdf;
        private TextBox txt_desc;
        private TextBox txt_date;
        private TextBox txt_brief;
        private TextBox txt_ref;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cb_author_name;
        private Button btn_add_title;
        private Button btn_delete;
        private Button btn_update;
    }
}