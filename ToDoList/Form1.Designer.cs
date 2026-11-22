namespace ToDoList;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        label1 = new Label();
        textBox1 = new TextBox();
        label2 = new Label();
        textBox2 = new TextBox();
        label3 = new Label();
        dateTimePicker1 = new DateTimePicker();
        button1 = new Button();
        dataGridView1 = new DataGridView();
        colAd = new DataGridViewTextBoxColumn();
        colTesvir = new DataGridViewTextBoxColumn();
        colTarix = new DataGridViewTextBoxColumn();
        colSil = new DataGridViewCheckBoxColumn();
        label4 = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();

        label1.AutoSize = true;
        label1.ForeColor = Color.DimGray;
        label1.Location = new Point(18, 12);
        label1.Text = "textBox1";

        textBox1.Location = new Point(18, 34);
        textBox1.Size = new Size(664, 29);
        textBox1.PlaceholderText = "Tapşırığın adı";

        label2.AutoSize = true;
        label2.ForeColor = Color.DimGray;
        label2.Location = new Point(18, 78);
        label2.Text = "textBox2";

        textBox2.Location = new Point(18, 100);
        textBox2.Size = new Size(664, 29);
        textBox2.PlaceholderText = "Təsvir";

        label3.AutoSize = true;
        label3.ForeColor = Color.DimGray;
        label3.Location = new Point(18, 144);
        label3.Text = "dateTimePicker1";

        dateTimePicker1.Format = DateTimePickerFormat.Custom;
        dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
        dateTimePicker1.Location = new Point(18, 166);
        dateTimePicker1.Size = new Size(664, 29);

        button1.Location = new Point(18, 214);
        button1.Size = new Size(664, 42);
        button1.Text = "Əlavə et";
        button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;

        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.AllowUserToResizeRows = false;
        dataGridView1.BackgroundColor = Color.White;
        dataGridView1.BorderStyle = BorderStyle.FixedSingle;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridView1.ColumnHeadersHeight = 34;
        dataGridView1.EnableHeadersVisualStyles = false;
        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 243, 238);
        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 243, 238);
        dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
        dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(228, 238, 250);
        dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.RowTemplate.Height = 38;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.MultiSelect = false;
        dataGridView1.Location = new Point(18, 280);
        dataGridView1.Size = new Size(664, 190);
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colAd, colTesvir, colTarix, colSil });
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;

        colAd.HeaderText = "Ad";
        colAd.Width = 180;
        colAd.ReadOnly = true;
        colAd.SortMode = DataGridViewColumnSortMode.NotSortable;

        colTesvir.HeaderText = "Təsvir";
        colTesvir.Width = 180;
        colTesvir.ReadOnly = true;
        colTesvir.SortMode = DataGridViewColumnSortMode.NotSortable;

        colTarix.HeaderText = "Tarix";
        colTarix.Width = 180;
        colTarix.ReadOnly = true;
        colTarix.SortMode = DataGridViewColumnSortMode.NotSortable;

        colSil.HeaderText = "";
        colSil.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        colSil.ReadOnly = true;
        colSil.SortMode = DataGridViewColumnSortMode.NotSortable;

        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 8.5F);
        label4.ForeColor = Color.DimGray;
        label4.Location = new Point(18, 482);
        label4.Text = "CheckBox sütununa klik → silmə təsdiqi çıxır";

        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(700, 520);
        Controls.Add(label1);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(textBox2);
        Controls.Add(label3);
        Controls.Add(dateTimePicker1);
        Controls.Add(button1);
        Controls.Add(dataGridView1);
        Controls.Add(label4);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1 — ToDoList";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    private TextBox textBox1;
    private Label label2;
    private TextBox textBox2;
    private Label label3;
    private DateTimePicker dateTimePicker1;
    private Button button1;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn colAd;
    private DataGridViewTextBoxColumn colTesvir;
    private DataGridViewTextBoxColumn colTarix;
    private DataGridViewCheckBoxColumn colSil;
    private Label label4;
}
