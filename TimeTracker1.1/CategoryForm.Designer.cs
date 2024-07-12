namespace TimeTracker1._1
{
    partial class CategoryForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        
        public class WorkTitle
        {
            public string Name { get; set; }
            public WorkTitle(string name)
            {
                Name = name;
            }
        }

        public class WorkEntry
        {
            public int TimeSec { get; set; }
            public string Name { get; set; }
            public DateTime Date { get; set; }

            public WorkEntry(int timesec, string name, DateTime date)
            {
                TimeSec = timesec;
                Name = name;
                Date = date;
            }
        }
        
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
            comboBox1 = new ComboBox();
            btnAdd = new Button();
            btnDel = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 41);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(49, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(83, 41);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(50, 23);
            btnDel.TabIndex = 2;
            btnDel.Text = "del";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(148, 75);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(comboBox1);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button btnAdd;
        private Button btnDel;
    }
}