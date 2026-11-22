namespace ToDoList;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        dataGridView1.Rows.Add("Hesabat", "Aylıq", "21.11.2026", false);
        dataGridView1.Rows.Add("Görüş", "Komanda", "22.11.2026", false);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox1.Text)) return;
        dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString("dd.MM.yyyy"), false);
        textBox1.Clear();
        textBox2.Clear();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex != 3) return;
        var r = MessageBox.Show("Tapşırıq silinsin?", "Silmə təsdiqi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.Yes) dataGridView1.Rows.RemoveAt(e.RowIndex);
    }
}
