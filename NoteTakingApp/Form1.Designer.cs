namespace NoteTakingApp
{
    partial class NoteTaker
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
            titleBox = new TextBox();
            NoteBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            previousNotes = new DataGridView();
            LoadButton = new Button();
            DeleteButton = new Button();
            NewnoteButton = new Button();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.Location = new Point(335, 37);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(457, 27);
            titleBox.TabIndex = 0;
            titleBox.TextChanged += textBox1_TextChanged;
            // 
            // NoteBox
            // 
            NoteBox.Location = new Point(334, 100);
            NoteBox.Multiline = true;
            NoteBox.Name = "NoteBox";
            NoteBox.Size = new Size(457, 338);
            NoteBox.TabIndex = 1;
            NoteBox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(335, 2);
            label1.Name = "label1";
            label1.Size = new Size(457, 27);
            label1.TabIndex = 2;
            label1.Text = "Title";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(335, 67);
            label2.Name = "label2";
            label2.Size = new Size(457, 30);
            label2.TabIndex = 3;
            label2.Text = "Note";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // previousNotes
            // 
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = SystemColors.ButtonHighlight;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(0, 0);
            previousNotes.Name = "previousNotes";
            previousNotes.RowHeadersWidth = 51;
            previousNotes.RowTemplate.Height = 29;
            previousNotes.Size = new Size(314, 342);
            previousNotes.TabIndex = 4;
            previousNotes.AutoSizeColumnModeChanged += fill;
            previousNotes.CellContentClick += dataGridView1_CellContentClick;
            previousNotes.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // LoadButton
            // 
            LoadButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LoadButton.Location = new Point(12, 364);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(126, 34);
            LoadButton.TabIndex = 5;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += button1_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.Location = new Point(173, 364);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(126, 34);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // NewnoteButton
            // 
            NewnoteButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            NewnoteButton.Location = new Point(12, 404);
            NewnoteButton.Name = "NewnoteButton";
            NewnoteButton.Size = new Size(126, 34);
            NewnoteButton.TabIndex = 7;
            NewnoteButton.Text = "New Note";
            NewnoteButton.UseVisualStyleBackColor = true;
            NewnoteButton.Click += NewnoteButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.Location = new Point(173, 404);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(126, 34);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += button3_Click;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveButton);
            Controls.Add(NewnoteButton);
            Controls.Add(DeleteButton);
            Controls.Add(LoadButton);
            Controls.Add(previousNotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NoteBox);
            Controls.Add(titleBox);
            Name = "NoteTaker";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleBox;
        private TextBox NoteBox;
        private Label label1;
        private Label label2;
        private DataGridView previousNotes;
        private Button LoadButton;
        private Button DeleteButton;
        private Button NewnoteButton;
        private Button SaveButton;
    }
}